using System;
using System.Collections.Generic;
using System.Text;
using DominioSecretaria.Faltas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DominioSecretaria.ADO.ContextConfiguracion
{
    public class AsistenciaCursoConfiguracion : IEntityTypeConfiguration<AsistenciaCurso>
    {
        public void Configure(EntityTypeBuilder<AsistenciaCurso> mb)
        {
            mb.ToTable("AsisienciaCurso");

            mb.HasKey(a => a.idAsistenciaCurso);

            //mb.HasOne(a => a.idCurso)
            //    .WithMany()
            //    .HasForeignKey("idCurso")
            //    .IsRequired();

            //mb.HasOne(a => a.idTipoFalta)
            //    .WithMany()
            //    .HasForeignKey("idTipoFalta");

            mb.Property(a => a.idAsistenciaCurso)
                .HasColumnName("idAsistenciaCurso")
                .IsRequired();

            mb.Property(a => a.idCurso)
                .HasColumnName("idCurso")
                .IsRequired();

            mb.Property(a => a.idTipoFalta)
                .HasColumnName("idTipoFalta")
                .IsRequired();

            mb.Property(a => a.fecha)
                .HasColumnName("fecha")
                .IsRequired();
        }

    }
}
