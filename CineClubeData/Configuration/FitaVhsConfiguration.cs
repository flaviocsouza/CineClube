using CineClubeBusiness.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineClubeData.Configuration
{
    public class FitaVhsConfiguration : IEntityTypeConfiguration<FitaVhs>
    {
        public void Configure(EntityTypeBuilder<FitaVhs> builder)
        {
            builder.ToTable("FitasVHS");

            builder.HasKey(f => f.Id);

            builder.HasMany(f => f.HistoricoLocacao)
            .WithMany(l => l.FitasVhs);
        }
    }
}