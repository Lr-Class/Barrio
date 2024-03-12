using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNivel.ENTITY
{
    public class Barrio
    {
        public Barrio()
        {
        }

        public Barrio(string iD, string nombre)
        {
            ID = iD;
            Nombre = nombre;
        }

        public string ID { get; set; }
        public string Nombre { get; set; }
    }
}
