using PruebaNivel.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNivel.BLL
{
    public class ServicioBarrio:ICrudBarrio
    {
        List<Barrio> barrios;

        public ServicioBarrio()
        {
            barrios = new List<Barrio>();
        }

        public string AgregarBarrio(Barrio barrio)
        {
            barrios.Add(barrio);
            return "Se agregro el barrio";
        }


        public List<Barrio> ConsultarBarrio()
        {
            return barrios;
        }



       public Barrio BuscarPorID(string id)
        {
            foreach (var item in barrios)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
