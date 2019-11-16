using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAr.Aplicacion.Definiciones
{
    public interface IServicioAplicacionPermiso
    {
        bool Guardar(Permiso permiso);
        bool Eliminar(int idPermiso);
        Permiso Obtener(int idPermiso);
        List<Permiso> ObtenerTodos();
    }
}
