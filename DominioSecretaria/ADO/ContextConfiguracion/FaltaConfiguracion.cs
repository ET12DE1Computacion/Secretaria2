using System;
using System.Collections.Generic;
using System.Text;
using DominioSecretaria.Faltas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DominioSecretaria.ADO.ContextConfiguracion
{
    public class FaltaConfiguracion : IEntityTypeConfiguration<Falta>
    {
        public void Configure(EntityTypeBuilder<Falta> mb)
        {
            mb.ToTable("Falta");

            mb.HasKey(f => f.idFalta);

            mb.HasOne(f => f.alumno)
                .WithMany(x => x.faltas)
                .HasForeignKey("legajo")
                .IsRequired();

            mb.HasOne(f => f.idTipoFalta)
                .WithMany(x => x.faltas)
                .HasForeignKey("idTipoFalta")
                .IsRequired();

            mb.HasOne(f => f.idTipoAusencia)
                .WithMany()
                .HasForeignKey("idTipoAusencia")
                .IsRequired();

            mb.Property(f => f.idFalta)
                .HasColumnName("idFalta")
                .IsRequired();

            mb.Property(f => f.alumno)
                .HasColumnName("legajo")
                .IsRequired();

            mb.Property(f => f.idTipoFalta)
                .HasColumnName("idTipoFalta")
                .IsRequired();

            mb.Property(f => f.idTipoAusencia)
                .HasColumnName("idTipoAusencia")
                .IsRequired();

            mb.Property(f => f.fecha)
                .HasColumnName("fecha")
                .IsRequired();

            mb.Property(f => f.falta)
                .HasColumnName("falta")
                .IsRequired();

            mb.Property(F => F.Justificada)
                .HasColumnName("justificada")
                .IsRequired();
        }
    }
}
