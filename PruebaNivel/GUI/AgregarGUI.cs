using PruebaNivel.BLL;
using PruebaNivel.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNivel.GUI
{
    public class AgregarGUI
    {
        string id, nombre;
        public void FAgregar()
        {
            Console.WriteLine("Dijite el ID de el barrio:");
            id = Console.ReadLine();
            Console.WriteLine("Dijite el nombre del barrio: ");
            nombre = Console.ReadLine();

            Barrio barrio = new Barrio();
            barrio.Nombre = nombre;
            barrio.ID = id;
            
            ServicioBarrio servicioBarrio = new ServicioBarrio();
            servicioBarrio.AgregarBarrio(barrio);

            Console.ReadKey();
        }
    }
}
