using Newtonsoft.Json;
using System.Web.Http;
using TestAr.Aplicacion.Definiciones;
using TestAr.IoC;

namespace TestAr.API.Controllers
{
    public class PermisoController : ApiController
    {
        IServicioAplicacionPermiso servicioAplicacionPermiso = FactoryContainer.Resolver<IServicioAplicacionPermiso>();
        
        public string Get()
        {
            var Permisos = servicioAplicacionPermiso.ObtenerTodos();
            string output = JsonConvert.SerializeObject(Permisos);
            return output;
        }
        
        public string Get(int id)
        {
            var permiso = servicioAplicacionPermiso.Obtener(id);
            string output = JsonConvert.SerializeObject(permiso);
            return output;
        }
        
        public string Post([FromBody]Permiso permiso)
        {
            var resultado = servicioAplicacionPermiso.Guardar(permiso);
            string output = JsonConvert.SerializeObject(resultado);
            return output;
        }
        
        public string Put(int id, [FromBody]Permiso permiso)
        {
            var resultado = servicioAplicacionPermiso.Guardar(permiso);
            string output = JsonConvert.SerializeObject(resultado);
            return output;
        }
        
        public string Delete(int id)
        {
            var resultado = servicioAplicacionPermiso.Eliminar(id);
            string output = JsonConvert.SerializeObject(resultado);
            return output;
        }
    }
}
