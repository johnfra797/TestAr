using TestAr.Datos.Definiciones.Contextos;
using TestAr.Datos.Definiciones.Repositorios;
using TestAr.Datos.Repositorios.Implementaciones;

namespace TestAr.Datos.Implementaciones.Repositorios
{
    public class PermisoRepositorio : Repositorio<Permiso>, IPermisoRepositorio
    {
        public PermisoRepositorio(IContexto unidadTrabajo)
              : base(unidadTrabajo)
        {

        }
    }
}
