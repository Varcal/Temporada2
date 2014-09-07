namespace DTO
{
    public class Estoque
    {
        public Filial Filial { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public Estoque()
        {
            Filial = new Filial();
            Produto = new Produto();
        }
    }
}
