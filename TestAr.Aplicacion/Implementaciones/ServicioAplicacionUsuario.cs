using System;
using System.Collections.Generic;
using System.Linq;
using TestAr.Aplicacion.Definiciones;
using TestAr.Datos.Definiciones.Repositorios;
using TestAr.DTO;

namespace TestAr.Aplicacion.Implementaciones
{

    public class ServicioAplicacionUsuario : IServicioAplicacionUsuario
    {

        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IRoleRepositorio _roleRepositorio;
        public ServicioAplicacionUsuario(IUsuarioRepositorio usuarioRepositorio, IRoleRepositorio roleRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _roleRepositorio = roleRepositorio;
        }

        public bool Eliminar(int idUsuario)
        {
            bool eliminado;
            try
            {
                _usuarioRepositorio.Eliminar(ObtenerUsuario(idUsuario));

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

        private Usuario ObtenerUsuario(int idUsuario)
        {
            return _usuarioRepositorio.ObtenerPor(x => x.IdUsuario == idUsuario).FirstOrDefault();
        }

        public UsuarioDTO Obtener(int idUsuario)
        {
            var usuario = _usuarioRepositorio.ObtenerPor(x => x.IdUsuario == idUsuario)
                .Select(x => new UsuarioDTO
                {
                    IdUsuario = x.IdUsuario,
                    Nombre = x.Nombre,
                    Clave = x.Clave,
                    CodRole = x.CodRole,
                    Direccion = x.Direccion,
                    Email = x.Email,
                    Telefono = x.Telefono
                }).FirstOrDefault();

            usuario.RoleAsociado = ObtenerRole(usuario.CodRole);
            return usuario;
        }

        public List<UsuarioDTO> ObtenerTodos()
        {
            var ListaUsuarios = _usuarioRepositorio.ObtenerTodo()
                .Select(x => new UsuarioDTO
                {
                    IdUsuario = x.IdUsuario,
                    Nombre = x.Nombre,
                    Clave = x.Clave,
                    CodRole = x.CodRole,
                    Direccion = x.Direccion,
                    Email = x.Email,
                    Telefono = x.Telefono
                }).ToList();
            ListaUsuarios.ForEach(x => x.RoleAsociado = ObtenerRole(x.CodRole));

            return ListaUsuarios;
        }
        private Role ObtenerRole(int idRole)
        {
            return _roleRepositorio.ObtenerPor(x => x.IdRole == idRole).FirstOrDefault();
        }
    }
}
