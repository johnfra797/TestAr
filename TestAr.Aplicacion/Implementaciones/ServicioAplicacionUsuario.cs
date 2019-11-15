using TestAr.Aplicacion.Definiciones;
using TestAr.Datos.Definiciones.Repositorios;

namespace TestAr.Aplicacion.Implementaciones
{

    public class ServicioAplicacionUsuario : IServicioAplicacionUsuario
    {

        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public ServicioAplicacionUsuario(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }


    }
}
