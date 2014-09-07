using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AcessoBancoDados.Interface;
using DTO;

namespace AcessoBancoDados.Repository
{
    public class EstoqueRepository:Contexto, IRepository<Estoque>
    {

        public string Salvar(Estoque entidade)
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

        public string Excluir(Estoque entidade)
        {
            throw new NotImplementedException();
        }

        public Estoque BuscarId(int id)
        {
            return BuscarTodos().FirstOrDefault(x=>x.Filial.Pessoa.IdPessoa.Equals(id));
        }

        public IEnumerable<Estoque> BuscarTodos()
        {
            try
            {
                LimparParametros();
                var dtEstoque = ExecConsultas(CommandType.Text, "Select * from tblEstoque");
                var estoqueCollection = new EstoqueCollection();
                foreach (DataRow linha in dtEstoque.Rows)
                {
                    var estoque = new Estoque();
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
