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
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMapping());

        }
    }
}
