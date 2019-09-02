using System;
using System.Collections.Generic;
using System.Text;
using DominioSecretaria.InfoPersonal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DominioSecretaria.ADO.ContextConfiguracion
{
    public class DominioMailConfiguracion : IEntityTypeConfiguration<DominioMail>
    {
        public void Configure(EntityTypeBuilder<DominioMail> mb)
        {
            mb.ToTable("DomnioMail");

            mb.HasIndex(l => l.Cadena).IsUnique();

            mb.Property(l => l.Cadena)
                .HasColumnName("DominioMail")
                .HasMaxLength(45);
        }
    }
}
