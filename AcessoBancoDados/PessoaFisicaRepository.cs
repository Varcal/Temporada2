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
    public class PessoaFisicaRepository: Contexto, IRepository<PessoaFisica>
    {
        public string Salvar(PessoaFisica entidade)
        {
            string retorno = "";
            if (entidade.IdPessoaFisica <= 0)
                retorno = Inserir(entidade);
            if (entidade.IdPessoaFisica > 0)
                retorno = Alterar(entidade);

            return retorno;
        }

        private string Inserir(PessoaFisica entidade)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("@Nome", entidade.Nome);
                AdicionarParametros("@Cpf", entidade.Cpf);
                AdicionarParametros("@Rg", entidade.Rg);
                AdicionarParametros("@DtNascimento",entidade.DtNascimento);
                string retorno = ExecComando(CommandType.StoredProcedure, "uspPessoaFisicaInserir").ToString();
                return retorno;
            }
            catch (Exception ex)
            {
                
                return  ex.Message;
            }
        }

        private string Alterar(PessoaFisica entidade)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("@IdPessoaFisica",entidade.IdPessoaFisica);
                AdicionarParametros("@Nome", entidade.Nome);
                AdicionarParametros("@Cpf", entidade.Cpf);
                AdicionarParametros("@Rg", entidade.Rg);
                AdicionarParametros("@DtNascimento", entidade.DtNascimento);
                string retorno = ExecComando(CommandType.StoredProcedure, "uspPessoaFisicaAlterar").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Excluir(PessoaFisica entidade)
        {
            throw new NotImplementedException();
        }

        public PessoaFisica BuscarId(int id)
        {
            return BuscarTodos().FirstOrDefault(x => x.IdPessoaFisica.Equals(id));
        }

        public IEnumerable<PessoaFisica> BuscarTodos()
        {
            try
            {
                var dtPf = ExecConsultas(CommandType.Text, "Select * from tblPessoaFisica");
                var pfCollection = new PessoaFisicaCollection();
                foreach (DataRow linha in dtPf.Rows)
                {
                    var pf = new PessoaFisica();
                    pf.IdPessoaFisica = Convert.ToInt32(linha["IdPessoaFisica"]);
                    pf.Nome = linha["Nome"].ToString();
                    pf.Cpf = linha["Cpf"].ToString();
                    pf.Rg = linha["Rg"].ToString();
                    pf.DtNascimento = Convert.ToDateTime(linha["DtNascimento"]);
                    pfCollection.Add(pf);
                }
                return pfCollection;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }
    }
}
