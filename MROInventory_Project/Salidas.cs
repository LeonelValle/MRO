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
    public partial class Salidas : Form
    {
        public Salidas()
        {
            InitializeComponent();
        }


        private readonly Salida salida = new Salida();
        private readonly Nparte nparte = new Nparte();
        //private readonly Usuarios usuarios = new Usuarios();
        private readonly Area area = new Area();
        private readonly Planta planta = new Planta();
        private readonly Inventario inventario = new Inventario();

        private void Salidas_Load(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToString();

            cb_area.DataSource = area.FillCB("select * from tb_Area");
            cb_area.ValueMember = "id_area";
            cb_area.DisplayMember = "area";
            this.cb_area.SelectedItem = null;

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

            dataGridView1.DataSource = salida.LlenarDG("select top 10 s.fechaSalida, s.cantidad, n.nparte, mfg, s.Usuario as EmpaleadoEntrega, a.area, s.entregausuario as EmpleadoSolicitante, p.planta from tb_Salida s join tb_Nparte n on s.id_nparte = n.id_nparte join tb_Area a on s.id_area = a.id_area join tb_Planta p on s.id_planta = p.id_planta where s.id_planta = " + planta.Id_planta + " order by id_salida desc").Tables[0];
        }

        private AutoCompleteStringCollection LoadAutoComplete()
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

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {

                //salida.FechaCaducidad = DateTime.Parse(salida.ReturnValue("select caducidad from tb_Caducidad where id_nparte = '" + cb_nparte.SelectedValue + "'"));

                inventario.Id_inventario = int.Parse(inventario.ReturnValue("select id_inventario from tb_inventario where id_nparte = " + cb_nparte.SelectedValue + " and id_planta = " + planta.Id_planta));
                if (txt_cantidad.Text.Trim() == string.Empty || txt_descripcion.Text.Trim() == string.Empty || txt_empleadoentrega.Text.Trim() == string.Empty ||
                string.IsNullOrEmpty(cb_nparte.Text) || txt_Nempleado.Text.Trim() == string.Empty || string.IsNullOrEmpty(cb_area.Text))
                    MessageBox.Show("Llene todos los campos!");
                else if (inventario.Stock < int.Parse(txt_cantidad.Text) || int.Parse(txt_cantidad.Text) <= 0)
                    MessageBox.Show("La cantidad es mayor al Stock en inventario o es 0!", "WARNING");

                else
                {
                    if (ckb_caducidad.Checked == false)
                    {
                        salida.InventarioSalida((int)cb_nparte.SelectedValue, int.Parse(txt_Nempleado.Text), int.Parse(txt_cantidad.Text), DateTime.Now, txt_empleadoentrega.Text, (int)cb_area.SelectedValue, planta.Id_planta, inventario.Id_inventario);

                    }
                    else
                    {
                        if (salida.Exists("select count(*) from tb_Caducidad where id_nparte = '" + cb_nparte.SelectedValue + "' and label = '" + txt_label.Text.Trim() + "' "))
                        {
                            salida.InventarioSalidaCaducidad((int)cb_nparte.SelectedValue, int.Parse(txt_Nempleado.Text), int.Parse(txt_cantidad.Text), DateTime.Now, txt_empleadoentrega.Text, (int)cb_area.SelectedValue, planta.Id_planta, inventario.Id_inventario, txt_label.Text.Trim());

                        }
                        else
                        {
                            MessageBox.Show("No se encontro!");
                        }
                    }
                    ToEmpty();
                    Salidas_Load(sender, e);
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
            txt_descripcion.Text = "";
            txt_empleadoentrega.Text = "";
            txt_Nempleado.Text = "";
            this.cb_nparte.SelectedItem = null;
            //this.cb_noempleado.SelectedItem = null;
            this.cb_area.SelectedItem = null;
            ckb_caducidad.Checked = false;
            txt_label.Text = "";
            txt_label.Visible = false;
            lbl_caducidad.Visible = false;

        }

        private void cb_nparte_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_descripcion.Text = nparte.ReturnValue("select descripcion from tb_Nparte where id_nparte = " + cb_nparte.SelectedValue);
            txt_PN.Text = nparte.ReturnValue("select nparte from tb_Nparte where id_nparte = " + cb_nparte.SelectedValue);
            inventario.Stock = int.Parse(inventario.ReturnValue("select stock from tb_Inventario where id_nparte = " + cb_nparte.SelectedValue + " and id_planta = " + planta.Id_planta));


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

        private void ckb_caducidad_CheckedChanged(object sender, EventArgs e)
        {
            txt_label.Visible = true;
            lbl_caducidad.Visible = true;
        }
    }
}
