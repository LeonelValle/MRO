using System;
using System.Data;
using System.Windows.Forms;

namespace MROInventory_Project
{
    public partial class Po : Form
    {
        private readonly Nparte nparte = new Nparte();
        private readonly Po_s po = new Po_s();
        readonly Planta planta = new Planta();
        readonly Usuarios usuarios = new Usuarios();
        readonly Inventario inventario = new Inventario();
        private readonly Entrada entrada = new Entrada();

        public Po()
        {
            InitializeComponent();
        }


        public AutoCompleteStringCollection LoadAutoCompletePO()
        {
            DataTable dt = po.FillCB("select po from tb_Po ");

            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row["po"]));
            }

            return stringCol;
        }


        public AutoCompleteStringCollection LoadAutoComplete()
        {
            DataTable dt = nparte.FillCB("select id_nparte, nparte  from tb_Nparte");

            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row["nparte"]));
            }

            return stringCol;
        }

        private void Po_Load(object sender, EventArgs e)
        {
            cb_nparte.DataSource = nparte.FillCB("select id_nparte, nparte from tb_Nparte");
            cb_nparte.DisplayMember = "nparte";
            cb_nparte.ValueMember = "id_nparte";
            this.cb_nparte.SelectedItem = null;

            cb_nparte.AutoCompleteCustomSource = LoadAutoComplete();
            cb_nparte.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_nparte.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cb_DeletePN.DataSource = nparte.FillCB("select id_po, po from tb_Po");
            cb_DeletePN.DisplayMember = "po";
            cb_DeletePN.ValueMember = "id_po";
            this.cb_DeletePN.SelectedItem = null;

            cb_DeletePN.AutoCompleteCustomSource = LoadAutoComplete();
            cb_DeletePN.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_DeletePN.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cb_POSearch.DataSource = nparte.FillCB("select id_po, po from tb_Po");
            cb_POSearch.DisplayMember = "po";
            cb_POSearch.ValueMember = "id_po";
            this.cb_POSearch.SelectedItem = null;

            cb_POSearch.AutoCompleteCustomSource = LoadAutoComplete();
            cb_POSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_POSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //tabControl1.TabPages.Remove(tabPage2);
            //tabPage2
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_po.Text != "" && txt_cantidad.Text != "" && this.cb_nparte.SelectedItem != null)
            {
                inventario.Id_inventario = int.Parse(inventario.ReturnValue("select id_inventario from tb_inventario where id_nparte = " + cb_nparte.SelectedValue + " and id_planta = " + planta.Id_planta));


                if (!(po.Exists("select COUNT(*) from tb_Po where po = '" + txt_po.Text + "'")))
                {

                    po.Id_po = int.Parse(po.ReturnID("insert into tb_Po(po, cantidad, fecha, id_planta) values('" + txt_po.Text + "','" + txt_cantidad.Text + "','" + dateTimePicker1.Value + "','" + planta.Id_planta + "'); SELECT SCOPE_IDENTITY(); "));
                    po.Crud("insert into tbUnion_InvetarioPo values('" + po.Id_po + "','" + cb_nparte.SelectedValue + "','" + txt_cantidad.Text + "','" + dateTimePicker1.Value + "','" + planta.Id_planta + "')");
                    //entrada.InventarioEntrada((int)cb_nparte.SelectedValue, usuarios.Id_usuario, int.Parse(txt_cantidad.Text), dateTimePicker1.Value, "1er", usuarios.Nempleado, planta.Id_planta, inventario.Id_inventario);

                }
                else
                {

                    //po.Id_po = int.Parse(po.ReturnID("insert into tb_Po(po, cantidad, fecha, id_planta) values('" + txt_po.Text + "','" + txt_cantidad.Text + "','" + dateTimePicker1.Value + "','" + planta.Id_planta + "'); SELECT SCOPE_IDENTITY(); "));

                    po.Id_po = int.Parse(po.ReturnID("select id_po from tb_Po where po = '" + txt_po.Text + "'"));
                    po.Crud("insert into tbUnion_InvetarioPo values('" + po.Id_po + "','" + cb_nparte.SelectedValue + "','" + txt_cantidad.Text + "','" + dateTimePicker1.Value + "','" + planta.Id_planta + "')");
                    //entrada.InventarioEntrada((int)cb_nparte.SelectedValue, usuarios.Id_usuario, int.Parse(txt_cantidad.Text), dateTimePicker1.Value, "1er", usuarios.Nempleado, planta.Id_planta, inventario.Id_inventario);

                }

                MessageBox.Show("Done!");
                ToEmpty();
                Po_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Fill all info!");
            }
        }

        private void ToEmpty()
        {
            txt_cantidad.Text = "";
            txt_po.Text = "";
            this.cb_nparte.SelectedItem = null;
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_cantidad.Text = "";
            txt_po.Text = "";
            this.cb_nparte.SelectedItem = null;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (cb_DeletePN.SelectedItem != null && cb_DeletePN.SelectedItem != null)
            {
                po.Crud("delete tbUnion_InvetarioPo where id_po = '" + (int)cb_DeletePN.SelectedValue + "' and id_nparte = '" + (int)cb_PNDelete.SelectedValue + "'");
                MessageBox.Show("Done!");
                ToEmpty();
                Po_Load(sender, e);
            }
        }

        private void cb_DeletePN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_DeletePN.SelectedValue != null)
                {
                    string sql = string.Format("select pn.id_nparte, pn.nparte from tb_Nparte pn join tbUnion_InvetarioPo uip on pn.id_nparte = uip.id_nparte join tb_Po po on po.id_po = uip.id_po where po.id_po = '" + (int)cb_DeletePN.SelectedValue + "' and po.checked is null or po.checked = 'false'");
                    cb_PNDelete.DataSource = po.FillCB(sql);
                    cb_PNDelete.DisplayMember = "nparte";
                    cb_PNDelete.ValueMember = "id_nparte";
                    cb_PNDelete.Enabled = true;
                }

            }
            catch (System.InvalidCastException)
            {

                //throw;
            }
        }

        private void cb_POSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_POSearch.SelectedValue != null)
                {
                    string sql = string.Format("select pn.id_nparte, pn.nparte from tb_Nparte pn join tbUnion_InvetarioPo uip on pn.id_nparte = uip.id_nparte join tb_Po po on po.id_po = uip.id_po where po.id_po = '" + (int)cb_POSearch.SelectedValue + "' and po.checked is null or po.checked = 'false'");
                    cb_UpdatePN.DataSource = po.FillCB(sql);
                    cb_UpdatePN.DisplayMember = "nparte";
                    cb_UpdatePN.ValueMember = "id_nparte";
                    cb_UpdatePN.Enabled = true;
                    GetTableUpdate();
                }

            }
            catch (System.InvalidCastException)
            {

                //throw;
            }
        }

        private void GetTableUpdate()
        {

            try
            {

                _ = new DataTable();
                //dt = inventario.FillCB("select n.descripcion, i.stock, i.min,i.max,i.LD,c.caracteristicas, p.presentacion, s.supplier, i.alerta,  i.qtypresentacion  from tb_Inventario i join tb_Caracteristicas c on i.id_caracteristicas = c.id_caracteristicas join tb_Nparte n on i.id_nparte = n.id_nparte join tb_Supplier s on i.id_supplier = s.id_supplier join tb_Presentacion p on i.id_presentacion = p.id_presentacion where i.id_inventario = " + inventario.Id_inventario);
                DataTable dt = inventario.FillCB("select uip.cantidad, uip.fecha from tb_Po po join tbUnion_InvetarioPo uip on po.id_po = uip.id_po join tb_Nparte pn on uip.id_nparte = pn.id_nparte and pn.id_nparte = '" + (int)cb_UpdatePN.SelectedValue + "' and po.id_po = '" + (int)cb_POSearch.SelectedValue + "'");

                //inventario.Id_nparte = int.Parse(dt.Rows[0]["id_nparte"].ToString());

                txt_NewQty.Text = dt.Rows[0]["cantidad"].ToString();
                txt_dateNew.Text = dt.Rows[0]["fecha"].ToString();
            }
            catch (System.InvalidCastException) 
            {

                //throw;
            }
            catch (System.NullReferenceException)
            {

                //throw;
            }
        }

        private void btn_SubmitUpdate_Click(object sender, EventArgs e)
        {
            if (cb_UpdatePN.SelectedItem != null && cb_POSearch.SelectedItem != null)
            {
                po.Crud("update tbUnion_InvetarioPo set cantidad = '" + txt_NewQty.Text + "', fecha = '" + txt_dateNew.Value + "' where id_nparte = '" + (int)cb_UpdatePN.SelectedValue + "' and id_po = '" + (int)cb_POSearch.SelectedValue + "'");
                MessageBox.Show("Done!");
                ToEmpty();
                Po_Load(sender, e);
            }
        }

        private void cb_UpdatePN_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTableUpdate();
        }
    }
}
