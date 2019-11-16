using TestAr.Datos.Definiciones.Contextos;
using TestAr.Datos.Definiciones.Repositorios;
using TestAr.Datos.Repositorios.Implementaciones;

namespace TestAr.Datos.Implementaciones.Repositorios
{

    public class RolePermisoRepositorio : Repositorio<RolePermiso>, IRolePermisoRepositorio
    {
        public RolePermisoRepositorio(IContexto unidadTrabajo)
              : base(unidadTrabajo)
        {

        }
    }
}
