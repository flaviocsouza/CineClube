using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineClubeBusiness.Modelos
{
    public class Cliente : ModeloBase
    {
        public string Nome { get; set; }
        public Guid EnderecoID { get; set; }
        public Endereco Endereco { get; set; }
        public IEnumerable<Locacao> HistoricoLocacao { get; set; }
        
    }
}