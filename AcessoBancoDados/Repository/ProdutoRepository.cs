using System;
using System.Collections.Generic;
using System.Data;
using AcessoBancoDados.Interface;
using DTO;

namespace AcessoBancoDados.Repository
{
    public class ProdutoRepository:Contexto, IRepository<Produto>
    {

        public string Salvar(Produto entidade)
        {
            string retorno = "";

            if (entidade.IdProduto <= 0)
            {
                retorno = Inserir(entidade);
            }
            if (entidade.IdProduto>0)
            {
                retorno = Alterar(entidade);
            }

            return retorno;
        }

        private string Inserir(Produto entidade)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("@DsProduto", entidade.DsProduto);
                string retorno = ExecComando(CommandType.StoredProcedure, "uspProdutoInserir").ToString();
                return retorno;
            }
            catch (Exception ex)
            {
                
                return ex.Message;
            }
        }

        private string Alterar(Produto entidade)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("@IdProduto", entidade.IdProduto);
                AdicionarParametros("IdProduto", entidade.DsProduto);
                string retorno = ExecComando(CommandType.StoredProcedure, "uspProdutoAlterar").ToString();
                return retorno;
            }
            catch (Exception ex)
            {
                
                return ex.Message;
            }
        }
        private string ExecComando()
        {
            throw new NotImplementedException();
        }
        public string Excluir(Produto entidade)
        {
            throw new NotImplementedException();
        }

        public Produto BuscarId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produto> BuscarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
