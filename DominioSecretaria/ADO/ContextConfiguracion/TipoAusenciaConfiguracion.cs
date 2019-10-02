using System;
using System.Collections.Generic;
using System.Text;
using DominioSecretaria.Faltas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DominioSecretaria.ADO.ContextConfiguracion
{
    public class TipoAusenciaConfiguracion : IEntityTypeConfiguration<TipoAusencia>
    {
        public void Configure(EntityTypeBuilder<TipoAusencia> mb)
        {
            mb.ToTable("TipoAusencia");

            mb.HasKey(t => t.idTipoAusencia);

            mb.Property(t => t.idTipoAusencia)
                .HasColumnName("idTipoAusencia")
                .IsRequired();

            mb.Property(t => t.tipoAusencia)
                .HasColumnName("tipoAusencia")
                .HasMaxLength(30)
                .IsRequired();

            mb.Property(t => t.falta)
                .HasColumnName("falta")
                .IsRequired();
        }
    }
}
