using CineClubeBusiness.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineClubeData.Configuration
{
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("Filmes");

            builder.HasKey(f => f.Id);
            
            builder.Property(f => f.Titulo)
            .HasMaxLength(120)
            .IsRequired();
            
            builder.Property(f => f.Genero)
            .HasMaxLength(20)
            .IsRequired();

            builder.Property(f => f.Sinopse)
            .HasMaxLength(300)
            .IsRequired();

            builder.Property(f => f.DuracaoEmMinutos)
            .IsRequired();

            builder.Property(f => f.AnoLancamento)
            .IsRequired();
            
            builder.HasOne(f => f.CategoriaFilme)
            .WithMany(c => c.Filmes);

            builder.HasMany(f => f.FitasVhs)
            .WithOne(fita => fita.Filme);
        }
    }
}