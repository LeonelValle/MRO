using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace MROInventory_Project
{
    class Nparte : Conexion
    {
        int id_nparte;
        string nparte;
        string descripcion;
        string code;
        byte[] imagen;

        public int Id_nparte { get => id_nparte; set => id_nparte = value; }
        public string Npartes { get => nparte; set => nparte = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Code { get => code; set => code = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }

        Conexion con = new Conexion();

        public void UpdateImage(string path, int id)
        {
            try
            {

                //Se inicailiza un flujo de archivo con la imagen seleccionada desde el disco.;
                string pathreal = Path.GetFullPath(path);

                FileStream stream = new FileStream(pathreal, FileMode.Open, FileAccess.Read);
                //Se inicializa un arreglo de Bytes del tamaño de la imagen
                byte[] binData = new byte[stream.Length];
                //Se almacena en el arreglo de bytes la informacion que se obtiene del flujo de archivos(foto)
                //Lee el bloque de bytes del flujo y escribe los datos en un búfer dado.
                stream.Read(binData, 0, Convert.ToInt32(stream.Length));


                SqlCommand com = new SqlCommand("update tb_Nparte set foto = @Pic where id_nparte = " + id, con.Con1);
                com.Parameters.AddWithValue("@Pic", binData);
                con.Abrir();

                //Ejecuta una instrucción SQL en la conexión y devuelve el número de filas afectadas.
                com.ExecuteNonQuery();
                con.Cerrar();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        public Bitmap ReturnPictures(int id)
        {

            SqlDataAdapter da = new SqlDataAdapter(new SqlCommand("select * from tb_Nparte where id_nparte=" + id, con.Con1));

            DataSet ds = new DataSet();

            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                try
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["foto"]);

                    return new Bitmap(ms);
                }
                catch (System.InvalidCastException)
                {
                    return new Bitmap(MROInventory_Project.Properties.Resources.x_30465_960_720);
                }

            }
            else
            {
                return new Bitmap(MROInventory_Project.Properties.Resources.x_30465_960_720);
            }
        }
    }
}
