using PruebaNivel.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNivel.GUI
{
    public class ConsultarGUI
    {
        public void FConsultar()
        {
            Console.SetCursorPosition(3,3); Console.Write("ID");
            Console.SetCursorPosition(8,3); Console.Write("Nombre");
            Console.WriteLine("_______________________________________________________");

            ServicioBarrio servicioBarrio = new ServicioBarrio();
            servicioBarrio.ConsultarBarrio();

            Console.ReadKey();
        }
    }
}
