﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Filial
    {
        public Pessoa Pessoa { get; set; }

        public Filial()
        {
            Pessoa = new Pessoa();
        }
    }
}
