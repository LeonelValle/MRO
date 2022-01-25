namespace MROInventory_Project
{
    class Presentacion : Conexion
    {
        int id_presentacion;
        string presentacion;

        public int Id_presentacion { get => id_presentacion; set => id_presentacion = value; }
        public string Presentaciones { get => presentacion; set => presentacion = value; }
    }
}
