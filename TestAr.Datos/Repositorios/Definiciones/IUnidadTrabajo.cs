using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAr.Datos.Repositorios.Definiciones
{
    public interface IUnidadTrabajo : IDisposable
    {
        void BeginTransaction();
        void Commit();
    }
}
