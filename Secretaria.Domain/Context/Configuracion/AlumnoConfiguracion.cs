using Secretaria.Domain.Escuela;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Secretaria.Domain.ADO.ContextConfiguracion
{
    public class AlumnoConfiguracion : IEntityTypeConfiguration<Alumno>
    {
        public void Configure(EntityTypeBuilder<Alumno> mb)
        {
            //tabla
            mb.ToTable("Alumno");

            //primary key
            mb.HasKey(a => a.legajo);

            mb.Property(a => a.legajo)
                .HasColumnName("legajoAlumno");

            //foreign key
            mb.Property<int>("idPersona");

            mb.HasOne(a => a.Persona)
                .WithMany()
                .HasForeignKey("idPersona")
                .IsRequired();

            mb.HasOne(a => a.CursoActual)
                .WithMany(x => x.Alumnos)
                .HasForeignKey("idCursoActual")
                .IsRequired();

            //propiedades
            mb.Property(a => a.Libro)
                .HasColumnName("libro");

            mb.Property(a => a.Folio)
                .HasColumnName("folio");
        }
    }
}
