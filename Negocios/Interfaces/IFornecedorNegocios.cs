﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados.Interface;
using DTO;

namespace Negocios.Interfaces
{
    public interface IFornecedorNegocios: IRepository<Fornecedor>
    {
        IEnumerable<Fornecedor> BuscarPorNome (string nome);
    }
}