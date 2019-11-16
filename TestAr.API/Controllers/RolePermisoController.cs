using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestAr.Aplicacion.Definiciones;
using TestAr.IoC;

namespace TestAr.API.Controllers
{
    public class RolePermisoController : ApiController
    {
        IServicioAplicacionRolePermiso servicioAplicacionRolePermiso = FactoryContainer.Resolver<IServicioAplicacionRolePermiso>();

        public string Get()
        {
            var RolePermisos = servicioAplicacionRolePermiso.ObtenerTodos();
            string output = JsonConvert.SerializeObject(RolePermisos);
            return output;
        }

        public string Get(int id)
        {
            var rolePermiso = servicioAplicacionRolePermiso.Obtener(id);
            string output = JsonConvert.SerializeObject(rolePermiso);
            return output;
        }
        public string Post([FromBody]RolePermiso rolePermiso)
        {
            var resultado = servicioAplicacionRolePermiso.Guardar(rolePermiso);
            string output = JsonConvert.SerializeObject(resultado);
            return output;
        }

        public string Put(int id, [FromBody]RolePermiso rolePermiso)
        {
            var resultado = servicioAplicacionRolePermiso.Guardar(rolePermiso);
            string output = JsonConvert.SerializeObject(resultado);
            return output;
        }

        public string Delete(int id)
        {
            var resultado = servicioAplicacionRolePermiso.Eliminar(id);
            string output = JsonConvert.SerializeObject(resultado);
            return output;
        }
    }
}
