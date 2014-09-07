using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AcessoBancoDados.Interface;
using DTO;

namespace AcessoBancoDados.Repository
{
    public class FilialRepository: Contexto, IRepository<Filial>
    {
        public string Salvar(Filial entidade)
        {
            string retorno = "";
            if (entidade.Pessoa.IdPessoa < 0)
                retorno = Inserir(entidade);

            if (entidade.Pessoa.IdPessoa > 0)
                retorno = Alterar(entidade);

            return retorno;
        }

        private string Inserir(Filial entidade)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("IdCliente", entidade.Pessoa.IdPessoa);
                string retorno = ExecComando(CommandType.StoredProcedure, "uspClienteInserir").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        private string Alterar(Filial entidade)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("IdFilial", entidade.Pessoa.IdPessoa);
                string retorno = ExecComando(CommandType.StoredProcedure, "").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }


        public string Excluir(Filial entidade)
        {
            throw new NotImplementedException();
        }

        public Filial BuscarId(int id)
        {
            return BuscarTodos().FirstOrDefault(x=>x.Pessoa.IdPessoa.Equals(id));
        }

        public IEnumerable<Filial> BuscarTodos()
        {
            try
            {
                var dtFilial = ExecConsultas(CommandType.Text, "Select * tblFilial");
                var filiais = new FilialCollection();
                foreach (DataRow linha in dtFilial.Rows)
                {
                    var filial = new Filial();
                    filial.Pessoa.IdPessoa = Convert.ToInt32("IdPessoa");
                    filial.Pessoa.Nome = linha["Nome_RazaoSocial"].ToString();
                    filiais.Add(filial);
                }

                return filiais;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
