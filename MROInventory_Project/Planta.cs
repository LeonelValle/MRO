namespace MROInventory_Project
{
    class Planta : Conexion
    {
        static int id_planta;
        string planta;

        public int Id_planta { get => id_planta; set => id_planta = value; }
        public string Plantas { get => planta; set => planta = value; }
    }
}
