namespace CineClubeBusiness.Modelos
{
    public class Filme : ModeloBase
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Sinopse { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public int AnoLancamento { get; set; }

        public Guid CategoriaFilmeId { get; set; }

        public CategoriaFilme CategoriaFilme { get; set; }
        public IEnumerable<FitaVhs> FitasVhs { get; set; }
    }
    
}