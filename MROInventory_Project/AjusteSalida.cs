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
    public partial class AjusteSalida : Form
    {
        public AjusteSalida()
        {
            InitializeComponent();
        }


        private readonly Planta planta = new Planta();
        //private readonly Usuarios usuarios = new Usuarios();
        private readonly Nparte nparte = new Nparte();
        private readonly Area area = new Area();
        private readonly Salida salida = new Salida();
        private readonly Inventario inventario = new Inventario();


        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            inventario.Id_inventario = int.Parse(inventario.ReturnValue("select id_inventario from tb_inventario where id_nparte = " + cb_nparte.SelectedValue + " and id_planta = " + planta.Id_planta));

            if (txt_cantidad.Text.Trim() == string.Empty || txt_descripcion.Text.Trim() == string.Empty ||
                string.IsNullOrEmpty(cb_nparte.Text) || txt_Nempleado.Text.Trim() == string.Empty)
                MessageBox.Show("Llene todos los campos!");
            else if (inventario.Stock < int.Parse(txt_cantidad.Text) || int.Parse(txt_cantidad.Text) <= 0)
                MessageBox.Show("La cantidad es mayor al Stock en inventario o es 0!", "WARNING");
            else
            {
                salida.InventarioSalida((int)cb_nparte.SelectedValue, int.Parse(txt_Nempleado.Text), int.Parse(txt_cantidad.Text), DateTime.Now, planta.Id_planta, inventario.Id_inventario, txt_justficacion.Text);
                ToEmpty();
                AjusteSalida_Load(sender, e);
            }

        }

        private void AjusteSalida_Load(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToString();

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

            //dataGridView1.DataSource = salida.LlenarDG("select top 10 s.fechaSalida, s.cantidad, n.nparte, s.Usuario, a.area, s.entregausuario, p.planta , s.Ajusteinventario from tb_Salida s join tb_Nparte n on s.id_nparte = n.id_nparte join tb_Area a on s.id_area = a.id_area join tb_Planta p on s.id_planta = p.id_planta where s.AjusteInventario is not null and s.id_planta = " + planta.Id_planta + " order by id_salida desc").Tables[0];
            dataGridView1.DataSource = salida.LlenarDG("select top 10 n.nparte, mfg,fechaSalida, cantidad, s.Usuario, s.AjusteInventario from tb_Salida s join tb_Nparte n on s.id_nparte = n.id_nparte where AjusteInventario is not null and s.id_planta = " + planta.Id_planta + " order by id_salida desc").Tables[0];
        }

        private AutoCompleteStringCollection LoadAutoComplete()
        {
            DataTable dt = nparte.FillCB("select n.id_nparte, n.nparte,mfg from tb_Inventario i join tb_Nparte n on i.id_nparte = n.id_nparte where i.id_planta = " + planta.Id_planta);

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

        private void ToEmpty()
        {
            txt_cantidad.Text = "";
            txt_descripcion.Text = "";
            txt_justficacion.Text = "";
            txt_Nempleado.Text = "";
            cb_nparte.SelectedItem = null;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            ToEmpty();


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
    }
}
