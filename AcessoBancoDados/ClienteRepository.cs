using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados.Interface;
using DTO;

namespace AcessoBancoDados
{
    public class ClienteRepository:Contexto, IRepository<Cliente>
    {
        public string Salvar(Cliente entidade)
        {
            var retorno = "";

            var cliente = BuscarId(entidade.Pessoa.IdPessoa);
            

            if (cliente == null)
            {
                retorno = Inserir(entidade);
            }
            else
            {
                retorno = Alterar(entidade);
            }

            return retorno;
        }

        private string Inserir(Cliente entidade)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("@IdCliente", entidade.Pessoa.IdPessoa);
                string retorno = ExecComando(CommandType.StoredProcedure, "uspClienteInserir").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        private string Alterar (Cliente entidade)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("@IdCliente", entidade.Pessoa.IdPessoa);
                string retorno = ExecComando(CommandType.StoredProcedure, "").ToString();
                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw;
            }
        }
   
        public string Excluir(Cliente entidade)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarId(int id)
        {
            return BuscarTodos().FirstOrDefault(x => x.Pessoa.IdPessoa.Equals(id));
        }

        public IEnumerable<Cliente> BuscarTodos()
        {
            try
            {
                var clientes = new ClienteCollection();
                var dtcliente = ExecConsultas(CommandType.StoredProcedure, "uspClienteBuscarTodos");
                foreach (DataRow linha in dtcliente.Rows)
                {
                    var cliente = new Cliente();
                    cliente.Pessoa.IdPessoa = Convert.ToInt32(linha["IdPessoa"]);
                    cliente.Pessoa.Nome = linha["Nome_RazaoSocial"].ToString();
                    cliente.Pessoa.PessoaTipo.IdPessoaTipo = Convert.ToInt32(linha["IdPessoaTipo"]);
                    cliente.Pessoa.PessoaTipo.DsPessoaTipo = linha["DsPessoaTipo"].ToString();
                    cliente.Pessoa.Ativo = Convert.ToBoolean(linha["Ativo"]);
                    clientes.Add(cliente);
                }

                return clientes;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
            
        }
    }
}
