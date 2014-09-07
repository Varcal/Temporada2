using System.Collections.Generic;
using AcessoBancoDados.Interface;
using DTO;

namespace Negocios.Interfaces
{
    public interface IProdutoNegocios: IRepository<Produto>
    {
        IEnumerable<Produto> BuscarNome(string txt);
    }
}
