﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados;
using AcessoBancoDados.Interface;
using DTO;

namespace Negocios.Interfaces
{
    public interface IProdutoNegocios: IRepository<Produto>
    {
        IEnumerable<Produto> BuscarNome(string txt);
    }
}