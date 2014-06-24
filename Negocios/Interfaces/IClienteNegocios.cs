using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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
