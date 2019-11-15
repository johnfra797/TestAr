using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAr.Datos.Repositorios.Definiciones;

namespace TestAr.Datos.Definiciones.Contextos
{
    public interface IContexto : IUnidadTrabajo
    {
        IDbSet<Usuario> Usuario { get; set; }

    }
}
