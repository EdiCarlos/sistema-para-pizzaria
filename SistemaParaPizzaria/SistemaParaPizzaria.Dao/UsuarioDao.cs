using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace SistemaParaPizzaria
{
    class UsuarioDao
    {
        Conexao bd;

        public UsuarioDao()
        {
            bd = new Conexao();
        }

        /// <summary>
        /// Incluir novo usuário.
        /// </summary>
        /// <param name="usuario">Usuario</param>
        public void IncluiUsuario(Usuario usuario)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "INSERT INTO usuario(nome,userName,funcao,senha,tipo) "
                               + "values (@Nome,@UserName,@Funcao,@Senha,@Tipo)";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@UserName", usuario.UserName);
                cmd.Parameters.AddWithValue("@Funcao", usuario.Funcao);
                cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@Tipo", usuario.Tipo);

                cmd.ExecuteNonQuery();
                MessageBox.Show(Mensagem.GetMensagemConfirmacao(), Mensagem.GetMensagemTitulo("Confirmação do Sistema"));
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }


        /// <summary>
        /// Altera usuário cadastrado.
        /// </summary>
        /// <param name="usuario">Usuario</param>
        public void AlteraUsuario(Usuario usuario)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE usuario SET nome=@Nome,userName=@UserName,funcao=@Funcao,senha=@Senha,tipo=@Tipo " +
                                 "WHERE id=@Id";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@UserName", usuario.UserName);
                cmd.Parameters.AddWithValue("@Funcao", usuario.Funcao);
                cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@Tipo", usuario.Tipo);
                cmd.Parameters.AddWithValue("@Id", usuario.Id);

                int x = cmd.ExecuteNonQuery();
                MessageBox.Show(Mensagem.GetMensagemConfirmacao(x), Mensagem.GetMensagemTitulo("Confirmação do Sistema"));
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }

        /// <summary>
        /// Exclui o usuário cadastrado.
        /// </summary>
        /// <param name="usuario">Usuario</param>
        public void ExcluiUsuario(Usuario usuario)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE usuario SET ativo=@Ativo WHERE id=@Id";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Ativo", usuario.Ativo);
                cmd.Parameters.AddWithValue("@Id", usuario.Id);

                int x = cmd.ExecuteNonQuery();
                MessageBox.Show(Mensagem.GetMensagemConfirmacao(x), Mensagem.GetMensagemTitulo("Confirmação do Sistema"));
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(ex.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }


        /// <summary>
        /// Recupera lista de usuarios cadastrados.
        /// </summary>
        /// <returns>Lista de Usuarios</returns>        
        public DataTable Usuario(string pesquisa)
        {
            string query = "";
            if (pesquisa == "")
            {
                query = "";
            }
            else
            {
                query = " nome LIKE '%" + pesquisa + "%' AND ";
            }
            try
            {
                MySqlConnection con = bd.IniciaConexao();

                String cmdText = "SELECT id,nome,userName,funcao,tipo "
                              + "FROM usuario WHERE " + pesquisa + " ativo = 0 "
                              + "ORDER BY nome ASC";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                bd.FinalizaConexao();
                return DT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(ex.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return null;
            }
        }


        /// <summary>
        /// Recupera usuário cadastrado.
        /// </summary>
        /// <param name="usuario">Id do usuário</param>
        /// <returns>Usuário</returns>
        public Usuario GetUsuario(Usuario usuario)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                MySqlDataReader leitor = null;
                String cmdText = "SELECT id,nome,userName,funcao,senha,tipo " +
                                 "FROM usuario " +
                                 "WHERE ativo = 0 AND id = @Id";

                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Id", usuario.Id);
                leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        usuario.Id = Convert.ToInt32(System.Convert.IsDBNull(leitor["id"]) ? null : leitor["id"]);
                        usuario.Nome = System.Convert.IsDBNull(leitor["nome"]) ? null : leitor["nome"].ToString();
                        usuario.UserName = System.Convert.IsDBNull(leitor["userName"]) ? null : leitor["userName"].ToString();
                        usuario.Funcao = System.Convert.IsDBNull(leitor["funcao"]) ? null : leitor["funcao"].ToString();
                        usuario.Senha = System.Convert.IsDBNull(leitor["senha"]) ? null : leitor["senha"].ToString();
                        usuario.Tipo = System.Convert.IsDBNull(leitor["tipo"]) ? null : leitor["tipo"].ToString();
                    }
                }
                return usuario;
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
            }
            bd.FinalizaConexao();
            return null;
        }
    }
}
