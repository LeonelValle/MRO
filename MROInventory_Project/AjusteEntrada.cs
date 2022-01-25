using System;
using System.Data;
using System.Windows.Forms;

namespace MROInventory_Project
{
    public partial class AjusteEntrada : Form
    {
        public AjusteEntrada()
        {
            InitializeComponent();
        }


        private readonly Inventario inventario = new Inventario();
        private readonly Planta planta = new Planta();
        private readonly Nparte nparte = new Nparte();
        private readonly Entrada entrada = new Entrada();
        private readonly Usuarios usuarios = new Usuarios();

        private void AjusteEntrada_Load(object sender, EventArgs e)
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

            //dataGridView1.DataSource = entrada.LlenarDG("select top 10 n.nparte, n.descripcion, e.cantidad, e.turno, e.noempleado, e.fechaEntrada, e.Ajusteinventario from tb_Entrada e join tb_Nparte n on e.id_nparte = n.id_nparte join tb_Usuario u on e.id_usuario = u.id_usuario and id_planta = " + planta.Id_planta + " where e.Ajusteinventario is not null order by id_entrada desc").Tables[0];
            dataGridView1.DataSource = entrada.LlenarDG("select n.nparte,mfg, e.cantidad, e.fechaEntrada from tb_Entrada e join tb_Nparte n on e.id_nparte = n.id_nparte where e.AjusteInventario is not null and e.id_planta = " + planta.Id_planta + " order by e.id_entrada desc").Tables[0];
            #endregion
        }

        public AutoCompleteStringCollection LoadAutoComplete()
        {
            DataTable dt = nparte.FillCB("select n.id_nparte, n.nparte, mfg from tb_Inventario i join tb_Nparte n on i.id_nparte = n.id_nparte where i.id_planta = " + planta.Id_planta);

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
            txt_desc.Text = nparte.ReturnValue("select descripcion from tb_Nparte where id_nparte = " + cb_nparte.SelectedValue);
            txt_PN.Text = nparte.ReturnValue("select nparte from tb_Nparte where id_nparte = " + cb_nparte.SelectedValue);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            inventario.Id_inventario = int.Parse(inventario.ReturnValue("select id_inventario from tb_inventario where id_nparte = " + cb_nparte.SelectedValue + " and id_planta = " + planta.Id_planta));

            if (txt_cantidad.Text.Trim() == string.Empty || txt_desc.Text.Trim() == string.Empty || txt_justificacion.Text.Trim() == string.Empty ||
                txt_noempleado.Text.Trim() == string.Empty || txt_turno.Text.Trim() == string.Empty || string.IsNullOrEmpty(cb_nparte.Text))
            {
                MessageBox.Show("Llene todos los campos!");
            }
            else
            {
                entrada.InventarioEntradaC((int)cb_nparte.SelectedValue, usuarios.Id_usuario, int.Parse(txt_cantidad.Text), DateTime.Now, txt_turno.Text, int.Parse(txt_cantidad.Text), planta.Id_planta, inventario.Id_inventario, txt_justificacion.Text.ToUpper());
                ToEmpty();
                AjusteEntrada_Load(sender, e);
            }

        }

        private void ToEmpty()
        {
            txt_cantidad.Text = "";
            txt_desc.Text = "";
            txt_turno.Text = "";
            txt_justificacion.Text = "";
            txt_noempleado.Text = "";
            cb_nparte.SelectedItem = null;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            ToEmpty();
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


            #endregion
        }
    }
}
