using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MROInventory_Project
{
    public partial class Reportes : Form
    {

        public Reportes()
        {
            InitializeComponent();
        }


        private readonly Inventario inventario = new Inventario();
        private readonly Entrada entrada = new Entrada();
        private readonly Salida salida = new Salida();
        private readonly Planta planta = new Planta();
        private readonly Po_s po = new Po_s();


        private void Reportes_Load(object sender, EventArgs e)
        {
            inventario.Obsoletos();
            LoadGridviews();
            EjecutarSP();
        }


        private void LoadGridviews()
        {
            dg_inventario.DataSource = inventario.LlenarDG("select n.nparte, n.mfg as 'Item Masterwork' ,n.descripcion, i.stock, i.min,i.max, i.qtyPurch ,i.LD,c.caracteristicas, p.presentacion, i.qtypresentacion, s.supplier, i.alerta, PU as 'PrecioUnitario', PrecioTotal  from tb_Inventario i join tb_Caracteristicas c on i.id_caracteristicas = c.id_caracteristicas join tb_Nparte n on i.id_nparte = n.id_nparte join tb_Supplier s on i.id_supplier = s.id_supplier join tb_Presentacion p on i.id_presentacion = p.id_presentacion join tb_Usuario u on i.id_comprador = u.id_usuario join tb_Planta pl on i.id_planta = pl.id_planta WHERE i.obsoleto = 0 and pl.id_planta = " + planta.Id_planta).Tables[0];
            dg_entradas.DataSource = entrada.LlenarDG("select n.nparte, n.mfg as 'Item Masterwork', n.descripcion, e.cantidad,e.PrecioUnitario ,e.turno,e.fechaEntrada,u.usuario,e.noempleado from tb_Entrada e join tb_Nparte n on e.id_nparte = n.id_nparte join tb_Usuario u on u.id_usuario = e.id_usuario join tb_Planta pl on e.id_planta = pl.id_planta WHERE pl.id_planta = " + planta.Id_planta + " order by fechaEntrada desc").Tables[0];
            dg_salidas.DataSource = salida.LlenarDG("select n.nparte, n.mfg as 'Item Masterwork', n.descripcion, s.cantidad, s.fechaSalida, s.Usuario, a.area, s.entregausuario from tb_Salida s join tb_Nparte n on s.id_nparte = n.id_nparte join tb_Area a on s.id_area = a.id_area join tb_Planta pl on s.id_planta = pl.id_planta WHERE pl.id_planta = " + planta.Id_planta + " order by fechaSalida desc").Tables[0];
            dg_ajusteSalida.DataSource = salida.LlenarDG("select n.nparte, n.mfg as 'Item Masterwork', n.descripcion, s.cantidad, s.fechaSalida, s.Usuario, s.AjusteInventario from tb_Salida s join tb_Nparte n on s.id_nparte = n.id_nparte WHERE s.AjusteInventario is not null and s.id_planta = " + planta.Id_planta + " order by fechaSalida desc").Tables[0];
            dg_ajusteEntrada.DataSource = entrada.LlenarDG("select n.nparte, n.mfg as 'Item Masterwork', n.descripcion, e.cantidad, e.PrecioUnitario,e.turno,e.fechaEntrada,u.usuario,e.noempleado,e.AjusteInventario from tb_Entrada e join tb_Nparte n on e.id_nparte = n.id_nparte join tb_Usuario u on u.id_usuario = e.id_usuario join tb_Planta pl on e.id_planta = pl.id_planta where e.AjusteInventario is not null and pl.id_planta = " + planta.Id_planta + " order by fechaEntrada desc").Tables[0];
            dg_Po.DataSource = po.LlenarDG("select n.nparte, n.mfg as 'Item Masterwork', n.descripcion, po, uip.fecha as 'PO fecha', uip.cantidad from tb_Po po join tbUnion_InvetarioPo uip on po.id_po = uip.id_po join tb_Nparte n on uip.id_nparte = n.id_nparte where po.checked is null  or po.checked = 'false'").Tables[0];
            dg_POInventario.DataSource = po.LlenarDG("select n.nparte, n.mfg as 'Item Masterwork', n.descripcion, i.stock, i.qtyPurch,i.min,i.max,i.LD,c.caracteristicas, p.presentacion, i.qtypresentacion, s.supplier, u.usuario, i.alerta, PrecioTotal, po, uip.cantidad, uip.fecha as 'PO fecha' from tb_Po po left join tbUnion_InvetarioPo uip on po.id_po = uip.id_po right join tb_Nparte n on uip.id_nparte = n.id_nparte left join tb_Inventario i on i.id_nparte = n.id_nparte join tb_Caracteristicas c on i.id_caracteristicas = c.id_caracteristicas join tb_Supplier s on i.id_supplier = s.id_supplier join tb_Presentacion p on i.id_presentacion = p.id_presentacion join tb_Usuario u on i.id_comprador = u.id_usuario where po.checked is null  or po.checked = 'false'").Tables[0];

            gv_Caducidades.DataSource = entrada.LlenarDG("select n.nparte, n.mfg as 'Item Masterwork' ,n.descripcion, cad.caducidad,cad.cantidad, i.min,i.max, i.qtyPurch ,i.LD,c.caracteristicas, p.presentacion, i.qtypresentacion, s.supplier, i.alerta, PU as 'PrecioUnitario', PrecioTotal  from tb_Inventario i join tb_Caracteristicas c on i.id_caracteristicas = c.id_caracteristicas join tb_Nparte n on i.id_nparte = n.id_nparte join tb_Supplier s on i.id_supplier = s.id_supplier join tb_Presentacion p on i.id_presentacion = p.id_presentacion join tb_Usuario u on i.id_comprador = u.id_usuario join tb_Planta pl on i.id_planta = pl.id_planta join tb_Caducidad cad on cad.id_nparte = n.id_nparte WHERE i.obsoleto = 0 and pl.id_planta = " + planta.Id_planta + "").Tables[0];
            //gv_POROI.DataSource = po.ReturnFromROI("SELECT * FROM OPENQUERY([VOYAGER], 'select Qty_To_Mfg from WO_v_1 where Wo_Nbr = ''" + txt_WO.Text + "''')");
            //gv_Caducidades.DataSource = po.ReturnFromROI("SELECT * FROM OPENQUERY([VOYAGER], 'select * from WO_v_1' ");


            foreach (DataGridViewRow item in gv_Caducidades.Rows)
            {
                //if (item.Index-1 < gv_Caducidades.Rows.Count - 1)
                //{
                //    var a = item.Cells[3].Value;
                //    var b = DateTime.Now.AddDays(3);
                //    var diff = DateTime.Compare((DateTime)item.Cells[3].Value, DateTime.Now.AddDays(3));
                //    if (diff == 1)
                //}
                        item.DefaultCellStyle.BackColor = Color.Red;
            }

            //for (int i = 0; i < gv_Caducidades.Rows.Count - 1; i++)
            //{
            //    var a = (DateTime)gv_Caducidades.Rows[i].Cells[3].Value;
            //    var b = DateTime.Now.AddDays(3);
            //    var diff = DateTime.Compare((DateTime)gv_Caducidades.Rows[i].Cells[3].Value, DateTime.Now.AddDays(3));

            //    if (diff == -1)
            //        gv_Caducidades.Rows[i].Cells[3].Style.BackColor = Color.Red;
            //}
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Busqueda.Text != string.Empty)
                    dg_inventario.DataSource = inventario.LlenarDG("select n.nparte, n.mfg, i.stock, i.min,i.max,i.LD,c.caracteristicas, p.presentacion, s.supplier, u.usuario, i.alerta  from tb_Inventario i join tb_Caracteristicas c on i.id_caracteristicas = c.id_caracteristicas join tb_Nparte n on i.id_nparte = n.id_nparte join tb_Supplier s on i.id_supplier = s.id_supplier join tb_Presentacion p on i.id_presentacion = p.id_presentacion join tb_Usuario u on i.id_comprador = u.id_usuario WHERE i.obsoleto = 0 and n.nparte = '"+ txt_Busqueda.Text.Trim() + "'").Tables[0];
                //else
                //    dg_inventario.DataSource = inventario.LlenarDG("select n.nparte, i.stock, i.min,i.max,i.LD,c.caracteristicas, p.presentacion, s.supplier, u.usuario, i.alerta  from tb_Inventario i join tb_Caracteristicas c on i.id_caracteristicas = c.id_caracteristicas join tb_Nparte n on i.id_nparte = n.id_nparte join tb_Supplier s on i.id_supplier = s.id_supplier join tb_Presentacion p on i.id_presentacion = p.id_presentacion join tb_Usuario u on i.id_comprador = u.id_usuario WHERE i.obsoleto = 0 and alerta = '" + txt_Busqueda.Text.Trim() + "'").Tables[0];

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            if (dg_inventario.Rows.Count != 0)
                SaveToCSV(dg_inventario);

            else
                MessageBox.Show("Realize una busqueda", "ERROR!");
        }

        private void SaveToCSV(DataGridView DGV)
        {
            SaveFileDialog dlGuardar = new SaveFileDialog
            {
                Filter = "Fichero CSV (*.csv)|*.csv",
                FileName = "",
                Title = "Exportar a CSV"
            };
            if (dlGuardar.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csvMemoria = new StringBuilder();

                //para los títulos de las columnas, encabezado
                for (int i = 0; i < DGV.Columns.Count; i++)
                {
                    if (i == DGV.Columns.Count - 1)
                    {
                        csvMemoria.Append(String.Format("\"{0}\"",
                            DGV.Columns[i].HeaderText));
                    }
                    else
                    {
                        csvMemoria.Append(String.Format("\"{0}\",",
                            DGV.Columns[i].HeaderText));
                    }
                }

                csvMemoria.AppendLine();


                for (int m = 0; m < DGV.Rows.Count; m++)
                {
                    for (int n = 0; n < DGV.Columns.Count; n++)
                    {
                        //StringBuilder stringBuilder = csvMemoria.Append(value: string.Format("\"{0}\"", DGV.Rows[m].Cells[n].Value));
                        //si es la última columna no poner el;
                        if (n == DGV.Columns.Count - 1)
                        {
                            _ = csvMemoria.Append(value: string.Format("\"{0}\"", DGV.Rows[m].Cells[n].Value));
                        }
                        else
                        {
                            csvMemoria.Append(value: string.Format("\"{0}\",", DGV.Rows[m].Cells[n].Value));
                        }

                    }
                    csvMemoria.AppendLine();
                }
                System.IO.StreamWriter sw = new System.IO.StreamWriter(dlGuardar.FileName, false, System.Text.Encoding.Default);
                sw.Write(csvMemoria.ToString());
                sw.Close();
            }
        }

        private void btn_ReporteEntrada_Click(object sender, EventArgs e)
        {
            SaveToCSV(dg_entradas);
        }

        private void btn_ReporteSalidas_Click(object sender, EventArgs e)
        {
            SaveToCSV(dg_salidas);
        }

        private void btn_ReporteAjusteEntradas_Click(object sender, EventArgs e)
        {
            SaveToCSV(dg_ajusteEntrada);
        }

        private void btn_ReporteAjusteSalidas_Click(object sender, EventArgs e)
        {
            SaveToCSV(dg_ajusteSalida);
        }

        private void btn_ReportePo_Click(object sender, EventArgs e)
        {
            if (dg_Po.Rows.Count != 0)
                SaveToCSV(dg_Po);
            else
                MessageBox.Show("Realize una busqueda", "ERROR!");
        }

        private void btn_BuscarPo_Click(object sender, EventArgs e)
        {
            dg_Po.DataSource = po.LlenarDG("select n.nparte, n.descripcion, po, cantidad from tb_Po po join tbUnion_InvetarioPo uip on po.id_po = uip.id_po join tb_Nparte n on uip.id_nparte = n.id_nparte where po.po = '" + txt_Po.Text + "' and po.checked is null  or po.checked = 'false'").Tables[0];

        }

        private void btn_ReportePOInv_Click(object sender, EventArgs e)
        {
            if (dg_POInventario.Rows.Count != 0)
                SaveToCSV(dg_POInventario);
            else
                MessageBox.Show("Realize una busqueda", "ERROR!");
        }

        private void EjecutarSP()
        {
            Conexion con = new Conexion();

            try
            {
                con.Abrir();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("sp_GenerarCostos", con.Con1);
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.AddWithValue("@id_orden", id_orden);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Cerrar();
            }
        }
    }
}
