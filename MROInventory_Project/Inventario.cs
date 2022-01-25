using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MROInventory_Project
{
    class Inventario : Conexion
    {
        int id_inventario;
        static int stock;
        int min;
        int max;
        string ld;
        string qtypresentacion;
        bool obsoleto;
        int id_nparte;
        int id_planta;
        int id_caracteristicas;
        int id_presentacion;
        int id_empleado;
        int id_comprador;
        int id_supplier;

        public int Id_inventario { get => id_inventario; set => id_inventario = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }
        public string Ld { get => ld; set => ld = value; }
        public int Id_nparte { get => id_nparte; set => id_nparte = value; }
        public int Id_planta { get => id_planta; set => id_planta = value; }
        public int Id_caracteristicas { get => id_caracteristicas; set => id_caracteristicas = value; }
        public int Id_presentacion { get => id_presentacion; set => id_presentacion = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public int Id_comprador { get => id_comprador; set => id_comprador = value; }
        public int Id_supplier { get => id_supplier; set => id_supplier = value; }
        public bool Obsoleto { get => obsoleto; set => obsoleto = value; }
        public string Qtypresentacion { get => qtypresentacion; set => qtypresentacion = value; }

        public List<Locacion> ListLocacion(string query)
        {

            //List<string> lista = null;
            Abrir();
            DataSet ds = new DataSet(); // Creamos el DataSet que Devolvera el Metodo
            using (SqlDataAdapter CMD = new SqlDataAdapter(query, Con1)) // Creamos un DataAdapter con el Comando y la Conexion
            {
                ds.Dispose();
                CMD.Fill(ds); // Ejecutamos el Comando en la Tabla
            }
            Cerrar();

            var eList = ds.Tables[0].AsEnumerable().Select(dataRow => new Locacion { Locaciones = dataRow.Field<string>("locacion") }).ToList();

            return eList;
        }

        public List<Area> ListArea(string query)
        {

            //List<string> lista = null;
            Abrir();
            DataSet ds = new DataSet(); // Creamos el DataSet que Devolvera el Metodo
            using (SqlDataAdapter CMD = new SqlDataAdapter(query, Con1)) // Creamos un DataAdapter con el Comando y la Conexion
            {
                ds.Dispose();
                CMD.Fill(ds); // Ejecutamos el Comando en la Tabla
            }
            Cerrar();

            var eList = ds.Tables[0].AsEnumerable().Select(dataRow => new Area { Areas = dataRow.Field<string>("area") }).ToList();

            return eList;
        }

        public void Obsoletos()
        {
            try
            {
                Con1.Open();
                SqlCommand cmd = new SqlCommand("sp_obsoletos", Con1)
                {
                    CommandType = CommandType.StoredProcedure
                };


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
