namespace DTO
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public PessoaTipo PessoaTipo { get; set; }
        public bool Ativo { get; set; }

        public Pessoa()
        {
            PessoaTipo = new PessoaTipo();
        }
    }
}
