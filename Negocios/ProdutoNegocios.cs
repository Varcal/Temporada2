using System.Collections.Generic;
using System.Linq;
using AcessoBancoDados.Repository;
using DTO;
using Negocios.Interfaces;

namespace Negocios
{
    public class ProdutoNegocios: ProdutoRepository, IProdutoNegocios
    {

        public IEnumerable<Produto> BuscarNome(string txt)
        {
            return BuscarTodos().Where(x => x.DsProduto.ToLower().Contains(txt.ToLower()));
        }
    }
}
