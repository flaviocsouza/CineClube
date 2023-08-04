using CineClubeBusiness.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineClubeData.Configuration
{
    public class CategoriaFilmeConfiguration : IEntityTypeConfiguration<CategoriaFilme>
    {
        public void Configure(EntityTypeBuilder<CategoriaFilme> builder)
        {
            builder.ToTable("CategoriasFilme");
            
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Titulo)
            .HasMaxLength(20)
            .IsRequired();

            builder.Property(c => c.ValorLocacao)
            .IsRequired();

            builder.Property(c => c.DiasParaDevolucao)
            .IsRequired();
        }
    }
}