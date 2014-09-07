using System.Collections.Generic;
using System.Linq;
using AcessoBancoDados.Repository;
using DTO;
using Negocios.Interfaces;

namespace Negocios
{
    public class PedidoNegocios:PedidoRepository,IPedidoNegocios
    {     
        public IEnumerable<Pedido> BuscarAtivos()
        {
            return BuscarTodos().Where(x => x.Situacao.IdSituacao.Equals(1));
        }        
    }
}
