using CineClubeBusiness.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CineClubeData.CineClubeDbContext
{
    public class CineClubeDbContext : DbContext
    {
        public CineClubeDbContext(DbContextOptions options) : base(options){}
        public DbSet<CategoriaFilme> CategoriaFilmes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<FitaVhs> FitasVhs { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<UnidadeLocadora> UnidadesLocadora { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CineClubeDbContext).Assembly);
            
            foreach(var relacao in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relacao.DeleteBehavior = DeleteBehavior.ClientSetNull;
            
            base.OnModelCreating(modelBuilder);
        }
    }

}