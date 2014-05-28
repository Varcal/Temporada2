using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PedidoItem
    {
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnit { get; set; }
        public decimal PercDesconto { get; set; }
        public decimal ValorDesc { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
