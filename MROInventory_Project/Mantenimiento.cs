using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MROInventory_Project
{
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
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

        private DataTable dtarea = new DataTable();
        private DataTable dtlocacion = new DataTable();

        private readonly List<int> areaList = new List<int>();
        private readonly List<int> locacionList = new List<int>();


        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                cb_nparte.DataSource = FillCB("select n.id_nparte, n.nparte, mfg from tb_Inventario i join tb_Nparte n on i.id_nparte = n.id_nparte where i.obsoleto != 1 and i.id_planta = " + planta.Id_planta);
                cb_nparte.DisplayMember = "mfg";
                cb_nparte.ValueMember = "id_nparte";
                this.cb_nparte.SelectedItem = null;

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

                cb_nparteImagen.DataSource = nparte.FillCB("select id_nparte, nparte,mfg  from tb_Nparte");
                cb_nparteImagen.DisplayMember = "mfg";
                cb_nparteImagen.ValueMember = "id_nparte";
                this.cb_nparteImagen.SelectedItem = null;

                cb_nparte.AutoCompleteCustomSource = LoadAutoComplete();
                cb_nparte.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb_nparte.AutoCompleteSource = AutoCompleteSource.CustomSource;

                //cb_nparteImagen.AutoCompleteCustomSource = LoadAutoComplete();
                //cb_nparteImagen.AutoCompleteMode = AutoCompleteMode.Suggest;
                //cb_nparteImagen.AutoCompleteSource = AutoCompleteSource.CustomSource;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public AutoCompleteStringCollection LoadAutoComplete()
        {
            DataTable dt = nparte.FillCB("select n.id_nparte, n.nparte, mfg from tb_Inventario i join tb_Nparte n on i.id_nparte = n.id_nparte where i.id_planta = " + planta.Id_planta);

            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row["mfg"]));
            }

            return stringCol;
        }
        public AutoCompleteStringCollection LoadAutoCompletenparte()
        {
            DataTable dt = nparte.FillCB("select n.id_nparte, n.nparte, mfg from tb_Inventario i join tb_Nparte n on i.id_nparte = n.id_nparte where i.id_planta = " + planta.Id_planta);

            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row["nparte"]));
            }

            return stringCol;
        }

        public DataTable FillCB(string comando)
        {
            DataTable dt = new DataTable();
            //Insert the Default Item to DataTable.            
            using (SqlCommand cmd = new SqlCommand(comando, nparte.Con1))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Please select";
            dt.Rows.InsertAt(row, 0);
            return dt;
        }

        private void btn_aceptarImagen_Click(object sender, EventArgs e)
        {
            //if (cb_nparteImagen.SelectedValue != null)
            //{
            if (openFileDialog1.FileName != string.Empty)
                nparte.UpdateImage(openFileDialog1.FileName.ToString(), (int)cb_nparteImagen.SelectedValue);
            else
                MessageBox.Show("Seleccione una imagen!", "ERROR!");
            nparte.Crud("update tb_Nparte set nparte = '" + txt_PNFOTO.Text + "', descripcion = '" + txt_descripcion.Text + "', mfg = '" + txt_ItemMasterwork.Text + "' where id_nparte = '" + cb_nparteImagen.SelectedValue + "'");
            MessageBox.Show("Done!");
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione una imagen!", "ERROR!");

            //}

            Mantenimiento_Load(sender, e);
        }

        private void btn_imagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_path.Text = Path.GetFileName(openFileDialog1.FileName);
                //pictureBox2.Image = nparte.ReturnPictures((int)cb_nparteImagen.SelectedValue);
                pictureBox2.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void cb_nparteImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_code.Text = inventario.ReturnValue("select code from tb_Nparte where id_nparte = " + cb_nparteImagen.SelectedValue);
            txt_descripcion.Text = inventario.ReturnValue("select descripcion from tb_Nparte where id_nparte = " + cb_nparteImagen.SelectedValue);
            txt_PNFOTO.Text = nparte.ReturnValue("select nparte from tb_Nparte where id_nparte = " + cb_nparteImagen.SelectedValue);
            txt_ItemMasterwork.Text = nparte.ReturnValue("select mfg from tb_Nparte where id_nparte = " + cb_nparteImagen.SelectedValue);


        }

        private void btn_altaNoparte_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nparte.Text) || string.IsNullOrEmpty(txt_descripcionalta.Text) || string.IsNullOrEmpty(txt_codeAlta.Text))
                MessageBox.Show("No deje campos vacios");
            else
            {
                if (usuarios.Exists("select COUNT(*) from tb_Nparte where nparte = '" + txt_nparte.Text.Trim() + "' and mfg ='" + txt_MFG.Text.Trim() + "'"))
                    MessageBox.Show("Ya existe ese NoParte!");
                else
                {
                    try
                    {
                        nparte.Crud("insert into tb_Nparte(nparte, mfg, descripcion, code) values('" + txt_nparte.Text.Trim() + "','" + txt_MFG.Text.Trim() + "','" + txt_descripcionalta.Text.Trim().Replace("\"", "") + "','" + txt_codeAlta.Text.Trim() + "')");
                        MessageBox.Show("Guardado con exito!");
                        txt_nparte.Text = "";
                        txt_descripcionalta.Text = "";
                        txt_codeAlta.Text = "";
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btn_areaAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_area.Text))
                MessageBox.Show("No deje campos vacios");
            else
            {
                if (usuarios.Exists("select COUNT(*) from tb_Area where area = '" + txt_area.Text + "'"))
                    MessageBox.Show("Ya existe esa area!");
                else
                {
                    try
                    {
                        area.Crud("insert into tb_Area values('" + txt_area.Text + "')");
                        MessageBox.Show("Guardado con exito!");
                        txt_area.Text = "";
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btn_locacionAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_locacion.Text))
                MessageBox.Show("No deje campos vacios");
            else
            {
                if (usuarios.Exists("select COUNT(*) from tb_Locacion where locacion = '" + txt_locacion.Text + "'"))
                    MessageBox.Show("Ya existe esa locacion!");
                else
                {
                    try
                    {
                        locacion.Crud("insert into tb_Locacion values('" + txt_locacion.Text + "')");
                        MessageBox.Show("Guardado con exito!");
                        txt_locacion.Text = "";
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btn_caracteristicasAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_caracteristicas.Text))
                MessageBox.Show("No deje campos vacios");
            else
            {
                if (usuarios.Exists("select COUNT(*) from tb_Caracteristicas where caracteristicas = '" + txt_caracteristicas.Text + "'"))
                    MessageBox.Show("Ya existe esa caracteristica!");
                else
                {
                    try
                    {
                        caracteristicas.Crud("insert into tb_Caracteristicas values('" + txt_caracteristicas.Text + "')");
                        MessageBox.Show("Guardado con exito!");
                        txt_caracteristicas.Text = "";
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btn_presentacionAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_presentacion.Text))
                MessageBox.Show("No deje campos vacios");
            else
            {
                if (usuarios.Exists("select COUNT(*) from tb_Presentacion where presentacion = '" + txt_presentacion.Text + "'"))
                    MessageBox.Show("Ya existe esa presentacion!");
                else
                {
                    try
                    {
                        presentacion.Crud("insert into tb_Presentacion values('" + txt_presentacion.Text + "')");
                        MessageBox.Show("Guardado con exito!");
                        txt_presentacion.Text = "";
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btn_supplierAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_supplier.Text))
                MessageBox.Show("No deje campos vacios");
            else
            {
                if (usuarios.Exists("select COUNT(*) from tb_Supplier where supplier = '" + txt_supplier.Text + "'"))
                    MessageBox.Show("Ya existe ese supplier!");
                else
                {
                    try
                    {
                        supplier.Crud("insert into tb_Supplier values('" + txt_supplier.Text + "')");
                        MessageBox.Show("Guardado con exito!");
                        txt_supplier.Text = "";
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btn_usuarioAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_correo.Text) || string.IsNullOrEmpty(txt_password.Text) || string.IsNullOrEmpty(txt_username.Text))
                MessageBox.Show("No deje campos vacios");
            else
            {
                if (usuarios.Exists("select COUNT(*) from tb_Usuario where username = '" + txt_username.Text + "'"))
                    MessageBox.Show("Ya existe ese username!");
                else
                {
                    try
                    {
                        usuarios.Crud("insert into tb_Usuario(usuario, email, password, username) values('" + txt_nombre.Text + "','" + txt_correo.Text + "','" + txt_password.Text + "','" + txt_username.Text + "')");
                        MessageBox.Show("Guardado con exito!");
                        txt_username.Text = "";
                        txt_password.Text = "";
                        txt_correo.Text = "";
                        txt_nombre.Text = "";
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btn_cancelarNoparte_Click(object sender, EventArgs e)
        {
            txt_nparte.Text = "";
            txt_descripcionalta.Text = "";
            txt_codeAlta.Text = "";
        }

        private void btn_cancelarArea_Click(object sender, EventArgs e) => txt_area.Text = "";

        private void btn_cancelarLocacion_Click(object sender, EventArgs e) => txt_locacion.Text = "";

        private void btn_cancelarCaracteristicas_Click(object sender, EventArgs e) => txt_caracteristicas.Text = "";

        private void btn_cancelarPresentacion_Click(object sender, EventArgs e) => txt_presentacion.Text = "";

        private void btn_cancelarSupplier_Click(object sender, EventArgs e) => txt_supplier.Text = "";

        private void btn_cancelarUsuario_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_password.Text = "";
            txt_username.Text = "";
            txt_correo.Text = "";
        }

        private void cb_nparte_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cb_nparte.SelectedValue == null)
            if (cb_nparte.SelectedIndex > 0)
            {
                //inventario.Id_inventario = int.Parse(inventario.ReturnID("select id_inventario from tb_Inventario where id_nparte = " + cb_nparte.SelectedValue + " and id_planta = " + planta.Id_planta));
                GetTable();

            }

        }

        private void GetTable()
        {
            inventario.Id_inventario = int.Parse(inventario.ReturnID("select id_inventario from tb_Inventario where id_nparte = " + cb_nparte.SelectedValue + " and id_planta = " + planta.Id_planta));

            //DataTable dt = new DataTable();
            //dt = inventario.FillCB("select n.descripcion, i.stock, i.min,i.max,i.LD,c.caracteristicas, p.presentacion, s.supplier, i.alerta,  i.qtypresentacion  from tb_Inventario i join tb_Caracteristicas c on i.id_caracteristicas = c.id_caracteristicas join tb_Nparte n on i.id_nparte = n.id_nparte join tb_Supplier s on i.id_supplier = s.id_supplier join tb_Presentacion p on i.id_presentacion = p.id_presentacion where i.id_inventario = " + inventario.Id_inventario);
            DataTable dt = inventario.FillCB("select n.id_nparte, nparte,n.descripcion, n.code ,i.stock, i.min,i.max,i.LD,i.PU,c.id_caracteristicas, p.id_presentacion, s.id_supplier, i.alerta, i.qtypresentacion, u.id_usuario, i.obsoleto, i.consejos, i.indicaciones, i.palabraAdvetencia from tb_Inventario i join tb_Caracteristicas c on i.id_caracteristicas = c.id_caracteristicas join tb_Nparte n on i.id_nparte = n.id_nparte join tb_Supplier s on i.id_supplier = s.id_supplier join tb_Presentacion p on i.id_presentacion = p.id_presentacion join tb_Usuario u on i.id_comprador = u.id_usuario where i.id_inventario = " + inventario.Id_inventario);

            inventario.Id_nparte = int.Parse(dt.Rows[0]["id_nparte"].ToString());

            txt_descripcion.Text = dt.Rows[0]["descripcion"].ToString();
            txt_min.Text = dt.Rows[0]["min"].ToString();
            txt_max.Text = dt.Rows[0]["max"].ToString();
            txt_ld.Text = dt.Rows[0]["LD"].ToString();
            cb_caracteristicas.SelectedValue = dt.Rows[0]["id_caracteristicas"].ToString();
            cb_supplier.SelectedValue = dt.Rows[0]["id_supplier"].ToString();
            cb_presentacion.SelectedValue = dt.Rows[0]["id_presentacion"].ToString();
            cb_comprador.SelectedValue = dt.Rows[0]["id_usuario"].ToString();
            txt_qtypresentacion.Text = dt.Rows[0]["qtypresentacion"].ToString();
            txt_consejos.Text = dt.Rows[0]["consejos"].ToString();
            txt_IndicacionesPeligro.Text = dt.Rows[0]["indicaciones"].ToString();
            cb_PalabraAdvertencia.Text = dt.Rows[0]["palabraAdvetencia"].ToString();
            txt_CODEI.Text = dt.Rows[0]["code"].ToString();
            txt_DescI.Text = dt.Rows[0]["descripcion"].ToString();
            txt_PUnitario.Text = dt.Rows[0]["PU"].ToString();
            txt_PN.Text = dt.Rows[0]["nparte"].ToString();

            LoadLB();

            //lb_araes.DataSource = inventario.FillCB("select a.id_area, a.area from tb_Inventario i join tbUnion_AreaInventario ai on i.id_inventario = ai.id_inventario join tb_Area a on ai.id_area = a.id_area where i.id_inventario = " + inventario.Id_inventario); ;
            lb_araes.ValueMember = "id_area";
            lb_araes.DisplayMember = "area";


            //lb_locaciones.DataSource = inventario.FillCB("select l.id_locacion, l.locacion from tb_Inventario i join tbUnion_LocacionInventario li on i.id_inventario = li.id_inventario join tb_Locacion l on li.id_locacion = l.id_locacion where i.id_inventario = " + inventario.Id_inventario); ;
            lb_locaciones.ValueMember = "id_locacion";
            lb_locaciones.DisplayMember = "locacion";

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //if (cb_caracteristicas.Text == "Chemical Consumables")
            //    inventario.Crud("update tb_Inventario set min = " + txt_min.Text + " , max = " + txt_max.Text + " , LD = '" + txt_ld.Text + "', qtypresentacion = '" + txt_qtypresentacion.Text +
            //                    "', id_caracteristicas=" + cb_caracteristicas.SelectedValue + " , id_supplier= " + cb_supplier.SelectedValue + " , id_presentacion = " + cb_presentacion.SelectedValue +
            //                    " , indicaciones = '" + txt_IndicacionesPeligro.Text + "' , consejos = '" + txt_consejos.Text + "' , palabraAdvetencia = '" + cb_PalabraAdvertencia.Text + "' where id_inventario = " + inventario.Id_inventario + " and id_planta = " + planta.Id_planta);
            //else
            //    inventario.Crud("update tb_Inventario set min = " + txt_min.Text + " , max = " + txt_max.Text + " , LD = '" + txt_ld.Text + "', qtypresentacion = '" + txt_qtypresentacion.Text +
            //    "', id_caracteristicas=" + cb_caracteristicas.SelectedValue + " , id_supplier= " + cb_supplier.SelectedValue + " , id_presentacion = " + cb_presentacion.SelectedValue + " where id_inventario = " + inventario.Id_inventario + " and id_planta = " + planta.Id_planta);

            inventario.Crud("update tb_Inventario set min = '" + txt_min.Text + "' , max = '" + txt_max.Text + "' , LD = '" + txt_ld.Text + "', qtypresentacion = '" + txt_qtypresentacion.Text +
                                "', id_caracteristicas='" + cb_caracteristicas.SelectedValue + "' , id_supplier= '" + cb_supplier.SelectedValue + "' , id_presentacion = '" + cb_presentacion.SelectedValue + "' , id_comprador = '" + cb_comprador.SelectedValue +
                                "' , indicaciones = '" + txt_IndicacionesPeligro.Text + "' , consejos = '" + txt_consejos.Text + "' , palabraAdvetencia = '" + cb_PalabraAdvertencia.Text + "' , PU = '" + txt_PUnitario.Text + "' where id_inventario = '" + inventario.Id_inventario + "' and id_planta = " + planta.Id_planta);
            //nparte.Crud("update tb_Nparte");
            MessageBox.Show("Cambios Realizados!");
        }

        private void lb_araes_DoubleClick(object sender, EventArgs e)
        {
            int count = 0;
            //string cb = null;
            string cb = lb_araes.SelectedValue.ToString();
            foreach (DataRow item in dtarea.Rows)
            {
                if (item["id_area"].ToString() == cb)
                {
                    item.Delete();
                }
                //else if (item.Table.Rows.Count <= 1)
                //    MessageBox.Show("No se permite borrar todas las ");
                else
                {
                    if (count == 0)
                        inventario.Crud("delete tbUnion_AreaInventario where id_inventario = " + inventario.Id_inventario);
                    inventario.Crud("insert into tbUnion_AreaInventario values(" + item[0] + "," + inventario.Id_inventario + ")");
                    count++;

                }

            }
            LoadLB();
        }

        private void lb_locaciones_DoubleClick(object sender, EventArgs e)
        {
            string cb = lb_locaciones.SelectedValue.ToString();
            int count = 0;
            foreach (DataRow item in dtlocacion.Rows)
            {
                if (item["id_locacion"].ToString() == cb)
                {
                    item.Delete();

                }
                else
                {
                    if (count == 0)
                        inventario.Crud("delete tbUnion_LocacionInventario where id_inventario = " + inventario.Id_inventario);
                    inventario.Crud("insert into tbUnion_LocacionInventario values(" + item[0] + "," + inventario.Id_inventario + ")");
                    count++;

                }

            }
            LoadLB();
        }

        private void LoadLB()
        {
            dtarea = inventario.FillCB("select a.id_area, a.area from tb_Inventario i join tbUnion_AreaInventario ai on i.id_inventario = ai.id_inventario join tb_Area a on ai.id_area = a.id_area where i.id_inventario = " + inventario.Id_inventario);
            lb_araes.DataSource = dtarea;

            dtlocacion = inventario.FillCB("select l.id_locacion, l.locacion from tb_Inventario i join tbUnion_LocacionInventario li on i.id_inventario = li.id_inventario join tb_Locacion l on li.id_locacion = l.id_locacion where i.id_inventario = " + inventario.Id_inventario);
            lb_locaciones.DataSource = dtlocacion;

        }

        private void cb_area_SelectedIndexChanged(object sender, EventArgs e)
        {

            bool duplicate = false;
            if (dtarea.Rows.Count == 0 && cb_nparte.SelectedIndex > 0)
                duplicate = true;
            else
                foreach (DataRow item in dtarea.Rows)
                {
                    int a = int.Parse(item["id_area"].ToString());
                    if (item["id_area"].ToString() == cb_area.SelectedValue.ToString())
                    {
                        duplicate = false;
                        break;
                    }
                    else
                    {
                        duplicate = true;
                    }

                }

            //add combobox to listbox
            //string newarea = "";
            //if (cb_area.ValueMember != "")
            //    newarea = this.cb_area.GetItemText(this.cb_area.SelectedItem);
            //if (newarea != "" && cb_area.SelectedIndex >= 0 && !lb_araes.Items.Contains(cb_area.SelectedValue))
            //{
            //    inventario.Crud("insert into tbUnion_AreaInventario values(" + cb_area.SelectedValue + "," + inventario.Id_inventario + ")");

            //}


            if (duplicate == true)
                inventario.Crud("insert into tbUnion_AreaInventario values(" + cb_area.SelectedValue + "," + inventario.Id_inventario + ")");

            LoadLB();

        }

        private void cb_locacion_SelectedIndexChanged(object sender, EventArgs e)
        {

            bool duplicate = false;
            if (dtlocacion.Rows.Count == 0 && cb_locacion.SelectedIndex > 0)
                duplicate = true;
            else
                foreach (DataRow item in dtlocacion.Rows)
                {
                    int a = int.Parse(item["id_locacion"].ToString());
                    if (item["id_locacion"].ToString() == cb_locacion.SelectedValue.ToString())
                    {
                        duplicate = false;
                        break;
                    }
                    else
                    {
                        duplicate = true;
                    }

                }


            if (duplicate == true)
                inventario.Crud("insert into tbUnion_LocacionInventario values(" + cb_locacion.SelectedValue + "," + inventario.Id_inventario + ")");

            LoadLB();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cb_area.SelectedItem = null;
            cb_locacion.SelectedItem = null;
            cb_nparte.SelectedItem = null;
            cb_supplier.SelectedItem = null;
            cb_presentacion.SelectedItem = null;
            cb_comprador.SelectedItem = null;
            cb_caracteristicas.SelectedItem = null;
            txt_ld.Text = "";
            txt_qtypresentacion.Text = "";
            txt_min.Text = "";
            txt_max.Text = "";
            lb_araes.Items.Clear();
            lb_locaciones.Items.Clear();
            areaList.Clear();
            locacionList.Clear();
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

        private void cb_Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Filtro.Text == "Part N#")
            {
                lbl_CargarFoto.Text = "Part N#";
                cb_nparteImagen.DataSource = nparte.FillCB("select n.id_nparte, n.nparte, n.mfg from tb_Inventario i join tb_Nparte n on i.id_nparte = n.id_nparte where i.obsoleto != 1 and i.id_planta = " + planta.Id_planta);
                cb_nparteImagen.DisplayMember = "nparte";
                cb_nparteImagen.ValueMember = "id_nparte";
                this.cb_nparteImagen.SelectedItem = null;

                cb_nparteImagen.AutoCompleteCustomSource = LoadAutoCompletenparte();
                cb_nparteImagen.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb_nparteImagen.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            else if (cb_Filtro.Text == "Item Masterwork")
            {
                lbl_CargarFoto.Text = "Item Masterwork";

                cb_nparteImagen.DataSource = nparte.FillCB("select n.id_nparte, n.nparte, n.mfg from tb_Inventario i join tb_Nparte n on i.id_nparte = n.id_nparte where i.obsoleto != 1 and i.id_planta = " + planta.Id_planta);
                cb_nparteImagen.DisplayMember = "mfg";
                cb_nparteImagen.ValueMember = "id_nparte";
                this.cb_nparteImagen.SelectedItem = null;

                cb_nparteImagen.AutoCompleteCustomSource = LoadAutoComplete();
                cb_nparteImagen.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb_nparteImagen.AutoCompleteSource = AutoCompleteSource.CustomSource;

            }
        }
    }
}
