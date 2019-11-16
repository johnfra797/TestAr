using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAr.Aplicacion.Definiciones;
using TestAr.Datos.Definiciones.Repositorios;

namespace TestAr.Aplicacion.Implementaciones
{
    public class ServicioAplicacionPermiso : IServicioAplicacionPermiso
    {
        private readonly IPermisoRepositorio _permisoRepositorio;
        public ServicioAplicacionPermiso(IPermisoRepositorio permisoRepositorio)
        {
            _permisoRepositorio = permisoRepositorio;
        }

        public bool Eliminar(int idPermiso)
        {
            bool eliminado;
            try
            {
                _permisoRepositorio.Eliminar(Obtener(idPermiso));

                _permisoRepositorio.UnidadTrabajo.Commit();

                eliminado = true;
            }
            catch (Exception)
            {
                eliminado = false;
            }
            return eliminado;
        }

        public bool Guardar(Permiso permiso)
        {
            var Guardado = false;
            try
            {
                if (permiso.IdPermiso == 0)
                {
                    _permisoRepositorio.Crear(permiso);
                }
                else
                {
                    _permisoRepositorio.Actualizar(permiso);

                }
                _permisoRepositorio.UnidadTrabajo.Commit();
                Guardado = true;
            }
            catch (Exception)
            {
                return Guardado;
            }
            return Guardado;
        }

        public Permiso Obtener(int idPermiso)
        {
            return _permisoRepositorio.ObtenerPor(x => x.IdPermiso == idPermiso).FirstOrDefault();
        }

        public List<Permiso> ObtenerTodos()
        {
            return _permisoRepositorio.ObtenerTodo().ToList();
        }
    }
}
