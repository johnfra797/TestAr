using System.Data.Entity.ModelConfiguration;

namespace TestAr.Datos.Implementaciones.Mapeos
{
     
    public class PermisoMapping : EntityTypeConfiguration<Permiso>
    {
        public PermisoMapping()
        {
            HasKey(t => t.IdPermiso);
            ToTable("Permiso");
            Property(t => t.IdPermiso).HasColumnName("IdPermiso");
            Property(t => t.Nombre).HasColumnName("Nombre");
        }
    }
}

