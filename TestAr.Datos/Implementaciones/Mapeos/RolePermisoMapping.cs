using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAr.Datos.Implementaciones.Mapeos
{
     
    public class RolePermisoMapping : EntityTypeConfiguration<RolePermiso>
    {
        public RolePermisoMapping()
        {
            HasKey(t => t.IdRolePermiso);
            ToTable("RolePermiso");
            Property(t => t.IdRolePermiso).HasColumnName("IdRolePermiso");
            Property(t => t.CodPermiso).HasColumnName("CodPermiso");
            Property(t => t.CodRole).HasColumnName("CodRole");
        }
    }
}
