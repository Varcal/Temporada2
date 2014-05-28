using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PessoaJuridica
    {
        public int IdPessoaJuridica { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string InscEst { get; set; }
        public DateTime DtAbertura { get; set; }

    }
}
