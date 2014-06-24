using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados;
using Negocios.Interfaces;

namespace Negocios
{
    public class ProdutoNegocios: ProdutoRepository, IProdutoNegocios
    {

        public IEnumerable<DTO.Produto> BuscarNome(string txt)
        {
            return BuscarTodos().Where(x => x.DsProduto.ToLower().Contains(txt.ToLower()));
        }
    }
}
