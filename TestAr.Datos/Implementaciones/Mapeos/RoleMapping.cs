using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAr.Datos.Implementaciones.Mapeos
{
     
   public class RoleMapping : EntityTypeConfiguration<Role>
    {
        public RoleMapping()
        {
            HasKey(t => t.IdRole);
            ToTable("Role");
            Property(t => t.IdRole).HasColumnName("IdRole");
            Property(t => t.Nombre).HasColumnName("Nombre");
        }
    }
}
