using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAr.Datos.Implementaciones.Mapeos
{
     
    public class ComentarioMapping : EntityTypeConfiguration<ComentarioObj>
    {
        public ComentarioMapping()
        {
            HasKey(t => t.IdComentario);
            ToTable("Comentario");
            Property(t => t.IdComentario).HasColumnName("IdComentario");
            Property(t => t.Comentario).HasColumnName("Comentario");
        }
    }
}
