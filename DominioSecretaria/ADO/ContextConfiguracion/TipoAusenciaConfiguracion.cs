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

            mb.HasKey(t => t.Id);
            mb.HasIndex(t => t.Cadena).IsUnique();

            mb.Property(t => t.Id)
                .HasColumnName("idTipoAusencia")
                .IsRequired();

            mb.Property(t => t.Cadena)
                .HasColumnName("tipoAusencia")
                .HasMaxLength(30)
                .IsRequired();

            mb.Property(t => t.ValorFalta)
                .HasColumnName("valorFalta")
                .IsRequired();
        }
    }
}
