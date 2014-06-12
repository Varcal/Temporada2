using AcessoBancoDados.Properties;
using System;
using System.Data;
using System.Data.SqlClient;

namespace AcessoBancoDados
{
    public class Contexto
    {


        private SqlConnection _con;
        private SqlConnection CriarConexao()
        {
            _con = new SqlConnection(Settings.Default.strConexao);
            return _con;
        }

        private readonly SqlParameterCollection _sqlParameterCollection = new SqlCommand().Parameters;

        private SqlCommand CriarComando(CommandType cmdType, string cmdSql)
        {
            try
            {
                _con = CriarConexao();
                _con.Open();
                SqlCommand cmd = _con.CreateCommand();
                cmd.CommandType = cmdType;
                cmd.CommandText = cmdSql;
                cmd.CommandTimeout = 7200;
                foreach (SqlParameter sqlParameter in _sqlParameterCollection)
                {
                    cmd.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                return cmd;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        protected void LimparParametros()
        {
            _sqlParameterCollection.Clear();
        }

        protected void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            _sqlParameterCollection.AddWithValue(nomeParametro, valorParametro);
        }

        protected object ExecComando(CommandType cmdType, string cmdSql)
        {
            try
            {
                SqlCommand cmd = CriarComando(cmdType, cmdSql);
                return cmd.ExecuteScalar();
            }
            catch(Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                _con.Close();
            }
        }

        protected DataTable ExecConsultas(CommandType cmdType, string cmdSql)
        {
            try
            {
                SqlCommand cmd = CriarComando(cmdType, cmdSql);
                var dt = new DataTable();
                var sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                _con.Close();
            }
        }
    }
}
