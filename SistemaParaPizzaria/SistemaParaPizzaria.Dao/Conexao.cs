using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaParaPizzaria
{
    class Conexao
    {
        String str = @"server=localhost;database=gourmetManagement;userid=root;password=1234";
        MySqlConnection con = null;

        public MySqlConnection IniciaConexao()
        {
            try
            {
                con = new MySqlConnection(str);
                con.Open();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
            }
            return con;

        }

        public void FinalizaConexao()
        {
            if (con != null)
            {
                con.Close();
            }
        }

        ~Conexao()
        {
            this.FinalizaConexao();
        }
    }
}
