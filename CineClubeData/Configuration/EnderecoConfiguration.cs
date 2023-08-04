using CineClubeBusiness.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineClubeData.Configuration
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Enderecos");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Rua)
            .HasMaxLength(80)
            .IsRequired();

            
            builder.Property(e => e.Numero)
            .HasMaxLength(5)
            .IsRequired();

            
            builder.Property(e => e.Complemento)
            .HasMaxLength(80);
            
            builder.Property(e => e.Bairro)
            .HasMaxLength(80)
            .IsRequired();

            builder.Property(e => e.Cidade)
            .HasMaxLength(80)
            .IsRequired();

            builder.Property(e => e.UF)
            .HasMaxLength(2)
            .IsRequired();

            
            builder.Property(e => e.CEP)
            .HasMaxLength(8)
            .IsRequired();
        }
    }
}