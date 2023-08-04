namespace CineClubeBusiness.Modelos
{
    public class FitaVhs : ModeloBase
    {
        public Filme Filme { get; set; }
        public UnidadeLocadora Unidade { get; set; }

        public Guid FilmeId { get; set; }
        public Guid UnidadeLocadoraId { get; set; }
        
        public IEnumerable<Locacao> HistoricoLocacao { get; set; }
    }
}