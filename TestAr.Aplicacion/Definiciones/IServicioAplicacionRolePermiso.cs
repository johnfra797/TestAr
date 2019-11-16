using System.Collections.Generic;

namespace TestAr.Aplicacion.Definiciones
{
    public interface IServicioAplicacionRolePermiso
    {
        bool Guardar(RolePermiso rolePermiso);
        bool Eliminar(int idRolePermiso);
        RolePermiso Obtener(int idRolePermiso);
        List<RolePermiso> ObtenerTodos();
    }
}
