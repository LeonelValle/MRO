namespace MROInventory_Project
{
    class Caracteristicas : Conexion
    {
        int id_caracteristicas;
        string caracteristicas;

        public int Id_caracteristicas { get => id_caracteristicas; set => id_caracteristicas = value; }
        public string Caracteristica { get => caracteristicas; set => caracteristicas = value; }
    }
}
