using CineClubeBusiness.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineClubeData.Configuration
{
    public class LocacaoConfiguration : IEntityTypeConfiguration<Locacao>
    {
        public void Configure(EntityTypeBuilder<Locacao> builder)
        {
             builder.ToTable("Locacoes");

             builder.HasKey(l => l.Id);
             
             builder.Property(l => l.DataLocacao)
             .IsRequired();

             builder.Property(l => l.DataDevolucao)
             .IsRequired();
        }
    }
}