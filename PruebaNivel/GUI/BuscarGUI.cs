using PruebaNivel.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNivel.GUI
{
    public class BuscarGUI
    {
        string id;
        public void FBuscar()
        {
            Console.WriteLine("Dijite el ID de el barrio:");
            id = Console.ReadLine();

            ServicioBarrio servicioBarrio = new ServicioBarrio();
            servicioBarrio.BuscarPorID(id);

            Console.ReadLine();
        }
    }
}
