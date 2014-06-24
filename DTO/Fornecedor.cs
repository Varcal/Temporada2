﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Fornecedor
    {
        public int IdFornecedor { get; set; }

        public int IdPessoaTipo { get; set; }

        public string Nome { get; set; }

        public string DsPessoaTipo { get; set; }
        public string Cpf_Cnpj { get; set; }
        public string Rg_InscEst { get; set; }
        public DateTime DtNasc_DtAbertura { get; set; }
    }
}
