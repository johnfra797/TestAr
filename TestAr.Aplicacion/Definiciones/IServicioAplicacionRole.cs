using System.Collections.Generic;

namespace TestAr.Aplicacion.Definiciones
{
    public interface IServicioAplicacionRole
    {
        bool Guardar(Role role);
        bool Eliminar(int idRole);
        Role Obtener(int idRole);
        List<Role> ObtenerTodos();
    }
}
