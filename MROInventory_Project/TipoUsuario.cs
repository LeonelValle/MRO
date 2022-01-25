namespace MROInventory_Project
{
    class TipoUsuario : Conexion
    {
        static int id_tipousuario;
        string tipousuario;

        public int Id_tipousuario { get => id_tipousuario; set => id_tipousuario = value; }
        public string Tipousuario { get => tipousuario; set => tipousuario = value; }



    }
}
