namespace CineClubeBusiness.Modelos
{
    public class ModeloBase
    {
        public ModeloBase()
        {
            Id = new Guid();
        }
        public Guid Id { get; set; }

    }
}