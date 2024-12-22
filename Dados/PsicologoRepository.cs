using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class PsicologoRepository
    {
        public string Insert(Psicologo psicologo)
        {
            string resp = "";

            try
            {

                Conexao.getConnection();

                string insertSql = "INSERT INTO Psicologo " +
                                    "(nome, cpf, regiao, cidade, email, senha) " +
                                    "VALUES (@pNome, @pCpf, @pRegiao, @pCidade, @pEmail, @pSenha)";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(insertSql, Conexao.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pNome", psicologo.nome);
                SqlCmd.Parameters.AddWithValue("@pCpf", psicologo.cpf);
                SqlCmd.Parameters.AddWithValue("@pRegiao", psicologo.regiao);
                SqlCmd.Parameters.AddWithValue("@pCidade", psicologo.cidade);
                SqlCmd.Parameters.AddWithValue("@pEmail", psicologo.email);
                SqlCmd.Parameters.AddWithValue("@pSenha", psicologo.senha);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                Conexao.closeConnection();
            }

            return resp;
        }

        public string Update(Psicologo psicologo)
        {
            string resp = "";
            try
            {
                Conexao.getConnection();

                string updateSql = "UPDATE Psicologo SET " +
                                    "nome = @pNome, cpf = @pCpf, regiao = @pRegiao, cidade = @pCidade, email = @pEmail, senha = @pSenha " +
                                    "WHERE idPsicologo = @pId";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(updateSql, Conexao.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pId", psicologo.id);
                SqlCmd.Parameters.AddWithValue("@pNome", psicologo.nome);
                SqlCmd.Parameters.AddWithValue("@pCpf", psicologo.cpf);
                SqlCmd.Parameters.AddWithValue("@pRegiao", psicologo.regiao);
                SqlCmd.Parameters.AddWithValue("@pCidade", psicologo.cidade);
                SqlCmd.Parameters.AddWithValue("@pEmail", psicologo.email);
                SqlCmd.Parameters.AddWithValue("@pSenha", psicologo.senha);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                Conexao.closeConnection();
            }
            return resp;
        }

        public string Delete(int idPsicologo)
        {
            string resp = " ";

            try
            {
                Conexao.getConnection();

                string deleteSql = "DELETE FROM Psicologo " +
                                    "WHERE idPsicologo = @pId ";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(deleteSql, Conexao.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pId", idPsicologo);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                Conexao.closeConnection();
            }
            return resp;
        }

        public string Inativar(int idPsicologo)
        {
            string resp = " ";

            try
            {
                Conexao.getConnection();

                string inativeSql = "UPDATE Psicologo SET " +
                                    "ativo = 0 " +
                                    "WHERE idPsicologo = @pId";
                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(inativeSql, Conexao.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pId", idPsicologo);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                Conexao.closeConnection();
            }
            return resp;
        }

        public DataTable getAll()
        {
            DataTable DtResultado = new DataTable("psicologo");
            try
            {
                Conexao.getConnection();
                String selectSql = "SELECT * from Psicologo " +
                                    "WHERE ativo = 1";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(selectSql, Conexao.SqlCon);

                MySql.Data.MySqlClient.MySqlDataAdapter SqlData = new MySql.Data.MySqlClient.MySqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                Conexao.closeConnection();
            }
            return DtResultado;
        }

        public DataTable getAllInativos()
        {
            DataTable DtResultado = new DataTable("psicologo");
            try
            {
                Conexao.getConnection();
                String selectSql = "SELECT * from Psicologo " +
                                    "WHERE ativo = 0";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(selectSql, Conexao.SqlCon);

                MySql.Data.MySqlClient.MySqlDataAdapter SqlData = new MySql.Data.MySqlClient.MySqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                Conexao.closeConnection();
            }
            return DtResultado;
        }

        public DataTable filterById(int? pId)
        {
            DataTable DtResultado = new DataTable("psicologo");
            string selectSql;
            try
            {
                Conexao.getConnection();
                if (pId != null)
                {
                    selectSql = "SELECT * FROM Psicologo " +
                                "WHERE idPsicologo = @pId";
                }
                else
                {
                    selectSql = "SELECT * FROM Psicologo";
                }

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(selectSql, Conexao.SqlCon);

                if (pId != null)
                    SqlCmd.Parameters.AddWithValue("@pId", pId);

                MySql.Data.MySqlClient.MySqlDataAdapter SqlData = new MySql.Data.MySqlClient.MySqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                Conexao.closeConnection();
            }
            return DtResultado;
        }
    }
}
