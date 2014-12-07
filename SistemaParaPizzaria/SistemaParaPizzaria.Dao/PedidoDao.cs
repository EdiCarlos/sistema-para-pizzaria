using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaParaPizzaria
{
    class PedidoDao
    {
        Conexao bd;

        public PedidoDao()
        {
            bd = new Conexao();
        }


        //Gravar pedido
        public void GravaPedido(Pedido pedido)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "INSERT INTO pedido(dataPedido, mesa, qtdPessoas, idFuncionario) "
                               + "values (@dataPedido, @Mesa, @QtdPessoas, @IdFuncionario)";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@dataPedido", pedido.DataPedido);
                cmd.Parameters.AddWithValue("@Mesa", pedido.Mesa);
                cmd.Parameters.AddWithValue("@QtdPessoas", pedido.QtdPessoas);
                cmd.Parameters.AddWithValue("@IdFuncionario", pedido.IdFuncionario);


                cmd.ExecuteNonQuery();
               
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }


        public Pedido GetPedido(int mesa)
        {
            Pedido pedido = new Pedido();
            try
            {

                MySqlConnection con = bd.IniciaConexao();
                MySqlDataReader leitor = null;
                String cmdText = "SELECT id, mesa, qtdPessoas, idFuncionario FROM pedido "
                               + "WHERE mesa = @Mesa AND (statusPedido = 0 OR statusPedido = 1)";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Mesa", mesa);
                //cmd.Parameters.AddWithValue("@StatusPedido", 0);
                leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {

                        pedido.IdPedido = Convert.ToInt32(leitor["id"].ToString());
                        pedido.Mesa = Convert.ToInt32(leitor["mesa"].ToString());
                        pedido.QtdPessoas = Convert.ToInt32(leitor["qtdPessoas"].ToString());
                        pedido.IdFuncionario = Convert.ToInt32(leitor["idFuncionario"].ToString());
                    }
                }


                bd.FinalizaConexao();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
            }


            return pedido;
        }

    
        /// <summary>
        /// Altera status do pedido
        /// </summary>
        /// <param name="pedido"></param>
        public void AlteraStatusPedido(Pedido pedido)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE pedido SET statusPedido = @StatusPedido "
                               + "WHERE id = @IdPedido";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@StatusPedido", pedido.StatusPedido);
                cmd.Parameters.AddWithValue("@IdPedido", pedido.IdPedido);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }
    }
}
