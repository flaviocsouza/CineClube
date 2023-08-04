namespace CineClubeBusiness.Modelos
{
    public class UnidadeLocadora : ModeloBase
    {
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public TimeOnly ComecoExpediente { get; set; }
        public TimeOnly FimExpediente  { get; set; }
        public string CNPJ { get; set; }
        public Guid EnderecoId { get; set; }

        public Endereco Endereco { get; set; }
    } 
    
}