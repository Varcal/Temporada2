using System;

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
