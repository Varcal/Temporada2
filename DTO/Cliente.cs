﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Cliente
    {
        public Pessoa Pessoa { get; set; }
    
        public Cliente()
        {
            Pessoa = new Pessoa();
        }

        public Cliente(Pessoa pessoa)
        {
            Pessoa = new Pessoa();
            Pessoa = pessoa;
        }
    }
}
