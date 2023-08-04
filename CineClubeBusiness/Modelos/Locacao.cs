namespace CineClubeBusiness.Modelos
{
    public class Locacao : ModeloBase
    {
        public Guid ClienteId { get; set; }
        public IEnumerable<FitaVhs> FitasVhs { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataLocacao { get; set; }        
        public DateTime DataDevolucao { get; set; }
    }
}