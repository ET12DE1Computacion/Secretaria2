using DominioSecretaria.Escuela;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DominioSecretaria.ADO.ContextConfiguracion
{
    public class CursoConfiguracion : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> mb)
        {
            mb.ToTable("Curso");

            mb.HasKey(c => c.IdCurso);

            mb.Property(c => c.IdCurso)
                .HasColumnName("idCurso");

            mb.Property(c => c.Anio)
                .HasColumnName("anio")
                .IsRequired();

            mb.Property(c => c.Division)
                .HasColumnName("division")
                .IsRequired();
        }
    }
}
