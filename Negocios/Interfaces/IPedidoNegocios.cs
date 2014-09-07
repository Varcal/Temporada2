using System.Collections.Generic;
using AcessoBancoDados.Interface;
using DTO;

namespace Negocios.Interfaces
{
    public interface IPedidoNegocios:IRepository<Pedido>
    {
        IEnumerable<Pedido> BuscarAtivos();
    }
}
