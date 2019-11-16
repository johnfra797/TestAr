using System;
using System.Collections.Generic;
using System.Linq;
using TestAr.Aplicacion.Definiciones;
using TestAr.Datos.Definiciones.Repositorios;

namespace TestAr.Aplicacion.Implementaciones
{
    public class ServicioAplicacionRolePermiso : IServicioAplicacionRolePermiso
    {
        private readonly IRolePermisoRepositorio _rolePermisoRepositorio;
        public ServicioAplicacionRolePermiso(IRolePermisoRepositorio rolePermisoRepositorio)
        {
            _rolePermisoRepositorio = rolePermisoRepositorio;
        }

        public bool Eliminar(int idRolePermiso)
        {
            bool eliminado;
            try
            {
                _rolePermisoRepositorio.Eliminar(Obtener(idRolePermiso));

                _rolePermisoRepositorio.UnidadTrabajo.Commit();

                eliminado = true;
            }
            catch (Exception)
            {
                eliminado = false;
            }
            return eliminado;
        }

        public bool Guardar(RolePermiso rolePermiso)
        {
            var Guardado = false;
            try
            {
                if (rolePermiso.IdRolePermiso == 0)
                {
                    _rolePermisoRepositorio.Crear(rolePermiso);
                }
                else
                {
                    _rolePermisoRepositorio.Actualizar(rolePermiso);

                }
                _rolePermisoRepositorio.UnidadTrabajo.Commit();
                Guardado = true;
            }
            catch (Exception)
            {
                return Guardado;
            }
            return Guardado;
        }

        public RolePermiso Obtener(int idRolePermiso)
        {
            return _rolePermisoRepositorio.ObtenerPor(x => x.IdRolePermiso == idRolePermiso).FirstOrDefault();
        }

        public List<RolePermiso> ObtenerTodos()
        {
            return _rolePermisoRepositorio.ObtenerTodo().ToList();
        }
    }
}
