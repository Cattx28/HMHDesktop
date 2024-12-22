﻿using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class UsuarioRepository
    {

        public string Insert(Usuario usuario)
        {
            string resp = "";

            try
            {

                Conexao.getConnection();

                string insertSql = "INSERT INTO Usuario " +
                                    "(nome, idade, email, senha) " +
                                    "VALUES (@pNome, @pIdade, @pEmail, @pSenha)";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(insertSql, Conexao.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pNome", usuario.nome);
                SqlCmd.Parameters.AddWithValue("@pIdade", usuario.idade);
                SqlCmd.Parameters.AddWithValue("@pEmail", usuario.email);
                SqlCmd.Parameters.AddWithValue("@pSenha", usuario.senha);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";

            } catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                Conexao.closeConnection();
            }

            return resp;
        }

        public string Update(Usuario usuario)
        {
            string resp = "";
            try
            {
                Conexao.getConnection();

                string updateSql = "UPDATE Usuario SET " +
                                    "nome = @pNome, idade = @pIdade, email = @pEmail, senha = @pSenha " +
                                    "WHERE idUsuario = @pId";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(updateSql, Conexao.SqlCon);
                
                SqlCmd.Parameters.AddWithValue("@pId", usuario.id);
                SqlCmd.Parameters.AddWithValue("@pNome", usuario.nome);
                SqlCmd.Parameters.AddWithValue("@pIdade", usuario.idade);
                SqlCmd.Parameters.AddWithValue("@pEmail", usuario.email);
                SqlCmd.Parameters.AddWithValue("@pSenha", usuario.senha);

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

        public string Inativar(int idUsuario)
        {
            string resp = " ";

            try
            {
                Conexao.getConnection();

                string inativeSql = "UPDATE Usuario SET " +
                                    "ativo = 0 " +
                                    "WHERE idUsuario = @pId";
                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(inativeSql, Conexao.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pId", idUsuario);

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
        public string Delete(int idUsuario)
        {
            string resp = " ";
            
            try
            {
                Conexao.getConnection();

                string deleteSql = "DELETE FROM Usuario " +
                                    "WHERE idUsuario = @pId ";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(deleteSql, Conexao.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pId", idUsuario);

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
            DataTable DtResultado = new DataTable("usuario");
            try
            {
                Conexao.getConnection();
                String selectSql = "SELECT * from Usuario " +
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

        public DataTable filterById(int? pId)
        {
            DataTable DtResultado = new DataTable("usuario");
            string selectSql;
            try
            {
                Conexao.getConnection();
                if (pId != null)
                {
                    selectSql = "SELECT * FROM Usuario "+
                                "WHERE idUsuario = @pId";
                }
                else
                {
                    selectSql = "SELECT * FROM Usuario";
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

        public DataTable getAllInativos()
        {
            DataTable DtResultado = new DataTable("usuario");
            try
            {
                Conexao.getConnection();
                String selectSql = "SELECT * from Usuario " +
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
    }
}
