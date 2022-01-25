using System;
using System.Data;
using System.Windows.Forms;

namespace MROInventory_Project
{
    public partial class Entradas : Form
    {
        public Entradas()
        {
            InitializeComponent();
        }

        private readonly Nparte nparte = new Nparte();
        private readonly Planta planta = new Planta();
        private readonly Entrada entrada = new Entrada();
        private readonly Inventario inventario = new Inventario();
        private readonly Usuarios usuarios = new Usuarios();
        private readonly Po_s po = new Po_s();


        private void Entradas_Load(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToString();
            string turno = int.Parse(DateTime.Now.TimeOfDay.ToString("hh")) >= 5 && int.Parse(DateTime.Now.TimeOfDay.ToString("hh")) <= 16 ? "PRIMER TURNO" : "SEGUNDO TURNO";

            txt_turno.Text = turno;

            #region Carga Combobox
            if (cb_Filtro.Text == "Part N#")
            {
                cb_nparte.DataSource = nparte.FillCB("select n.id_nparte, n.nparte, n.mfg from tb_Inventario i join tb_Nparte n on i.id_nparte = n.id_nparte where i.obsoleto != 1 and i.id_planta = " + planta.Id_planta);
                cb_nparte.DisplayMember = "nparte";
                cb_nparte.ValueMember = "id_nparte";
                this.cb_nparte.SelectedItem = null;

                cb_nparte.AutoCompleteCustomSource = LoadAutoComplete();
                cb_nparte.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb_nparte.AutoCompleteSource = AutoCompleteSource.CustomSource;

                //dv_Po.Columns[0].Visible = false;
            }
            else if (cb_Filtro.Text == "Item Masterwork")
            {
                cb_nparte.DataSource = nparte.FillCB("select n.id_nparte, n.nparte, n.mfg from tb_Inventario i join tb_Nparte n on i.id_nparte = n.id_nparte where i.obsoleto != 1 and i.id_planta = " + planta.Id_planta);
                cb_nparte.DisplayMember = "mfg";
                cb_nparte.ValueMember = "id_nparte";
                this.cb_nparte.SelectedItem = null;

                cb_nparte.AutoCompleteCustomSource = LoadAutoComplete();
                cb_nparte.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb_nparte.AutoCompleteSource = AutoCompleteSource.CustomSource;


                //dv_Po.Columns[0].Visible = false;
            }


            //dataGridView1.DataSource = entrada.LlenarDG("select top 10 n.nparte, n.descripcion, e.cantidad, e.turno, e.noempleado as EmpleadoRecibe, e.fechaEntrada from tb_Entrada e join tb_Nparte n on e.id_nparte = n.id_nparte join tb_Usuario u on e.id_usuario = u.id_usuario and id_planta = " + planta.Id_planta + " order by id_entrada desc").Tables[0];


            //inventario.Id_inventario = int.Parse(inventario.ReturnValue("select id_inventario from tb_inventario where id_nparte = " + cb_nparte.SelectedValue + " and id_planta = " + planta.Id_planta));
            #endregion
        }

        private AutoCompleteStringCollection LoadAutoComplete()
        {
            //DataTable dt = nparte.FillCB("select * from tb_Nparte");
            DataTable dt = nparte.FillCB("select n.id_nparte, n.nparte, mfg from tb_Inventario i join tb_Nparte n on i.id_nparte = n.id_nparte where i.obsoleto = 0 and i.id_planta = " + planta.Id_planta);


            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            if (cb_Filtro.Text == "Part N#")
            {
                foreach (DataRow row in dt.Rows)
                {
                    stringCol.Add(Convert.ToString(row["nparte"]));
                }

            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    stringCol.Add(Convert.ToString(row["mfg"]));
                }

            }

            return stringCol;
        }

        private void cb_nparte_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                inventario.Id_inventario = int.Parse(inventario.ReturnValue("select id_inventario from tb_inventario where id_nparte = " + cb_nparte.SelectedValue + " and id_planta = " + planta.Id_planta));

                txt_desc.Text = nparte.ReturnValue("select descripcion from tb_Nparte where id_nparte = " + cb_nparte.SelectedValue);

                txt_PN.Text = nparte.ReturnValue("select nparte from tb_Nparte where id_nparte = " + cb_nparte.SelectedValue);

                dv_Po.DataSource = po.LlenarDG("select po.id_po, po.po, uip.cantidad from tb_Po po join tbUnion_InvetarioPo uip on po.id_po = uip.id_po join tb_Nparte n on uip.id_nparte = n.id_nparte where n.id_nparte = '" + cb_nparte.SelectedValue + "' and po.checked is null  or po.checked = 'false' ").Tables[0];
                dv_Po.Columns[1].Visible = false;
            }
            catch (Exception)
            {

                //throw;
            }

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_cantidad.Text.Trim() == string.Empty || txt_desc.Text.Trim() == string.Empty ||
                txt_noempleado.Text.Trim() == string.Empty || txt_turno.Text.Trim() == string.Empty || string.IsNullOrEmpty(cb_nparte.Text))
                    MessageBox.Show("Llene todos los campos!", "ERROR");
                else if (int.Parse(txt_cantidad.Text) <= 0)
                    MessageBox.Show("No se admiten entradas menores a 0!", "ERROR");
                else
                {
                    if (ckb_caducidad.Checked == false)
                    {
                        //inventario.Id_inventario = int.Parse(inventario.ReturnValue("select id_inventario from tb_inventario where id_nparte = " + cb_nparte.SelectedValue + " and id_planta = " + planta.Id_planta));
                        entrada.InventarioEntradaC((int)cb_nparte.SelectedValue, usuarios.Id_usuario, int.Parse(txt_cantidad.Text), DateTime.Now, txt_turno.Text, int.Parse(txt_noempleado.Text), planta.Id_planta, inventario.Id_inventario);
                        po.Crud("update tb_Po set checked = '" + po.Check + "' where id_po = " + po.Id_po);

                    }
                    else
                    {
                        entrada.InventarioEntradaCaducidad((int)cb_nparte.SelectedValue, usuarios.Id_usuario, int.Parse(txt_cantidad.Text), DateTime.Now, txt_turno.Text, int.Parse(txt_noempleado.Text), planta.Id_planta, inventario.Id_inventario, dateTimePicker1.Value, cb_nparte.Text);
                        po.Crud("update tb_Po set checked = '" + po.Check + "' where id_po = " + po.Id_po);

                        MessageBox.Show("ALCOHOL123-072321","Label Created!");
                    }
                    ToEmpty();
                    Entradas_Load(sender, e);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ToEmpty()
        {
            txt_cantidad.Text = "";
            txt_desc.Text = "";
            txt_noempleado.Text = "";
            this.cb_nparte.SelectedItem = null;
            ckb_caducidad.Checked = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            ToEmpty();
        }


        private void dv_Po_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)dv_Po.CurrentCell;
                DataGridViewCell cell = (DataGridViewCheckBoxCell)dv_Po.CurrentCell;

                //bool isChecked = (bool)checkbox.EditedFormattedValue;
                po.Check = (bool)checkbox.EditedFormattedValue;
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dv_Po.Rows[e.RowIndex];
                    // if (cell != null)
                    po.Id_po = int.Parse(row.Cells["id_po"].Value.ToString());
                }

            }
            catch (System.InvalidCastException)
            {

                throw;
            }
        }

        private void cb_Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Carga Combobox
            if (cb_Filtro.Text == "Part N#")
            {
                cb_nparte.DataSource = nparte.FillCB("select n.id_nparte, n.nparte, n.mfg from tb_Inventario i join tb_Nparte n on i.id_nparte = n.id_nparte where i.obsoleto != 1 and i.id_planta = " + planta.Id_planta);
                cb_nparte.DisplayMember = "nparte";
                cb_nparte.ValueMember = "id_nparte";
                this.cb_nparte.SelectedItem = null;

                cb_nparte.AutoCompleteCustomSource = LoadAutoComplete();
                cb_nparte.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb_nparte.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            else if (cb_Filtro.Text == "Item Masterwork")
            {
                cb_nparte.DataSource = nparte.FillCB("select n.id_nparte, n.nparte, n.mfg from tb_Inventario i join tb_Nparte n on i.id_nparte = n.id_nparte where i.obsoleto != 1 and i.id_planta = " + planta.Id_planta);
                cb_nparte.DisplayMember = "mfg";
                cb_nparte.ValueMember = "id_nparte";
                this.cb_nparte.SelectedItem = null;

                cb_nparte.AutoCompleteCustomSource = LoadAutoComplete();
                cb_nparte.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb_nparte.AutoCompleteSource = AutoCompleteSource.CustomSource;

            }

            //dv_Po.Columns[0].Visible = false;
            #endregion
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ckb_caducidad_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            lbl_caducidad.Visible = true;
        }
    }

}

