using CineClubeBusiness.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineClubeData.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            
            builder.HasKey(c => c.Id);           

            builder.Property(c => c.Nome)
            .HasMaxLength(120)
            .IsRequired();

            builder.HasOne(c => c.Endereco);

            builder.HasMany(c => c.HistoricoLocacao)
            .WithOne(l => l.Cliente);
        }
    }
}