using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace SistemaParaPizzaria
{
    class ItemPedidoDao
    {
        Conexao bd;

        public ItemPedidoDao()
        {
            bd = new Conexao();
        }

        /// <summary>
        ///  Incluir item no  pedido
        /// </summary>
        /// <param name="itemPedido">Item a ser inserido no pedido</param>
        public void IncluirItemNoPedido(ItemPedido itemPedido)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "INSERT INTO item_pedido(idProduto,qtdProduto,idPedido) "
                               + "values (@IdProduto,@QtdProduto,@IdPedido)";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@IdProduto", itemPedido.IdProduto);
                cmd.Parameters.AddWithValue("@QtdProduto", itemPedido.QtdProduto);
                cmd.Parameters.AddWithValue("@IdPedido", itemPedido.IdPedido);

                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(ex.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }

        /// <summary>
        /// Altera a quantidade de itens do pedido
        /// </summary>
        /// <param name="itemPedido">Item a ser alterado</param>
        public void AlterarQtdItemDoPedido(ItemPedido itemPedido)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE item_pedido SET qtdProduto = @QtdProduto "
                               + "WHERE idProduto = @IdProduto AND idPedido = @IdPedido";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();                
                cmd.Parameters.AddWithValue("@QtdProduto", itemPedido.QtdProduto);
                cmd.Parameters.AddWithValue("@IdProduto", itemPedido.IdProduto);
                cmd.Parameters.AddWithValue("@IdPedido", itemPedido.IdPedido);

                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(ex.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }


        /// <summary>
        /// Remove item do pedido
        /// </summary>
        /// <param name="itemPedido">Item a ser removido do pedido</param>
        public void RemoveItemDoPedido(ItemPedido itemPedido)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "DELETE FROM item_pedido WHERE idProduto = @Id";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Id", itemPedido.IdProduto);

                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(ex.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }


        /// <summary>
        /// Listar os itens do pedido
        /// </summary>
        /// <param name="idPedido">Id do pedido</param>
        /// <returns>Um data table com os itens do pedido</returns>
        public DataTable ListaGrid(int idPedido, string mesa)
        {
            try
            {

                MySqlConnection con = bd.IniciaConexao();
                MySqlCommand cmd = null;

                String cmdText = "SELECT A.idProduto,B.descricao,A.qtdProduto,B.unidade,B.valorUnitario,A.qtdProduto * B.valorUnitario AS total "
                               + "FROM item_pedido A "
                               + "INNER JOIN produto B ON A.idProduto = B.idProduto "
                               + "INNER JOIN pedido C ON C.id = A.idPedido "
                               + "WHERE A.idPedido = @IdPedido AND C.mesa = @Mesa";
                cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@IdPedido", idPedido);
                cmd.Parameters.AddWithValue("@Mesa", mesa);
               
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                return DT;

            }
            catch (Exception ex)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(ex.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return null;
            }      
        }
        
            
    }
}
