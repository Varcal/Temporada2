using System.Collections.Generic;
using System.Linq;
using AcessoBancoDados.Repository;
using DTO;
using Negocios.Interfaces;

namespace Negocios
{
    public class ClienteNegocios: ClienteRepository, IClienteNegocios
    {

        public IEnumerable<Cliente> BuscarTodosAtivos()
        {
            return BuscarTodos().Where(x => x.Pessoa.Ativo);
        }

        public IEnumerable<Cliente> BuscarPorNome(string txt)
        {
            return BuscarTodos().Where(x => x.Pessoa.Nome.ToLower().Contains(txt));
        }
    }
}
