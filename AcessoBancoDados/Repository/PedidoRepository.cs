using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AcessoBancoDados.Interface;
using DTO;

namespace AcessoBancoDados.Repository
{
    public class PedidoRepository:Contexto,IRepository<Pedido>
    {
        
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

        public Pedido BuscarId(int id)
        {
            try
            {
                var pedido = BuscarTodos().FirstOrDefault(x => x.IdPedido.Equals(id));
                return pedido;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
            
        }

        public IEnumerable<Pedido> BuscarPorData(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("DtInicial", dataInicial);
                AdicionarParametros("DtFinal", dataFinal);
                var dtPedido = ExecConsultas(CommandType.StoredProcedure, "uspPedidoConsultaPorData");
                var pedidos = new PedidoCollection();
                foreach (DataRow linha in dtPedido.Rows)
                {
                    var pedido = new Pedido();
                    pedido.IdPedido = Convert.ToInt32(linha["IdPedido"]);
                    pedido.DataHora = Convert.ToDateTime(linha["DataHora"]);
                    pedido.Operacao.IdOperacao = Convert.ToInt32(linha["IdOperacao"]);
                    pedido.Operacao.DsOperacao = linha["DsOperacao"].ToString();
                    pedido.Emitente.IdPessoa = Convert.ToInt32(linha["IdPessoa"]);
                    pedido.Emitente.Nome = linha["Nome_RazaoSocial"].ToString();
                    pedido.Destinatario.IdPessoa = Convert.ToInt32(linha["IdPessoa"]);
                    pedido.Destinatario.Nome = linha["Nome_RazaoSocial"].ToString();
                    pedido.Operacao.IdOperacao = Convert.ToInt32(linha["IdOperacao"]);
                    pedido.Operacao.DsOperacao = linha["DsOperacao"].ToString();
                    pedido.Situacao.IdSituacao = Convert.ToInt32(linha["IdSituacao"]);
                    pedido.Situacao.DsSituacao = linha["DsSituacao"].ToString();
                    pedidos.Add(pedido);
                }
                return pedidos;
            }
            catch (Exception ex)
            {              
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Pedido> BuscarTodos()
        {
            try
            {
                var dtPedidos = ExecConsultas(CommandType.Text, "Select * from tblPedido");
                var pedidos = new PedidoCollection(); 
                foreach (DataRow linha in dtPedidos.Rows)
                {
                    var pedido = new Pedido();
                    pedido.IdPedido = Convert.ToInt32(linha);
                    pedido.Operacao.IdOperacao = Convert.ToInt32(linha);
                    pedido.Situacao.IdSituacao = Convert.ToInt32(linha);
                    pedido.Emitente.IdPessoa = Convert.ToInt32(linha);
                    pedido.Destinatario.IdPessoa = Convert.ToInt32(linha);
                    pedido.DataHora = Convert.ToDateTime(linha);
                    pedidos.Add(pedido);
                }
                return pedidos;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
