using System;

namespace DTO
{
    public class Pedido
    {      
        public int IdPedido { get; set; }
        public DateTime DataHora { get; set; }
        public Operacao Operacao { get; set; }
        public Situacao Situacao { get; set; }
        public Pessoa Emitente { get; set; }
        public Pessoa Destinatario { get; set; }


        public Pedido()
        {
            Operacao = new Operacao();
            Situacao = new Situacao();
            Emitente = new Pessoa();
            Destinatario = new Pessoa();
        }

    }
}
