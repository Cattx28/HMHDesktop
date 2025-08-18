﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class LogsRepository
    {
        public string CriarLog(Logs log)
       {
            string resp = " ";

            try
            {
                Conexao.getConnection();

                string insertSql = "INSERT INTO Logs (moderador, acao, comentario) " +
                         "VALUES (@pModerador, @pAcao, @pComentario)";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(insertSql, Conexao.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pModerador", log.idModerador);
                SqlCmd.Parameters.AddWithValue("@pAcao", log.acao);
                SqlCmd.Parameters.AddWithValue("@pComentario", log.comentario);

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
            DataTable DtResultado = new DataTable("Logs");
            try
            {
                Conexao.getConnection();

                if (Conexao.SqlCon.State != ConnectionState.Open)
                {
                    throw new InvalidOperationException("A conexão com o banco de dados não está aberta.");
                }

                String selectSql = "SELECT * from Logs ORDER BY idLogs DESC";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(selectSql, Conexao.SqlCon);

                MySql.Data.MySqlClient.MySqlDataAdapter SqlData = new MySql.Data.MySqlClient.MySqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                Console.WriteLine("Erro no dt: " + ex.Message);
            }
            finally
            {
                Conexao.closeConnection();
            }
            return DtResultado;
        }
    }
}
