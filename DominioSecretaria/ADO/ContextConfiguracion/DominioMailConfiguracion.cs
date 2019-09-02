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
            mb.ToTable("DominioMail");

            mb.HasKey(l => l.Id);
            mb.HasIndex(l => l.Cadena).IsUnique();

            mb.Property(l => l.Id)
                .HasColumnName("idDominioMail");
            mb.Property(l => l.Cadena)
                .HasColumnName("dominioMail")
                .HasMaxLength(45);
        }
    }
}