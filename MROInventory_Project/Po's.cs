using System;
using System.Data.SqlClient;

namespace MROInventory_Project
{
    class Po_s : Conexion
    {
        int id_po;
        string po;
        int cantidad;
        bool check;

        public int Id_po { get => id_po; set => id_po = value; }
        public string Po { get => po; set => po = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public bool Check { get => check; set => check = value; }

        private SqlConnection Conex; // Obj Conexion

        public Po_s() =>
        Conex = new SqlConnection(@"Data Source=192.168.4.5\SQLEXPRESS;Initial Catalog=master;User ID=sa;Password=Mexmei15!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private SqlConnection Con { get => Conex; set => Conex = value; }


        /// <summary>
        /// Metodo para abrir la conexion con la base de datos
        /// </summary>
        public new void Abrir() // Metodo para Abrir la Conexion
        {
            Conex.Open();
        }

        /// <summary>
        /// Metodo para cerrar la conexion con la base de datos
        /// </summary>
        public new void Cerrar() // Metodo para Cerrar la Conexion
        {
            Conex.Close();
        }

        public string ReturnFromROI(string comando)
        {
            string valor;
            try
            {
                using (SqlCommand CMD = new SqlCommand(comando, Conex))
                {
                    this.Abrir();
                    //CMD.ExecuteNonQuery();
                    valor = CMD.ExecuteScalar().ToString();
                }
                if (valor == "")
                    valor = "0";
            }
            catch (Exception)
            {
                valor = "0";
            }
            this.Cerrar();
            return valor;
        }
    }
}
