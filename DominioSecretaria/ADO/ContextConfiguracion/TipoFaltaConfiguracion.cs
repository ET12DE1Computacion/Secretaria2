using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text;
using DominioSecretaria.Faltas;

namespace DominioSecretaria.ADO.ContextConfiguracion
{
    public class TipoFaltaConfiguracion : IEntityTypeConfiguration<TipoFalta>
    {
        public void Configure(EntityTypeBuilder<TipoFalta> mb)
        {
            mb.ToTable("tipoFalta");

            mb.HasKey(t => t.Id);
            mb.HasIndex(t => t.Cadena).IsUnique();

            mb.Property(t => t.Id)
                .HasColumnName("idTipoFalta");

            mb.Property(t => t.Cadena)
                .HasColumnName("tipoFalta")
                .HasMaxLength(20);
        }
    }
}
