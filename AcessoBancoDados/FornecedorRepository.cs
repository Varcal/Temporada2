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
    public class FornecedorRepository: Contexto, IRepository<Fornecedor>
    {

        public string Salvar(Fornecedor entidade)
        {
            string retorno = "";
            if (entidade.Pessoa.IdPessoa < 0)
                retorno = Inserir(entidade);

            if (entidade.Pessoa.IdPessoa > 0)
                retorno = Alterar(entidade);

            return retorno;
        }

        private string Inserir(Fornecedor entidade)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("IdFornecedor", entidade.Pessoa.IdPessoa);
                string retorno = ExecComando(CommandType.StoredProcedure, "uspFornecedorInserir").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        private string Alterar(Fornecedor entidade)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("IdFornecedor", entidade.Pessoa.IdPessoa);
                string retorno = ExecComando(CommandType.StoredProcedure, "").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Excluir(Fornecedor entidade)
        {
            throw new NotImplementedException();
        }

        public Fornecedor BuscarId(int id)
        {
            return BuscarTodos().FirstOrDefault(x=>x.Pessoa.IdPessoa.Equals(id));
        }

        public IEnumerable<Fornecedor> BuscarTodos()
        {
             try
            {
                var dtFornecedor = ExecConsultas(CommandType.Text, "Select * tblFornecedor");
                var fornecedores = new FornecedorCollection();
                foreach (DataRow linha in dtFornecedor.Rows)
                {
                    var fornecedor = new Fornecedor();
                    fornecedor.Pessoa.IdPessoa = Convert.ToInt32("IdPessoa");
                    fornecedor.Pessoa.Nome = linha["Nome_RazaoSocial"].ToString();
                    fornecedores.Add(fornecedor);
                }

                return fornecedores;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}

