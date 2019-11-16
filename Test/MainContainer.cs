using TestAr.Aplicacion.Definiciones;
using TestAr.Aplicacion.Implementaciones;
using TestAr.Datos.Definiciones.Contextos;
using TestAr.Datos.Definiciones.Repositorios;
using TestAr.Datos.Implementaciones.Contextos;
using TestAr.Datos.Implementaciones.Repositorios;
using TestAr.Datos.Repositorios.Definiciones;
using TestAr.Datos.Repositorios.Implementaciones;
using Unity;

namespace Test
{
    public class MainContainer
    {
        private static UnityContainer _theMainContainer;

        public static UnityContainer TheMainContainer
        {
            get
            {
                if (_theMainContainer != null)
                {
                    return _theMainContainer;
                }

                _theMainContainer = new UnityContainer();

                #region UnidadesTrabajo

                _theMainContainer.RegisterType<IUnidadTrabajo, UnidadTrabajo>();

                #endregion

                #region Contextos

                _theMainContainer.RegisterType<IContexto, Contexto>();

                #endregion

                #region Servicios

                _theMainContainer.RegisterType<IServicioAplicacionUsuario, ServicioAplicacionUsuario>();
                _theMainContainer.RegisterType<IServicioAplicacionRole, ServicioAplicacionRole>();
                _theMainContainer.RegisterType<IServicioAplicacionPermiso, ServicioAplicacionPermiso>();
                _theMainContainer.RegisterType<IServicioAplicacionRolePermiso, ServicioAplicacionRolePermiso>();
                #endregion


                #region Repositorios

                _theMainContainer.RegisterType<IUsuarioRepositorio, UsuarioRepositorio>();
                _theMainContainer.RegisterType<IRoleRepositorio, RoleRepositorio>();
                _theMainContainer.RegisterType<IPermisoRepositorio, PermisoRepositorio>();
                _theMainContainer.RegisterType<IRolePermisoRepositorio, RolePermisoRepositorio>();
                #endregion

                return _theMainContainer;
            }
        }
    }
}
