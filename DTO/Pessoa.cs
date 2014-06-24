﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public PessoaTipo PessoaTipo { get; set; }
        public bool Ativo { get; set; }

        public Pessoa()
        {
            PessoaTipo = new PessoaTipo();
        }
    }
}
