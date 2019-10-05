using DominioSecretaria.Escuela;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DominioSecretaria.ADO.ContextConfiguracion
{
    public class CursadaConfiguracion : IEntityTypeConfiguration<Cursada>
    {
        public void Configure(EntityTypeBuilder<Cursada> mb)
        {
            mb.ToTable("Cursada");

            mb.HasKey(c => c.idCursada);

            mb.HasOne(c => c.Alumno)
                .WithMany(a => a.Cursadas)
                .HasForeignKey("legajoAlumno")
                .IsRequired();

            mb.HasOne(c => c.Curso)
                .WithMany()
                .HasForeignKey("idCurso")
                .IsRequired();

            mb.Property(c => c.Fecha)
                .HasColumnName("fecha")
                .IsRequired();

            mb.Property(c => c.CicloLectivo)
                    .HasColumnName("cicloLectivo")
                    .IsRequired();    
        }
    }
}
