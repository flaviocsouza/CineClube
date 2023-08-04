namespace CineClubeBusiness.Modelos
{
    public class CategoriaFilme : ModeloBase
    {
        public string Titulo { get; set; }
        public decimal ValorLocacao { get; set; }
        public int DiasParaDevolucao { get; set; }

        public IEnumerable<Filme> Filmes { get; set; }
    }

}