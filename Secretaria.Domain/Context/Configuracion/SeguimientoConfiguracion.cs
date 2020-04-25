using Secretaria.Domain.Escuela;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Secretaria.Domain.ADO.ContextConfiguracion
{
    public class SeguimientoConfiguracion : IEntityTypeConfiguration<Seguimiento>
    {
        public void Configure(EntityTypeBuilder<Seguimiento> mb)
        {
            mb.ToTable("seguimiento");

            mb.HasKey(s => s.IdSeguimiento);

            mb.HasOne(s => s.Alumno)
                .WithMany(a=>a.Seguimientos)
                .HasForeignKey("legajo")
                .IsRequired();

            mb.Property(s => s.IdSeguimiento)
                .HasColumnName("idSeguimiento")
                .IsRequired();

            mb.Property(s => s.Observacion)
                .HasColumnName("observacion")
                .HasMaxLength(250)
                .IsRequired();

            mb.Property(s => s.Fecha)
                .HasColumnName("fecha")
                .HasColumnType("Date")
                .IsRequired();
        }
    }
}
