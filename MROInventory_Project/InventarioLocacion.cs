namespace MROInventory_Project
{
    class InventarioLocacion : Conexion
    {
        int id_inventario;
        int id_locacion;

        public int Id_inventario { get => id_inventario; set => id_inventario = value; }
        public int Id_locacion { get => id_locacion; set => id_locacion = value; }
    }
}
