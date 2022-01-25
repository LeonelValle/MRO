using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MROInventory_Project
{
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }

        private readonly Nparte nparte = new Nparte();
        private readonly Planta planta = new Planta();
        private readonly Inventario inventario = new Inventario();
        private readonly TipoUsuario tipoUsuarios = new TipoUsuario();

        private void Busqueda_Load(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToString();



        }

        public AutoCompleteStringCollection LoadAutoComplete()
        {
            DataTable dt = nparte.FillCB("select n.id_nparte, n.nparte, n.mfg from tb_Inventario i join tb_Nparte n on i.id_nparte = n.id_nparte where i.id_planta = " + planta.Id_planta);

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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (!(cb_nparte.SelectedIndex < 0))
            {
                int countLocacion = 0;
                int countArea = 0;


                inventario.Id_inventario = int.Parse(inventario.ReturnID("select id_inventario from tb_Inventario where id_nparte = " + cb_nparte.SelectedValue + " and id_planta = " + planta.Id_planta));

                GetTable();


                txt_purch.Text = (int.Parse(txt_stock.Text) - int.Parse(txt_max.Text)).ToString();

                if (txt_caracteristicas.Text == "Chemical Consumables")
                {
                    lbl_advertencia.Visible = true;
                    lbl_consejo.Visible = true;
                    lbl_peligro.Visible = true;
                    txt_peligro.Visible = true;
                    txt_precaucion.Visible = true;
                    txt_advertencia.Visible = true;
                }
                else
                {
                    lbl_advertencia.Visible = false;
                    lbl_consejo.Visible = false;
                    lbl_peligro.Visible = false;
                    txt_peligro.Visible = false;
                    txt_precaucion.Visible = false;
                    txt_advertencia.Visible = false;
                }

                if (txt_mensaje.Text == "PROXIMA COMPRA")
                    txt_mensaje.BackColor = Color.Yellow;
                else if (txt_mensaje.Text == "DEMASIADO MATERIAL EN STOCK")
                    txt_mensaje.BackColor = Color.Cyan;
                else if (txt_mensaje.Text == "COMPRAR")
                    txt_mensaje.BackColor = Color.Red;
                else if (txt_mensaje.Text == "OK")
                    txt_mensaje.BackColor = Color.Green;

                _ = new List<Locacion>();
                List<Locacion> listLocacion = inventario.ListLocacion("select locacion from tb_Inventario i, tb_Locacion l, tbUnion_LocacionInventario li where i.id_inventario = li.id_inventario and l.id_locacion = li.id_locacion  and i.id_inventario = " + inventario.Id_inventario);
                _ = new List<Area>();
                List<Area> listArea = inventario.ListArea("select area from tb_Inventario i, tb_Area a, tbUnion_AreaInventario ai where i.id_inventario = ai.id_inventario and a.id_area = ai.id_area  and i.id_inventario = " + inventario.Id_inventario);

                if (inventario.Obsoleto == false)
                    cb_obsoleto.Text = "No obsoleto";
                else
                    cb_obsoleto.Text = "Obsoleto";

                txt_area.Text = "";
                txt_locacion.Text = "";
                foreach (var item in listLocacion)
                {
                    txt_locacion.Text += item.Locaciones;
                    countLocacion++;
                    if (countLocacion <= listLocacion.Count - 1)
                        txt_locacion.Text += ",";
                }

                foreach (var item in listArea)
                {
                    txt_area.Text += item.Areas;
                    countArea++;
                    if (countArea <= listArea.Count - 1)
                        txt_area.Text += ",";
                }

                pictureBox1.Image = nparte.ReturnPictures((int)cb_nparte.SelectedValue);
            }
            else
            {
                MessageBox.Show("Seleccione un numero de parte a buscar!");
            }
        }

        private void cb_obsoleto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_obsoleto.Text == "Obsoleto")
            {
                inventario.Obsoleto = true;
                if (tipoUsuarios.Id_tipousuario == 1 || tipoUsuarios.Id_tipousuario == 4)
                {
                    DialogResult dialogResult = MessageBox.Show("Obsoleto?", "Obsoletar", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        inventario.Crud("update tb_Inventario set obsoleto = '" + inventario.Obsoleto + "' where id_inventario = " + inventario.Id_inventario);

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        cb_obsoleto.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("No tienes permiso de administrador!", "WARNING", MessageBoxButtons.OK);

                }
            }
        }


        private void GetTable()
        {
            _ = new DataTable();
            //dt = inventario.FillCB("select n.descripcion, i.stock, i.min,i.max,i.LD,c.caracteristicas, p.presentacion, s.supplier, i.alerta,  i.qtypresentacion  from tb_Inventario i join tb_Caracteristicas c on i.id_caracteristicas = c.id_caracteristicas join tb_Nparte n on i.id_nparte = n.id_nparte join tb_Supplier s on i.id_supplier = s.id_supplier join tb_Presentacion p on i.id_presentacion = p.id_presentacion where i.id_inventario = " + inventario.Id_inventario);
            DataTable dt = inventario.FillCB("select n.id_nparte, n.descripcion, i.stock, i.min,i.max,i.LD,c.caracteristicas, p.presentacion, s.supplier, i.alerta, i.qtypresentacion, u.usuario, i.obsoleto, i.indicaciones, i.palabraAdvetencia, i.consejos, i.FechaIngreso  from tb_Inventario i join tb_Caracteristicas c on i.id_caracteristicas = c.id_caracteristicas join tb_Nparte n on i.id_nparte = n.id_nparte join tb_Supplier s on i.id_supplier = s.id_supplier join tb_Presentacion p on i.id_presentacion = p.id_presentacion join tb_Usuario u on i.id_comprador = u.id_usuario where i.id_inventario = " + inventario.Id_inventario);

            inventario.Id_nparte = int.Parse(dt.Rows[0]["id_nparte"].ToString());

            txt_descripcion.Text = dt.Rows[0]["descripcion"].ToString();
            txt_stock.Text = dt.Rows[0]["stock"].ToString();
            txt_min.Text = dt.Rows[0]["min"].ToString();
            txt_max.Text = dt.Rows[0]["max"].ToString();
            txt_lt.Text = dt.Rows[0]["LD"].ToString();
            txt_caracteristicas.Text = dt.Rows[0]["caracteristicas"].ToString();
            txt_presentacion.Text = dt.Rows[0]["presentacion"].ToString();
            txt_supplier.Text = dt.Rows[0]["supplier"].ToString();
            txt_mensaje.Text = dt.Rows[0]["alerta"].ToString();
            txt_qtypresentacion.Text = dt.Rows[0]["qtypresentacion"].ToString();
            txt_comprador.Text = dt.Rows[0]["usuario"].ToString();
            txt_advertencia.Text = dt.Rows[0]["palabraAdvetencia"].ToString();
            txt_peligro.Text = dt.Rows[0]["indicaciones"].ToString();
            txt_precaucion.Text = dt.Rows[0]["consejos"].ToString();
            txt_FechaIngreso.Text = dt.Rows[0]["FechaIngreso"].ToString();
            inventario.Obsoleto = bool.Parse(dt.Rows[0]["obsoleto"].ToString());
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

        //private void EmptyAll()
        //{
        //    foreach (Control c in Controls)
        //    {
        //        if (c is TextBox)
        //        {
        //            c.Text = "";
        //        }
        //    }
        //}
    }
}
