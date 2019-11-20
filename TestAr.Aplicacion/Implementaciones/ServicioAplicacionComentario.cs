using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAr.Aplicacion.Definiciones;
using TestAr.Datos.Definiciones.Repositorios;

namespace TestAr.Aplicacion.Implementaciones
{

    public class ServicioAplicacionComentario : IServicioAplicacionComentario
    {
        private readonly IComentarioRepositorio _ComentarioRepositorio;
        public ServicioAplicacionComentario(IComentarioRepositorio ComentarioRepositorio)
        {
            _ComentarioRepositorio = ComentarioRepositorio;
        }

        public bool Eliminar(int idComentario)
        {
            bool eliminado;
            try
            {
                _ComentarioRepositorio.Eliminar(Obtener(idComentario));

                _ComentarioRepositorio.UnidadTrabajo.Commit();

                eliminado = true;
            }
            catch (Exception)
            {
                eliminado = false;
            }
            return eliminado;
        }

        public bool Guardar(ComentarioObj comentario)
        {
            var Guardado = false;
            try
            {
                if (comentario.IdComentario == 0)
                {
                    _ComentarioRepositorio.Crear(comentario);
                }
                else
                {
                    _ComentarioRepositorio.Actualizar(comentario);

                }
                _ComentarioRepositorio.UnidadTrabajo.Commit();
                Guardado = true;
            }
            catch (Exception)
            {
                return Guardado;
            }
            return Guardado;
        }

        public ComentarioObj Obtener(int idComentario)
        {
            return _ComentarioRepositorio.ObtenerPor(x => x.IdComentario == idComentario).FirstOrDefault();
        }

        public List<ComentarioObj> ObtenerTodos()
        {
            return _ComentarioRepositorio.ObtenerTodo().ToList();
        }
        
    }
}
