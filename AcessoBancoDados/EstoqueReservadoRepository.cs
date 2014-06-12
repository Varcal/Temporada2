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
    public class EstoqueReservadoRepository:Contexto, IRepository<EstoqueReservado>
    {
        public string Salvar(EstoqueReservado entidade)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("IdFilial", entidade.Filial.Pessoa.IdPessoa);
                AdicionarParametros("IdProduto", entidade.Produto.IdProduto);
                AdicionarParametros("Quantidade", entidade.Quantidade);
                var retorno = ExecComando(CommandType.StoredProcedure, "uspEstoqueManter").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Excluir(EstoqueReservado entidade)
        {
            throw new NotImplementedException();
        }

        public EstoqueReservado BuscarId(int id)
        {
            return BuscarTodos().FirstOrDefault(x => x.Filial.Pessoa.IdPessoa.Equals(id));
        }

        public IEnumerable<EstoqueReservado> BuscarTodos()
        {
            try
            {
                LimparParametros();
                var dtEstoque = ExecConsultas(CommandType.Text, "Select * from tblEstoque");
                var estoqueCollection = new EstoqueReservadoCollection();
                foreach (DataRow linha in dtEstoque.Rows)
                {
                    var estoque = new EstoqueReservado();
                    estoque.Filial.Pessoa.IdPessoa = Convert.ToInt32(linha["IdFilial"]);
                    estoque.Produto.IdProduto = Convert.ToInt32(linha["IdProduto"]);
                    estoque.Quantidade = Convert.ToInt32(linha["Quantidade"]);
                    estoqueCollection.Add(estoque);
                }
                return estoqueCollection;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
