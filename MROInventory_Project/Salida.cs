using System;
using System.Data;

namespace MROInventory_Project
{
    class Salida : Conexion
    {
        int id_salida;
        DateTime fechaSalida;
        int cantidad;
        int id_nparte;
        int id_planta;
        int id_usuario;
        int id_area;
        int id_usuarioEntrega;
        string ajusteInventario;
        DateTime fechaCaducidad;

        public int Id_salida { get => id_salida; set => id_salida = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Id_nparte { get => id_nparte; set => id_nparte = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_area { get => id_area; set => id_area = value; }
        public int Id_usuarioEntrega { get => id_usuarioEntrega; set => id_usuarioEntrega = value; }
        public int Id_planta { get => id_planta; set => id_planta = value; }
        public string AjusteInventario { get => ajusteInventario; set => ajusteInventario = value; }
        public DateTime FechaCaducidad { get => fechaCaducidad; set => fechaCaducidad = value; }

        public void InventarioSalida(int id_nparte, int id_usuario, int cantidad, DateTime fecha, string UsuarioEntrega, int id_area, int id_planta, int id_inventario)
        {
            //Conexion con = new Conexion();


            try
            {
                Con1.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("sp_SalidaInventario", Con1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_nparte", id_nparte);
                cmd.Parameters.AddWithValue("@Id_usuario", id_usuario);
                cmd.Parameters.AddWithValue("@Id_planta", id_planta);
                cmd.Parameters.AddWithValue("@Id_inventario", id_inventario);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@UsuarioEntrega", UsuarioEntrega);
                cmd.Parameters.AddWithValue("@id_area", id_area);

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
        public void InventarioSalidaCaducidad(int id_nparte, int id_usuario, int cantidad, DateTime fecha, string UsuarioEntrega, int id_area, int id_planta, int id_inventario, string label)
        {
            //Conexion con = new Conexion();


            try
            {
                Con1.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("sp_SalidaInventarioCaducidad", Con1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_nparte", id_nparte);
                cmd.Parameters.AddWithValue("@Id_usuario", id_usuario);
                cmd.Parameters.AddWithValue("@Id_planta", id_planta);
                cmd.Parameters.AddWithValue("@Id_inventario", id_inventario);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@UsuarioEntrega", UsuarioEntrega);
                cmd.Parameters.AddWithValue("@id_area", id_area);
                cmd.Parameters.AddWithValue("@label", label);


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

        public void InventarioSalida(int id_nparte, int id_usuario, int cantidad, DateTime fecha, int id_planta, int id_inventario, string ajuste)
        {
            //Conexion con = new Conexion();

            try
            {
                Con1.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("sp_SalidaInventarioAjuste", Con1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_nparte", id_nparte);
                cmd.Parameters.AddWithValue("@Id_usuario", id_usuario);
                cmd.Parameters.AddWithValue("@Id_planta", id_planta);
                cmd.Parameters.AddWithValue("@Id_inventario", id_inventario);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@fecha", fecha);
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
    }
}
