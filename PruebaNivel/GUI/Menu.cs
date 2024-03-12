using PruebaNivel.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNivel.GUI
{
    public class Menu
    {
        public void MenuPrincipal()
        {
            AgregarGUI agregarGUI = new AgregarGUI();
            BuscarGUI buscarGUI = new BuscarGUI();
            ConsultarGUI consultarGUI = new ConsultarGUI();

            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("!!! Menu de El Barrio !!!");
                Console.WriteLine("1. Agregar Barrio");
                Console.WriteLine("2. Consultar barrios");
                Console.WriteLine("3. Buscar barrio");
                Console.WriteLine("4. Salir del programa");

                Console.Write("Dijite la opcion: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        agregarGUI.FAgregar();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        buscarGUI.FBuscar();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        consultarGUI.FConsultar();
                        Console.ReadKey();
                        break;

                }Console.ReadKey();

            } while (op != 4);
        }
    }
}
