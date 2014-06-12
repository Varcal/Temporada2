using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados.Interface;
using DTO;

namespace AcessoBancoDados
{
    public class PessoaJuridicaRepository: Contexto, IRepository<PessoaJuridica>
    {
        public string Salvar(PessoaJuridica entidade)
        {
            string retorno = "";

            if (entidade.IdPessoaJuridica < 0)
                retorno = Inserir(entidade);

            if (entidade.IdPessoaJuridica > 0)
                retorno = Alterar(entidade);

            return retorno;
        }

        private string Inserir(PessoaJuridica entidade)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("RazaoSocial", entidade.RazaoSocial);
                AdicionarParametros("Cnpj", entidade.Cnpj);
                AdicionarParametros("InscEst", entidade.InscEst);
                AdicionarParametros("DtAbertura", entidade.DtAbertura);
                string retorno = ExecComando(CommandType.StoredProcedure, "uspPessoaJuridicaInserir").ToString();
                return retorno;
            }
            catch (Exception ex)
            {
                
                return ex.Message;
            }
        }

        private string Alterar(PessoaJuridica entidade)
        {
            try
            {
                LimparParametros();
                AdicionarParametros("IdPessoaJuridica", entidade.IdPessoaJuridica);
                AdicionarParametros("RazaoSocial", entidade.RazaoSocial);
                AdicionarParametros("Cnpj", entidade.Cnpj);
                AdicionarParametros("InscEst", entidade.InscEst);
                AdicionarParametros("DtAbertura", entidade.DtAbertura);
                string retorno = ExecComando(CommandType.StoredProcedure, "uspPessoaJuridicaInserir").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Excluir(PessoaJuridica entidade)
        {
            throw new NotImplementedException();
        }

        public PessoaJuridica BuscarId(int id)
        {
            return BuscarTodos().FirstOrDefault(x => x.IdPessoaJuridica.Equals(id));
        }

        public IEnumerable<PessoaJuridica> BuscarTodos()
        {
            try
            {
                var dtPj = ExecConsultas(CommandType.Text, "Select * from tblPessoaJuridica");
                var pjCollection = new PessoaJuridicaCollection();
                foreach (DataRow linha in dtPj.Rows)
                {
                    var pj = new PessoaJuridica();
                    pj.IdPessoaJuridica = Convert.ToInt32(linha["IdPessoaJuridica"]);
                    pj.RazaoSocial = linha["RazaoSocial"].ToString();
                    pj.Cnpj = linha["Cnpj"].ToString();
                    pj.InscEst = linha["InscEst"].ToString();
                    pj.DtAbertura = Convert.ToDateTime(linha["DtAbertura"]);
                    pjCollection.Add(pj);
                }
                return pjCollection;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
