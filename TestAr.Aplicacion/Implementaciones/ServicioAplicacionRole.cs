using System;
using System.Collections.Generic;
using System.Linq;
using TestAr.Aplicacion.Definiciones;
using TestAr.Datos.Definiciones.Repositorios;

namespace TestAr.Aplicacion.Implementaciones
{

    public class ServicioAplicacionRole : IServicioAplicacionRole
    {
        private readonly IRoleRepositorio _roleRepositorio;
        public ServicioAplicacionRole(IRoleRepositorio roleRepositorio)
        {
            _roleRepositorio = roleRepositorio;
        }

        public bool Eliminar(int idRole)
        {
            bool eliminado;
            try
            {
                _roleRepositorio.Eliminar(Obtener(idRole));

                _roleRepositorio.UnidadTrabajo.Commit();

                eliminado = true;
            }
            catch (Exception)
            {
                eliminado = false;
            }
            return eliminado;
        }

        public bool Guardar(Role role)
        {
            var Guardado = false;
            try
            {
                if (role.IdRole == 0)
                {
                    _roleRepositorio.Crear(role);
                }
                else
                {
                    _roleRepositorio.Actualizar(role);

                }
                _roleRepositorio.UnidadTrabajo.Commit();
                Guardado = true;
            }
            catch (Exception)
            {
                return Guardado;
            }
            return Guardado;
        }

        public Role Obtener(int idRole)
        {
            return _roleRepositorio.ObtenerPor(x => x.IdRole == idRole).FirstOrDefault();
        }

        public List<Role> ObtenerTodos()
        {
            return _roleRepositorio.ObtenerTodo().ToList();
        }
    }
}
