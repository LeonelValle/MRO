using System;
using System.Collections.Generic;
using System.Data;

namespace MROInventory_Project
{
    class Caducidad : Conexion
    {
        int id;
        DateTime expiration;
        int id_nparte;
        DataTable cad;
        List<Caducidad> caduco;
        int quantity;
        string pn;
        string mfg;
        string description;

        public int Id { get => id; set => id = value; }
        public DateTime Expiration { get => expiration; set => expiration = value; }
        public int Id_nparte { get => id_nparte; set => id_nparte = value; }
        public DataTable Cad { get => cad; set => cad = value; }
        internal List<Caducidad> Caduco { get => caduco; set => caduco = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Pn { get => pn; set => pn = value; }
        public string Mfg { get => mfg; set => mfg = value; }
        public string Description { get => description; set => description = value; }

        public Caducidad()
        {

        }
        public Caducidad(int id_caducidad, DateTime caducidad, int cantidad, string nparte, string mfg, string descripcion)
        {
            id = id_caducidad;
            expiration = caducidad;
            quantity = cantidad;
            pn = nparte;
            this.mfg = mfg;
            description = descripcion;
        }
    }
}
