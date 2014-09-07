using System.Collections.Generic;
using AcessoBancoDados.Interface;
using DTO;

namespace Negocios.Interfaces
{
    public interface IClienteNegocios: IRepository<Cliente>
    {
        IEnumerable<Cliente> BuscarTodosAtivos();
        IEnumerable<Cliente> BuscarPorNome(string txt);
    }
}
