using Newtonsoft.Json;
using System.Web.Http;
using System.Web.Http.Cors;
using TestAr.Aplicacion.Definiciones;
using TestAr.IoC;

namespace TestAr.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsuarioController : ApiController
    {
        IServicioAplicacionUsuario servicioAplicacionUsuario = FactoryContainer.Resolver<IServicioAplicacionUsuario>();
        IServicioAplicacionRolePermiso servicioAplicacionRolePermiso = FactoryContainer.Resolver<IServicioAplicacionRolePermiso>();

        public string Get()
        {
            var Usuarios = servicioAplicacionUsuario.ObtenerTodos();
            string output = JsonConvert.SerializeObject(Usuarios);
            return output;
        }

        public string Get(int id)
        {
            var usuario = servicioAplicacionUsuario.Obtener(id);
            string output = JsonConvert.SerializeObject(usuario);
            return output;
        }
        public string Post([FromBody]Usuario usuario)
        {
            var resultado = servicioAplicacionUsuario.Guardar(usuario);
            string output = JsonConvert.SerializeObject(resultado);
            return output;
        }

        public string Put(int id, [FromBody]Usuario usuario)
        {
            usuario.IdUsuario = id;
            var resultado = servicioAplicacionUsuario.Guardar(usuario);
            string output = JsonConvert.SerializeObject(resultado);
            return output;
        }

        public string Delete(int id)
        {
            var resultado = servicioAplicacionUsuario.Eliminar(id);
            string output = JsonConvert.SerializeObject(resultado);
            return output;
        }
    }
}
