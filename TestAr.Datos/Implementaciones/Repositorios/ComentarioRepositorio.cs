using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAr.Datos.Definiciones.Contextos;
using TestAr.Datos.Definiciones.Repositorios;
using TestAr.Datos.Repositorios.Implementaciones;

namespace TestAr.Datos.Implementaciones.Repositorios
{

    public class ComentarioRepositorio : Repositorio<ComentarioObj>, IComentarioRepositorio
    {
        public ComentarioRepositorio(IContexto unidadTrabajo)
              : base(unidadTrabajo)
        {

        }
    }
}
