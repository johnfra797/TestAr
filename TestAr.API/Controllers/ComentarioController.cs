using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TestAr.Aplicacion.Definiciones;
using TestAr.IoC;

namespace TestAr.API.Controllers
{
     [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ComentarioController : ApiController
    {
        IServicioAplicacionComentario servicioAplicacionComentario = FactoryContainer.Resolver<IServicioAplicacionComentario>();

        public string Get()
        {
            var Roles = servicioAplicacionComentario.ObtenerTodos();
            string output = JsonConvert.SerializeObject(Roles);
            return output;
        }

        public string Get(int id)
        {
            var role = servicioAplicacionComentario.Obtener(id);
            string output = JsonConvert.SerializeObject(role);
            return output;
        }

        public string Post([FromBody]ComentarioObj comentario)
        {
            var resultado = servicioAplicacionComentario.Guardar(comentario);
            string output = JsonConvert.SerializeObject(resultado);
            return output;
        }

        public string Put(int id, [FromBody]ComentarioObj comentario)
        {
            comentario.IdComentario = id;
            var resultado = servicioAplicacionComentario.Guardar(comentario);
            string output = JsonConvert.SerializeObject(resultado);
            return output;
        }

        public string Delete(int id)
        {
            var resultado = servicioAplicacionComentario.Eliminar(id);
            string output = JsonConvert.SerializeObject(resultado);
            return output;
        }
    }
}
