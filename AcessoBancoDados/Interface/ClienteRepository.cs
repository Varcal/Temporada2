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
    public class ClienteRepository: Contexto, IRepository<Cliente>
    {

        public string Salvar(Cliente entidade)
        {
            string retorno = "";
            if (entidade.Pesssoa.IdPessoa < 0)
                retorno = Inserir(entidade);

            if (entidade.Pesssoa.IdPessoa > 0)
                retorno = Alterar(entidade);

            return retorno;
        }

        private string Inserir(Cliente entidade)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("IdCliente", entidade.Pesssoa.IdPessoa);
                string retorno = ExecComando(CommandType.StoredProcedure, "uspClienteInserir").ToString();
                return retorno;
            }
            catch (Exception ex)
            {
                
                return ex.Message;
            }
        }

        private string Alterar(Cliente entidade)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("IdCliente", entidade.Pesssoa.IdPessoa);
                string retorno = ExecComando(CommandType.StoredProcedure, "uspClienteInserir").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Excluir(Cliente entidade)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarId(int id)
        {
            return BuscarTodos().FirstOrDefault(x => x.Pesssoa.IdPessoa.Equals(id));
        }

        public IEnumerable<Cliente> BuscarTodos()
        {
            try
            {
                var dtClientes = ExecConsultas(CommandType.Text, "Select * uvwPessoaFisicaJuridica");
                var clientes = new ClienteCollection();
                foreach (DataRow linha in dtClientes.Rows )
                {
                    var cliente = new Cliente();
                    cliente.Pesssoa.IdPessoa = Convert.ToInt32("IdPessoa");
                    cliente.Pesssoa.Nome = linha["Nome_RazaoSocial"].ToString();
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
