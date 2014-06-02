using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados.Interface;
using DTO;

namespace AcessoBancoDados
{
    public class PedidoRepository:AcessoSqlServer,IRepository<Pedido>
    {
        PedidoCollection pedidoCollection = new PedidoCollection();
        public string Salvar(Pedido entidade)
        {
            string retorno = "";
            if (entidade.IdPedido > 0)
               retorno = Alterar(entidade);
            if (entidade.IdPedido <= 0)
               retorno = Inserir(entidade);

            return retorno;
        }

        private string Inserir(Pedido entidade)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("@IdOperacao", entidade.Operacao.IdOperacao);
                AdicionarParametros("@IdSituacao", entidade.Situacao.IdSituacao);
                AdicionarParametros("@IdEmitente", entidade.Emitente.IdPessoa);
                AdicionarParametros("@Destinatario", entidade.Destinatario.IdPessoa);
                string retorno = ExecComando(CommandType.StoredProcedure, "uspPedidoInserir").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
           
        }

        private string Alterar(Pedido entidade)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("@IdPedido",entidade.IdPedido);
                AdicionarParametros("@IdOperacao", entidade.Operacao.IdOperacao);
                AdicionarParametros("@IdSituacao", entidade.Situacao.IdSituacao);
                AdicionarParametros("@IdEmitente", entidade.Emitente.IdPessoa);
                AdicionarParametros("@Destinatario", entidade.Destinatario.IdPessoa);
                string retorno = ExecComando(CommandType.StoredProcedure, "uspPedidoAlterar").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Excluir(Pedido entidade)
        {
            throw new NotImplementedException();
        }

        public IList<Pedido> BuscarId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Pedido> BuscarNome(string arg)
        {
            throw new NotImplementedException();
        }

        public IList<Pedido> BuscarTodos()
        {
            
            var pedidos = ExecConsultas(CommandType.Text, "Select * from tblPedido");
            foreach (DataRow linha in pedidos.Rows)
            {
                var pedido = new Pedido();
                pedido.IdPedido = Convert.ToInt32(linha["IdPedido"]);
                pedido.Operacao.IdOperacao = Convert.ToInt32(linha["IdOperacao"]);
                pedido.Situacao.IdSituacao = Convert.ToInt32(linha["IdSitucao"]);
                pedido.Emitente.IdPessoa = Convert.ToInt32(linha["IdEmitente"]);
                pedido.Destinatario.IdPessoa = Convert.ToInt32(linha["IdDestinatario"]);
                pedido.DataHora = Convert.ToDateTime(linha["DataHora"]);
                pedidoCollection.Add(pedido);
            }
            return pedidoCollection;
        }
    }
}
