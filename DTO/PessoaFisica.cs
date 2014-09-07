using System;

namespace DTO
{
    public class PessoaFisica
    {
        public int  IdPessoaFisica { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DtNascimento { get; set; }

    }
}
