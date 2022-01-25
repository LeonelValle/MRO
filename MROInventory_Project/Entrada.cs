using System;
using System.Data;

namespace MROInventory_Project
{
    class Entrada : Conexion
    {
        int id_entrada;
        string turno;
        int cantidad;
        DateTime fechaEntrada;
        int id_usuario;
        int id_nparte;
        int id_planta;
        string ajusteInventario;
        Decimal precioU;


        public int Id_entrada { get => id_entrada; set => id_entrada = value; }
        public string Turno { get => turno; set => turno = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime FechaEntrada { get => fechaEntrada; set => fechaEntrada = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_nparte { get => id_nparte; set => id_nparte = value; }
        public int Id_planta { get => id_planta; set => id_planta = value; }
        public string AjusteInventario { get => ajusteInventario; set => ajusteInventario = value; }
        public decimal PrecioU { get => precioU; set => precioU = value; }

        public void InventarioEntrada(int id_nparte, int id_usuario, int cantidad, DateTime fecha, string turno, int noempleado, int id_planta, int id_inventario)
        {
            //Conexion con = new Conexion();

            try
            {
                Con1.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("sp_EntradasInventarioC", Con1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_nparte", id_nparte);
                cmd.Parameters.AddWithValue("@Id_usuario", id_usuario);
                cmd.Parameters.AddWithValue("@Id_planta", id_planta);
                cmd.Parameters.AddWithValue("@Id_inventario", id_inventario);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@turno", turno);
                cmd.Parameters.AddWithValue("@noempleado", noempleado);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                Con1.Close();
            }
        }

        public void InventarioEntrada(int id_nparte, int id_usuario, int cantidad, DateTime fecha, string turno, int noempleado, int id_planta, int id_inventario, string ajuste)
        {
            //Conexion con = new Conexion();

            try
            {
                Con1.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("sp_EntradasInventarioAjuste", Con1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_nparte", id_nparte);
                cmd.Parameters.AddWithValue("@Id_usuario", id_usuario);
                cmd.Parameters.AddWithValue("@Id_planta", id_planta);
                cmd.Parameters.AddWithValue("@Id_inventario", id_inventario);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@turno", turno);
                cmd.Parameters.AddWithValue("@noempleado", noempleado);
                cmd.Parameters.AddWithValue("@ajuste", ajuste);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                Con1.Close();
            }
        }


        /// <summary>
        /// Metodo de Entrada de MRO con Precio Unitario
        /// </summary>
        /// <param name="id_nparte"></param>
        /// <param name="id_usuario"></param>
        /// <param name="cantidad"></param>
        /// <param name="fecha"></param>
        /// <param name="turno"></param>
        /// <param name="noempleado"></param>
        /// <param name="id_planta"></param>
        /// <param name="id_inventario"></param>
        /// <param name="precioUnitario"></param>
        public void InventarioEntradaC(int id_nparte, int id_usuario, int cantidad, DateTime fecha, string turno, int noempleado, int id_planta, int id_inventario)
        {
            //Conexion con = new Conexion();

            try
            {
                Con1.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("sp_EntradasInventarioC", Con1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_nparte", id_nparte);
                cmd.Parameters.AddWithValue("@Id_usuario", id_usuario);
                cmd.Parameters.AddWithValue("@Id_planta", id_planta);
                cmd.Parameters.AddWithValue("@Id_inventario", id_inventario);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@turno", turno);
                cmd.Parameters.AddWithValue("@noempleado", noempleado);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                Con1.Close();
            }
        }
        /// <summary>
        /// Metodo de Entrada de MRO con Precio Unitario
        /// </summary>
        /// <param name="id_nparte"></param>
        /// <param name="id_usuario"></param>
        /// <param name="cantidad"></param>
        /// <param name="fecha"></param>
        /// <param name="turno"></param>
        /// <param name="noempleado"></param>
        /// <param name="id_planta"></param>
        /// <param name="id_inventario"></param>
        /// <param name="precioUnitario"></param>
        public void InventarioEntradaCaducidad(int id_nparte, int id_usuario, int cantidad, DateTime fecha, string turno, int noempleado, int id_planta, int id_inventario, DateTime caducidad, string pn)
        {
            //Conexion con = new Conexion();

            try
            {
                Con1.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("sp_EntradasInventarioCaducidad", Con1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_nparte", id_nparte);
                cmd.Parameters.AddWithValue("@Id_usuario", id_usuario);
                cmd.Parameters.AddWithValue("@Id_planta", id_planta);
                cmd.Parameters.AddWithValue("@Id_inventario", id_inventario);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@turno", turno);
                cmd.Parameters.AddWithValue("@noempleado", noempleado);
                cmd.Parameters.AddWithValue("@fechaCaducidad", caducidad);
                cmd.Parameters.AddWithValue("@label", pn + "-" + caducidad.ToString("MMddyy"));

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                Con1.Close();
            }
        }

        public void InventarioEntradaC(int id_nparte, int id_usuario, int cantidad, DateTime fecha, string turno, int noempleado, int id_planta, int id_inventario, string ajuste)
        {
            //Conexion con = new Conexion();

            try
            {
                Con1.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("sp_EntradasInventarioAjusteC", Con1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_nparte", id_nparte);
                cmd.Parameters.AddWithValue("@Id_usuario", id_usuario);
                cmd.Parameters.AddWithValue("@Id_planta", id_planta);
                cmd.Parameters.AddWithValue("@Id_inventario", id_inventario);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@turno", turno);
                cmd.Parameters.AddWithValue("@noempleado", noempleado);
                cmd.Parameters.AddWithValue("@ajuste", ajuste);
                //cmd.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                Con1.Close();
            }
        }



        //public void CreateLabel()
        //{
        //    string label;
        //    Nparte pn = new Nparte();
        //    label = pn.Npartes +"-"+ DateTime.Now.ToString("MMddYY");
        //}
    }
}
