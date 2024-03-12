using PruebaNivel.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNivel.BLL
{
    public interface ICrudBarrio
    {
        string AgregarBarrio(Barrio barrio);
        List<Barrio> ConsultarBarrio();
        Barrio BuscarPorID(string id);

    }
}
