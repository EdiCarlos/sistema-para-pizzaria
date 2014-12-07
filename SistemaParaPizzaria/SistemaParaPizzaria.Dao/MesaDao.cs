using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace SistemaParaPizzaria
{
    class MesaDao
    {
        Conexao bd;

        private int retorno;

        public MesaDao()
        {
            bd = new Conexao();
        }

        //Altera status mesa
        public void AlteraStatusMesa(Mesa mesa)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE mesa SET status = @Status "
                               + "WHERE numeroMesa = @Mesa";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Status", mesa.StatusMesa);
                cmd.Parameters.AddWithValue("@Mesa", mesa.NumeroMesa);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }

        //Recupera status da mesa

        public int GetStatusMesa(int mesa)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "SELECT status FROM mesa "
                               + "WHERE numeroMesa = @NumeroMesa";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@NumeroMesa", mesa);
                retorno = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
            }
            bd.FinalizaConexao();
            return retorno;
        }

    }
}
