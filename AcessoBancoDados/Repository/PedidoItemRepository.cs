using System;
using System.Collections.Generic;
using System.Data;
using AcessoBancoDados.Interface;
using DTO;

namespace AcessoBancoDados.Repository
{
    public class PedidoItemRepository:Contexto,IRepository<PedidoItem>
    {

        public string Salvar(PedidoItem entidade)
        {

            return null;
        }


        private string Inserir(PedidoItem entidade)
        {

            try
            {
                LimparParametros();
                AdicionarParametros("@IdPedido", entidade.Pedido.IdPedido);
                AdicionarParametros("@IdProduto", entidade.Produto.IdProduto);
                AdicionarParametros("@Quantidade", entidade.Quantidade);
                AdicionarParametros("@ValorUnit", entidade.ValorUnit);
                AdicionarParametros("@PercDesconto", entidade.PercDesconto);
                AdicionarParametros("@ValorDesc", entidade.ValorDesc);
                AdicionarParametros("@ValorTotal", entidade.ValorTotal);
                string retorno = ExecComando(CommandType.StoredProcedure, "uspPedidoItemInserir").ToString();
                return retorno;
            }
            catch (Exception ex)
            {
                
                return ex.Message;
            }
           
        }

        private string Alterar(PedidoItem entidade)
        {

            return null;
        }

        public string Excluir(PedidoItem entidade)
        {
            throw new NotImplementedException();
        }

        public PedidoItem BuscarId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PedidoItem> BuscarTodos()
        {
            try
            {
                LimparParametros();
                var itensCollection = new PedidoItemCollection();
                var dtItem = ExecConsultas(CommandType.Text, "Select * from tblPedidoItem");
                foreach (DataRow linha in dtItem.Rows)
                {
                    var item = new PedidoItem();
                    item.Produto.IdProduto = Convert.ToInt32(linha["IdProduto"]);
                    item.Pedido.IdPedido = Convert.ToInt32("IdPedido");
                    item.Quantidade = Convert.ToInt32("Quantidade");
                    item.ValorUnit = Convert.ToDecimal("ValorUnit");
                    item.PercDesconto = Convert.ToDecimal("PercDesconto");
                    item.ValorDesc = Convert.ToDecimal("ValorDesc");
                    item.ValorTotal = Convert.ToDecimal("ValorTotal");
                    itensCollection.Add(item);
                }

                return itensCollection;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
           
        }
    }
}
