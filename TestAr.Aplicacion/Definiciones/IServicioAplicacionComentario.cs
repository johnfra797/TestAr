using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAr.Aplicacion.Definiciones
{
    public interface IServicioAplicacionComentario
    {
        bool Guardar(ComentarioObj comentario);
        bool Eliminar(int idComentario);
        ComentarioObj Obtener(int idComentario);
        List<ComentarioObj> ObtenerTodos();
    }
}
