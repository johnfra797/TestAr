using System.Data.Entity.ModelConfiguration;

namespace TestAr.Datos.Implementaciones.Mapeos
{
    public class UsuarioMapping : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
        {
            HasKey(t => t.IdUsuario);
            ToTable("Usuario");
            Property(t => t.IdUsuario).HasColumnName("IdUsuario".ToUpper());
            Property(t => t.Nombre).HasColumnName("Nombre".ToUpper());
            Property(t => t.Clave).HasColumnName("Clave".ToUpper());
        }
    }
}