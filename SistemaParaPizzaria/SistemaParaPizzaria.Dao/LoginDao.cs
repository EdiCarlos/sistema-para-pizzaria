using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaParaPizzaria
{
    class LoginDao
    {
        Conexao bd;

        public LoginDao()
        {
            bd = new Conexao();
        }

        public void BuscaUsuario(string user, string senha)
        {
            Login.Existe = false;
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                MySqlDataReader leitor = null;
                String cmdText = "SELECT nome,userName,tipo " +
                                 "FROM usuario " +
                                 "WHERE userName = @UserName AND senha = @Senha AND ativo = 0 ";

                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@UserName", user);
                cmd.Parameters.AddWithValue("@Senha", senha);
                leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    Login.Existe = true;
                    while (leitor.Read())
                    {                      
                        Login.Nome = System.Convert.IsDBNull(leitor["nome"]) ? null : leitor["nome"].ToString();
                        Login.User = System.Convert.IsDBNull(leitor["userName"]) ? null : leitor["userName"].ToString();                                          
                        Login.Tipo = System.Convert.IsDBNull(leitor["tipo"]) ? null : leitor["tipo"].ToString();
                    }
                }              
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
            }
            bd.FinalizaConexao();          
        }
    }
}
