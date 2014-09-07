using System;

namespace DTO
{
    public class EstoqueMovimentado
    {
        public Filial Filial { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataHora { get; set; }
        public string EntradaSaida { get; set; }

    }
}
