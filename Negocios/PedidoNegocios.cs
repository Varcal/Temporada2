using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados.Interface;
using DTO;
using AcessoBancoDados;

namespace Negocios
{
    public class PedidoNegocios
    {
        private readonly IRepository<Pedido> _repository = new PedidoRepository();  
        public string Salvar(Pedido pedido)
        {
            string idPedido = _repository.Salvar(pedido);
            return idPedido;
        }

        public string Excluir(Pedido pedido)
        {
            string idPedido = _repository.Excluir(pedido);
            return idPedido;
        }

        public PedidoCollection BuscarId(int id)
        {
            var pedido = (PedidoCollection) _repository.BuscarId(id);
            return pedido;
        }

        public PedidoCollection BuscarNome(string nome)
        {
            var pedidos = (PedidoCollection) _repository.BuscarNome(nome);
            return pedidos;
        }

        public PedidoCollection BuscarTodos()
        {
            var pedidos = (PedidoCollection) _repository.BuscarTodos();
            return pedidos;
        }
    }
}
