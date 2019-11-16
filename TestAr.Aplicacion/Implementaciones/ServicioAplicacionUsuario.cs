using System;
using System.Collections.Generic;
using System.Linq;
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

        public bool Eliminar(int idUsuario)
        {
            bool eliminado;
            try
            {
                _usuarioRepositorio.Eliminar(Obtener(idUsuario));

                _usuarioRepositorio.UnidadTrabajo.Commit();

                eliminado = true;
            }
            catch (Exception)
            {
                eliminado = false;
            }
            return eliminado;
        }

        public bool Guardar(Usuario usuario)
        {
            var Guardado = false;
            try
            {
                if (usuario.IdUsuario == 0)
                {
                    _usuarioRepositorio.Crear(usuario);
                }
                else
                {
                    _usuarioRepositorio.Actualizar(usuario);

                }
                _usuarioRepositorio.UnidadTrabajo.Commit();
                Guardado = true;
            }
            catch (Exception)
            {
                return Guardado;
            }
            return Guardado;
        }

        public Usuario Obtener(int idUsuario)
        {
            return _usuarioRepositorio.ObtenerPor(x => x.IdUsuario == idUsuario).FirstOrDefault();
        }

        public List<Usuario> ObtenerTodos()
        {
            return _usuarioRepositorio.ObtenerTodo().ToList();
        }
    }
}
