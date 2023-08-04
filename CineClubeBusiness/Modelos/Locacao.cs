namespace CineClubeBusiness.Modelos
{
    public class Locacao : ModeloBase
    {
        public FitaVhs FitaVhs { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataLocacao { get; set; }        
        public DateTime DataDevolucao { get; set; }
    }
}