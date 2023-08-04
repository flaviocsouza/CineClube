namespace CineClubeBusiness.Modelos
{
    public class Endereco : ModeloBase 
    {

       public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }

        public Guid? ClienteId  { get; set; }
        public Guid? UnidadeLocadoraId { get; set; }

        public Cliente Cliente { get; set; }
        public UnidadeLocadora UnidadeLocadora{ get; set; }
    }

}