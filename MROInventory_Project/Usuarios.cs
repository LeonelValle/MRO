using System.Data.SqlClient;

namespace MROInventory_Project
{
    class Usuarios : Conexion
    {
        static int id_usuario;
        string usuario;
        int tipousuario;
        string emial;
        string password;
        int nempleado;
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public int Tipousuario { get => tipousuario; set => tipousuario = value; }
        public string Emial { get => emial; set => emial = value; }
        public string Password { get => password; set => password = value; }
        public int Nempleado { get => nempleado; set => nempleado = value; }

        public int Login(string user, string password)
        {
            int id = -1;
            //SqlCommand cmd = new SqlCommand("select * from tb_Usuario where username='" + user + "' and password='" + password + "'", Con1);
            using (SqlCommand cmd = new SqlCommand("select id_usuario from tb_Usuario where username='" + user + "' and password='" + password + "'", Con1))
            {
                Con1.Open();
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //da.Fill(ds);

                if (cmd.ExecuteScalar() != null)
                    id = int.Parse(cmd.ExecuteScalar().ToString());
            }

            Con1.Close();

            return id;
        }
    }
}
