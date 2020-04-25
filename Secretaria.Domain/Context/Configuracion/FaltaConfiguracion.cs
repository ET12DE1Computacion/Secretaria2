using Secretaria.Domain.Faltas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Secretaria.Domain.ADO.ContextConfiguracion
{
    public class FaltaConfiguracion : IEntityTypeConfiguration<Falta>
    {
        public void Configure(EntityTypeBuilder<Falta> mb)
        {
            //tabla
            mb.ToTable("Falta");

            //primary key
            mb.HasKey(f => f.IdFalta);

            mb.Property(f => f.IdFalta)
                .HasColumnName("idFalta")
                .IsRequired();
            
            //foreign key
            mb.HasOne(f => f.Alumno)
                .WithMany(x => x.Faltas)
                .HasForeignKey("idAlumno")
                .IsRequired();

            mb.HasOne(f => f.TipoFalta)
                .WithMany(x => x.Faltas)
                .HasForeignKey("idTipoFalta")
                .IsRequired();

            mb.HasOne(f => f.TipoAusencia)
                .WithMany(x => x.Faltas)
                .HasForeignKey("idTipoAusencia")
                .IsRequired();

            mb.HasOne(x => x.Cursada)
                .WithMany(x => x.Faltas)
                .HasForeignKey("idCursada")
                .IsRequired();

            //propiedades
            mb.Property(f => f.Fecha)
                .HasColumnName("fecha")
                .IsRequired();

            mb.Property(f => f.ValorFalta)
                .HasColumnName("valorFalta")
                .IsRequired();

            mb.Property(F => F.Justificada)
                .HasColumnName("justificada")
                .IsRequired();
        }
    }
}
