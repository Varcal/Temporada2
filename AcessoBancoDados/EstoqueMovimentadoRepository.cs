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
    public class EstoqueMovimentadoRepository:Contexto, IRepository<EstoqueMovimentado>
    {
        public string Salvar(EstoqueMovimentado entidade)
        {
           string retorno = Inserir(entidade);
            return retorno;
        }

        private string Inserir(EstoqueMovimentado entidade)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("@IdFilial", entidade.Filial.Pessoa.IdPessoa);
                AdicionarParametros("@IdProduto", entidade.Produto.IdProduto);
                AdicionarParametros("Quantidade", entidade.Quantidade);
                AdicionarParametros("EntradaSaida", entidade.EntradaSaida);
                string retorno = ExecComando(CommandType.StoredProcedure, "uspEstoqueManter").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }


        public string Excluir(EstoqueMovimentado entidade)
        {
            throw new NotImplementedException();
        }

        public EstoqueMovimentado BuscarId(int id)
        {
            return BuscarTodos().FirstOrDefault(x => x.Filial.Pessoa.IdPessoa.Equals(id));
        }

        public IEnumerable<EstoqueMovimentado> BuscarTodos()
        {
            try
            {
                var dtEstoqueMovimentado = ExecConsultas(CommandType.Text, "Select * from tblEstoqueMovimentado");
                var estoqueMovimentadoCollection = new EstoqueMovimentadoCollection();
                foreach (DataRow linha in dtEstoqueMovimentado.Rows)
                {
                    var estoqueMovimentado = new EstoqueMovimentado();
                    estoqueMovimentado.Filial.Pessoa.IdPessoa = Convert.ToInt32(linha["IdFilial"]);
                    estoqueMovimentado.Produto.IdProduto = Convert.ToInt32(linha["IdProduto"]);
                    estoqueMovimentado.Quantidade = Convert.ToInt32(linha["Quantidade"]);
                    estoqueMovimentado.DataHora = Convert.ToDateTime(linha["DataHora"]);
                    estoqueMovimentado.EntradaSaida = linha["EntradaSaida"].ToString();
                    estoqueMovimentadoCollection.Add(estoqueMovimentado);
                }
                return estoqueMovimentadoCollection;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
           
        }
    }
}
