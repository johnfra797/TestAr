using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAr.Datos.Definiciones.Contextos;
using TestAr.Datos.Repositorios.Implementaciones;
using System.Data.Entity;
using TestAr.Datos.Implementaciones.Mapeos;

namespace TestAr.Datos.Implementaciones.Contextos
{
     
     public class Contexto : UnidadTrabajo, IContexto
    {
        public Contexto()
        {
            Database.SetInitializer<Contexto>(null);
        }
        public IDbSet<Usuario> Usuario { get; set; }
        public IDbSet<Permiso> Permiso { get; set; }
        public IDbSet<Role> Role { get; set; }
        public IDbSet<RolePermiso> RolePermiso { get; set; }
        public IDbSet<ComentarioObj> ComentarioObj { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMapping());
            modelBuilder.Configurations.Add(new PermisoMapping());
            modelBuilder.Configurations.Add(new RoleMapping());
            modelBuilder.Configurations.Add(new RolePermisoMapping());
            modelBuilder.Configurations.Add(new ComentarioMapping());
        }
    }
}
