using TestAr.Datos.Definiciones.Contextos;
using TestAr.Datos.Definiciones.Repositorios;
using TestAr.Datos.Repositorios.Implementaciones;

namespace TestAr.Datos.Implementaciones.Repositorios
{
    public class RoleRepositorio : Repositorio<Role>, IRoleRepositorio
    {
        public RoleRepositorio(IContexto unidadTrabajo)
              : base(unidadTrabajo)
        {

        }
    }
}
