using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using TestAr.Aplicacion.Definiciones;
using TestAr.IoC;

namespace TestAr.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class RoleController : ApiController
    {
        IServicioAplicacionRole servicioAplicacionRole = FactoryContainer.Resolver<IServicioAplicacionRole>();
        
        public string Get()
        {
            var Roles = servicioAplicacionRole.ObtenerTodos();
            string output = JsonConvert.SerializeObject(Roles);
            return output;
        }

        public string Get(int id)
        {
            var role = servicioAplicacionRole.Obtener(id);
            string output = JsonConvert.SerializeObject(role);
            return output;
        }
        
        public string Post([FromBody]Role role)
        {
            var resultado = servicioAplicacionRole.Guardar(role);
            string output = JsonConvert.SerializeObject(resultado);
            return output;
        }
        
        public string Put(int id, [FromBody]Role role)
        {
            role.IdRole = id;
            var resultado = servicioAplicacionRole.Guardar(role);
            string output = JsonConvert.SerializeObject(resultado);
            return output;
        }
        
        public string Delete(int id)
        {
            var resultado = servicioAplicacionRole.Eliminar(id);
            string output = JsonConvert.SerializeObject(resultado);
            return output;
        }
    }
}
