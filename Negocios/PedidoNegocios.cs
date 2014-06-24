using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados.Interface;
using DTO;
using AcessoBancoDados;
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
