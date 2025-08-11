using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.ConstrainedExecution;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace Dados
{
    public class ModeradorRepository
    {
        public string Insert(Moderador moderador)
        {
            string resp = "";

            try
            {

                Conexao.getConnection();

                string insertSql = "INSERT INTO Moderador " +
                                    "(nome, email, senha) " +
                                    "VALUES (@pNome, @pEmail, @pSenha)";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(insertSql, Conexao.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pNome", moderador.nome);
                SqlCmd.Parameters.AddWithValue("@pEmail", moderador.email);
                SqlCmd.Parameters.AddWithValue("@pSenha", moderador.senha);

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

        public string Update(Moderador moderador)
        {
            string resp = "";
            try
            {
                Conexao.getConnection();

                string updateSql = "UPDATE Moderador SET " +
                                    "nome = @pNome, email = @pEmail " +
                                    "WHERE idModerador = @pId ";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(updateSql, Conexao.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pId", moderador.id);
                SqlCmd.Parameters.AddWithValue("@pNome", moderador.nome);
                SqlCmd.Parameters.AddWithValue("@pEmail", moderador.email);

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

        public string Delete(int idModerador)
        {
            string resp = " ";

            try
            {
                Conexao.getConnection();

                string deleteSql = "DELETE FROM Moderador " +
                                    "WHERE idModerador = @pId ";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(deleteSql, Conexao.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pId", idModerador);

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
            DataTable DtResultado = new DataTable("moderador");
            try
            {
                Conexao.getConnection();
                String selectSql = "SELECT * from Moderador";

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

        public DataTable getAllModerador()
        {
            DataTable DtResultado = new DataTable("mod");
            try
            {
                Conexao.getConnection();
                String selectSql = "SELECT * from Moderador " +
                                    "WHERE adm = 0";

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

        public DataTable getAllAdm()
        {
            DataTable DtResultado = new DataTable("adm");
            try
            {
                Conexao.getConnection();
                String selectSql = "SELECT * from Moderador " +
                                    "WHERE adm = 1";

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

        public string TornarAdm(int idModerador)
        {
            string resp = " ";

            try
            {
                Conexao.getConnection();

                string inativeSql = "UPDATE Moderador SET " +
                                    "adm = 1 " +
                                    "WHERE idModerador = @pId";
                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(inativeSql, Conexao.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pId", idModerador);

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

        public DataTable filterById(int? pId)
        {
            DataTable DtResultado = new DataTable("moderador");
            string selectSql;
            try
            {
                Conexao.getConnection();
                if (pId != null)
                {
                    selectSql = "SELECT * FROM Moderador " +
                                "WHERE idModerador = @pId";
                }
                else
                {
                    selectSql = "SELECT * FROM Moderador";
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

        public bool login(string login, string senha)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
            {
                return false;
            }

            try
            {
                Conexao.getConnection();
                {
                    // Busca apenas o hash armazenado
                    string sql = "SELECT senha FROM Moderador WHERE nome = @pLogin OR email = @pLogin";

                    string senhaHash = null;

                    using (var cmd = new MySqlCommand(sql, Conexao.SqlCon))
                    {
                        cmd.Parameters.AddWithValue("@pLogin", login);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                senhaHash = reader.GetString("senha");
                            }
                        }
                    }

                    // Verifica se encontrou o usuário e se a senha está correta
                    return senhaHash != null && PasswordHasher.VerifyPassword(senha, senhaHash);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro no login: " + ex.Message);
                return false;
            }
        }

        public bool adm(int adm)
        {
            if (adm == 0) { return false; }
            return true;
        }
    }
}
