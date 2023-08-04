using CineClubeBusiness.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineClubeData.Configuration
{
    public class UnidadeLocadoraConfiguration : IEntityTypeConfiguration<UnidadeLocadora>
    {
        public void Configure(EntityTypeBuilder<UnidadeLocadora> builder)
        {
            builder.ToTable("UnidadesLocadora");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.NomeFantasia)
            .HasMaxLength(120)
            .IsRequired();
            
            builder.Property(u => u.RazaoSocial)
            .HasMaxLength(120)
            .IsRequired();

            builder.Property(u => u.ComecoExpediente)
            .IsRequired();

            builder.Property(u => u.FimExpediente)
            .IsRequired();

            builder.Property(u => u.CNPJ)
            .HasMaxLength(14)
            .IsFixedLength()
            .IsRequired();

            builder.HasOne(u  => u.Endereco);           
            
        }
    }
}