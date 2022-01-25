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
    public partial class Inventarios : Form
    {
        public Inventarios()
        {
            InitializeComponent();
        }

        private readonly Nparte nparte = new Nparte();
        private readonly Area area = new Area();
        private readonly Locacion locacion = new Locacion();
        private readonly Usuarios usuarios = new Usuarios();
        private readonly Supplier supplier = new Supplier();
        private readonly Presentacion presentacion = new Presentacion();
        private readonly Caracteristicas caracteristicas = new Caracteristicas();
        private readonly Inventario inventario = new Inventario();
        private readonly Planta planta = new Planta();
        private readonly InventarioArea inventarioArea = new InventarioArea();
        private readonly InventarioLocacion inventarioLocacion = new InventarioLocacion();

        private readonly List<int> areaList = new List<int>();
        private readonly List<int> locacionList = new List<int>();

        private void Inventarios_Load(object sender, EventArgs e)
        {
            try
            {
                txt_consejos.MaxLength = 255;
                txt_IndicacionesPeligro.MaxLength = 255;
                #region Cargar de ComboBoxes
                //cb_nparte.DataSource = nparte.FillCB("select n.id_nparte, n.nparte from tb_Inventario i join tbUnion_PlantaInventario upi on i.id_inventario = upi.id_inventario left join tb_Planta p on p.id_planta = upi.id_planta right join tb_Nparte n on i.id_nparte = n.id_nparte where p.id_planta is null ");
                cb_nparte.DataSource = nparte.FillCB("select id_nparte, nparte from tb_Nparte");
                cb_nparte.DisplayMember = "nparte";
                cb_nparte.ValueMember = "id_nparte";
                this.cb_nparte.SelectedItem = null;

                cb_nparte.AutoCompleteCustomSource = LoadAutoComplete();
                cb_nparte.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb_nparte.AutoCompleteSource = AutoCompleteSource.CustomSource;


                cb_comprador.DataSource = usuarios.FillCB("select * from tb_Usuario where id_tipousuario = 2");
                cb_comprador.DisplayMember = "usuario";
                cb_comprador.ValueMember = "id_usuario";
                this.cb_comprador.SelectedItem = null;


                cb_presentacion.DataSource = presentacion.FillCB("select * from tb_Presentacion");
                cb_presentacion.DisplayMember = "presentacion";
                cb_presentacion.ValueMember = "id_presentacion";
                this.cb_presentacion.SelectedItem = null;

                cb_caracteristicas.DataSource = caracteristicas.FillCB("select * from tb_Caracteristicas");
                cb_caracteristicas.DisplayMember = "caracteristicas";
                cb_caracteristicas.ValueMember = "id_caracteristicas";
                this.cb_caracteristicas.SelectedItem = null;

                cb_supplier.DataSource = supplier.FillCB("select * from tb_Supplier");
                cb_supplier.DisplayMember = "supplier";
                cb_supplier.ValueMember = "id_supplier";
                this.cb_supplier.SelectedItem = null;


                cb_locacion.DataSource = locacion.FillCB("select * from tb_Locacion");
                cb_locacion.DisplayMember = "locacion";
                cb_locacion.ValueMember = "id_locacion";
                this.cb_locacion.SelectedItem = null;


                cb_area.DataSource = area.FillCB("select * from tb_Area");
                cb_area.DisplayMember = "area";
                cb_area.ValueMember = "id_area";
                this.cb_area.SelectedItem = null;

                //

                #endregion
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!nparte.Exists("select COUNT(*) from tb_Nparte n join tb_Inventario i on n.id_nparte = i.id_nparte where i.id_nparte = " + cb_nparte.SelectedValue + " and i.id_planta = '" + planta.Id_planta + "'"))
                {
                    if (cb_caracteristicas.Text == "Chemical Consumables")
                        inventario.Id_inventario = int.Parse(inventario.ReturnID("insert into tb_Inventario(stock, LD, min, max, id_planta, id_nparte, id_presentacion, id_comprador, id_area, id_locacion, id_caracteristicas, id_supplier, qtypresentacion,obsoleto,palabraAdvetencia,indicaciones,consejos,FechaIngreso) values(" + txt_stock.Text + ",'" + txt_ld.Text + "'," + txt_min.Text + "," + txt_max.Text + "," + planta.Id_planta + "," + cb_nparte.SelectedValue + "," + cb_presentacion.SelectedValue + "," + cb_comprador.SelectedValue + "," + cb_area.SelectedValue + "," + cb_locacion.SelectedValue + "," + cb_caracteristicas.SelectedValue + "," + cb_supplier.SelectedValue + ",'" + txt_presentacion.Text + "'," + 0 + ",'" + cb_PalabraAdvertencia.Text + "','" + txt_IndicacionesPeligro.Text + "','" + txt_consejos.Text + "','" + dateTimePicker1.Value + "'); SELECT SCOPE_IDENTITY(); "));
                    else
                        inventario.Id_inventario = int.Parse(inventario.ReturnID("insert into tb_Inventario(stock, LD, min, max, id_planta, id_nparte, id_presentacion, id_comprador, id_area, id_locacion, id_caracteristicas, id_supplier, qtypresentacion,obsoleto,FechaIngreso) values(" + txt_stock.Text + ",'" + txt_ld.Text + "'," + txt_min.Text + "," + txt_max.Text + "," + planta.Id_planta + "," + cb_nparte.SelectedValue + "," + cb_presentacion.SelectedValue + "," + cb_comprador.SelectedValue + "," + cb_area.SelectedValue + "," + cb_locacion.SelectedValue + "," + cb_caracteristicas.SelectedValue + "," + cb_supplier.SelectedValue + ",'" + txt_presentacion.Text + "'," + 0 + ",'" + dateTimePicker1.Value + "'); SELECT SCOPE_IDENTITY(); "));

                    foreach (var item in areaList)
                    {
                        inventarioArea.Crud("insert into tbUnion_AreaInventario values(" + item + "," + inventario.Id_inventario + ")");
                    }

                    foreach (var item in locacionList)
                    {
                        inventarioLocacion.Crud("insert into tbUnion_LocacionInventario values(" + item + "," + inventario.Id_inventario + ")");
                    }

                    ToEmpty();
                }
                else
                {

                    MessageBox.Show("El numero de parte ya existe en el inventario!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            ToEmpty();
        }

        private void cb_locacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newlocacion = "";
            try
            {
                if (cb_locacion.ValueMember != "")
                    newlocacion = this.cb_locacion.GetItemText(this.cb_locacion.SelectedItem);
                if (newlocacion != "" && cb_locacion.SelectedIndex >= 0 && !(lb_locaciones.Items.Contains(newlocacion)))
                {
                    lb_locaciones.Items.Add(newlocacion);
                    locacionList.Add((int)cb_locacion.SelectedValue);
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ToEmpty()
        {
            txt_ld.Text = "";
            txt_max.Text = "";
            txt_min.Text = "";
            txt_stock.Text = "";
            txt_presentacion.Text = "";
            this.cb_area.SelectedItem = null;
            this.cb_caracteristicas.SelectedItem = null;
            this.cb_comprador.SelectedItem = null;
            this.cb_nparte.SelectedItem = null;
            this.cb_presentacion.SelectedItem = null;
            this.cb_supplier.SelectedItem = null;
            this.cb_locacion.SelectedItem = null;
            lb_araes.Items.Clear();
            lb_locaciones.Items.Clear();
            areaList.Clear();
            locacionList.Clear();

        }

        private void lb_araes_DoubleClick(object sender, EventArgs e)
        {
            lb_araes.Items.Remove(lb_araes.SelectedItem);
        }

        private void lb_locaciones_DoubleClick(object sender, EventArgs e)
        {
            lb_locaciones.Items.Remove(lb_locaciones.SelectedItem);
        }

        private void cb_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newarea = "";
            try
            {
                if (cb_area.ValueMember != "")
                    newarea = this.cb_area.GetItemText(this.cb_area.SelectedItem);
                if (newarea != "" && cb_area.SelectedIndex >= 0 && !(lb_araes.Items.Contains(newarea)))
                {
                    lb_araes.Items.Add(newarea);
                    areaList.Add((int)cb_area.SelectedValue);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_caracteristicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_caracteristicas.Text == "Chemical Consumables")
            {
                lbl_consejos.Visible = true;
                lbl_indicaciones.Visible = true;
                lbl_palabraAdevertencia.Visible = true;
                cb_PalabraAdvertencia.Visible = true;
                txt_IndicacionesPeligro.Visible = true;
                txt_consejos.Visible = true;
            }
            else
            {
                lbl_consejos.Visible = false;
                lbl_indicaciones.Visible = false;
                lbl_palabraAdevertencia.Visible = false;
                cb_PalabraAdvertencia.Visible = false;
                txt_IndicacionesPeligro.Visible = false;
                txt_consejos.Visible = false;
            }
        }

        private void lbl_palabraAdevertencia_Click(object sender, EventArgs e)
        {

        }
    }
}
