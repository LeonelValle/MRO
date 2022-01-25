namespace MROInventory_Project
{
    class InventarioArea : Conexion
    {
        int id_inventario;
        int id_area;

        public int Id_inventario { get => id_inventario; set => id_inventario = value; }
        public int Id_area { get => id_area; set => id_area = value; }
    }
}
