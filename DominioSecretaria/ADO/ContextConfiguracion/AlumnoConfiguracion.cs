using System;
using System.Collections.Generic;
using System.Text;
using DominioSecretaria.Escuela;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DominioSecretaria.ADO.ContextConfiguracion
{
    public class AlumnoConfiguracion : IEntityTypeConfiguration<Alumno>
    {
        public void Configure(EntityTypeBuilder<Alumno> mb)
        {
            mb.ToTable("Alumno");

            mb.HasKey(a => a.legajo);

            mb.Property<int>("idPersona");
            mb.HasOne(a => a.Persona)
                .WithMany()
                .HasForeignKey("idPersona")
                .IsRequired();

            mb.Property<byte>("idCursoActual");
            mb.HasOne(a => a.CursoActual)
                .WithMany()
                .HasForeignKey("idCursoActual")
                .IsRequired();

            mb.Property(a => a.legajo)
                .HasColumnName("legajo");

            mb.Property(a => a.Libro)
                .HasColumnName("libro");

            mb.Property(a => a.Folio)
                .HasColumnName("folio");
        }
    }
}
