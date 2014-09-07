using System.Collections.Generic;
using AcessoBancoDados.Interface;
using DTO;

namespace Negocios.Interfaces
{
    public interface IFornecedorNegocios: IRepository<Fornecedor>
    {
        IEnumerable<Fornecedor> BuscarPorNome (string nome);
    }
}
