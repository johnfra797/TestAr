using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAr.Datos.Repositorios.Definiciones;

namespace TestAr.Datos.Definiciones.Contextos
{
    public interface IContexto : IUnidadTrabajo
    {
        IDbSet<Usuario> Usuario { get; set; }
        IDbSet<Permiso> Permiso { get; set; }
        IDbSet<Role> Role { get; set; }
        IDbSet<RolePermiso> RolePermiso { get; set; }
        IDbSet<ComentarioObj> ComentarioObj { get; set; }
    }
}
