using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace SistemaParaPizzaria
{
    class ProdutoCompostoDao : ProdutoDao
    {
        Conexao bd;

        public ProdutoCompostoDao()
        {
            bd = new Conexao();
        }


        /// <summary>
        /// Insere ingredientes ao produto composto
        /// </summary>
        /// <param name="produto">produtos</param>
        public void AddItemProdutoComposto(ProdutoComposto produto)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "INSERT INTO produtoComposto(idProduto,idIngrediente,qtdIngrediente) "
                               + "values (@IdProduto,@IdIngrediente,@QtdIngrediente)";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@IdProduto", produto.IdProdutoComposto);
                cmd.Parameters.AddWithValue("@IdIngrediente", produto.IdProduto);
                cmd.Parameters.AddWithValue("@QtdIngrediente", produto.QtdIngrediente);

                cmd.ExecuteNonQuery();
                //MessageBox.Show("Produto inserido com sucesso!", "Gourmet Management");
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }


        /// <summary>
        /// Altera o valor do produto composto
        /// </summary>
        /// <param name="produto">Id do produto</param>
        public void AlteraPrecoProdutoComposto(Produto produto)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE produto SET valorUnitario = @ValorUnitario "
                               + "WHERE idProduto = @IdProduto";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@ValorUnitario", produto.ValorUnitario);
                cmd.Parameters.AddWithValue("@IdProduto", produto.IdProduto);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }


        /// <summary>
        /// Remove item do produto composto
        /// </summary>
        /// <param name="itemPedido">Item a ser removido do produto composto</param>
        public void RemoveItemDoProdutoComposto(ProdutoComposto produto)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "DELETE FROM produtoComposto WHERE idProduto = @idProduto AND idIngrediente = @IdIngrediente";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@IdProduto", produto.IdProdutoComposto);
                cmd.Parameters.AddWithValue("@IdIngrediente", produto.IdProduto);

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
        /// Altera a quantidade de itens do produto composto
        /// </summary>
        /// <param name="itemPedido">Item a ser alterado</param>
        public void AlterarQtdItemDoProdutoComposto(ProdutoComposto produto)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE produtoComposto SET qtdIngrediente = @QtdIngrediente "
                               + "WHERE idProduto = @IdProduto AND idIngrediente = @IdIngrediente";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@QtdIngrediente", produto.QtdIngrediente);
                cmd.Parameters.AddWithValue("@IdProduto", produto.IdProdutoComposto);
                cmd.Parameters.AddWithValue("@IdIngrediente", produto.IdProduto);

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
        /// Carrega tabela com ingredientes do produto composto
        /// </summary>
        /// <param name="id">Código do Produto Composto</param>
        /// <returns>Tabela de ingredientes do produto</returns>
        public DataTable ItensProdutoComposto(int id)
        {
            try
            {

                MySqlConnection con = bd.IniciaConexao();
                MySqlCommand cmd = null;

                String cmdText = "SELECT A.idIngrediente,B.descricao,A.qtdIngrediente,B.unidade,B.valorUnitario,A.qtdIngrediente * B.valorUnitario AS total "
                               + "FROM produtoComposto A "
                               + "INNER JOIN produto B ON A.idIngrediente = B.idProduto "
                               + "WHERE A.idProduto = @IdProduto AND B.ativo = @Ativo";
                cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@IdProduto", id);
                cmd.Parameters.AddWithValue("@Ativo", 0);

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

        /// <summary>
        /// Carrega ttabela com Produtos Composto
        /// </summary>
        /// <returns>Tabela de Produtos Composto</returns>
        public DataTable ProdutoComposto()
        {
            MySqlConnection con = bd.IniciaConexao();

            String cmdText = "SELECT idProduto,descricao "
                          + "FROM produto WHERE ativo = 0 AND tipo = 'Composto' "
                          + "ORDER BY descricao ASC";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            bd.FinalizaConexao();
            return DT;
        }


        public String[] BuscaIngredientesProdutoComposto(int id)
        {
            string[] retorno;
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                MySqlDataReader leitor = null;
                String cmdText = "SELECT A.descricao, B.qtdIngrediente, A.unidade " +
                                 "FROM produto A " +
                                 "INNER JOIN produtoComposto B ON A.idProduto = B.idIngrediente " +
                                 "WHERE B.IdProduto = @IdProduto AND ativo = 0 ORDER BY A.descricao DESC";

                String cmdText1 = "SELECT COUNT(*) FROM produtoComposto WHERE idProduto = @IdProduto ";

                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@IdProduto", id);
                MySqlCommand cmd1 = new MySqlCommand(cmdText1, con);
                cmd1.Prepare();
                cmd1.Parameters.AddWithValue("@IdProduto", id);

                int x = Convert.ToInt32(cmd1.ExecuteScalar());

                leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    string texto;
                    int y = 0;

                    retorno = new string[x];
                  

                    while (leitor.Read())
                    {
                        texto = leitor.GetString(0).ToString();

                        retorno[y] = texto;
                        y++;

                    }
                    return retorno;
                }

                bd.FinalizaConexao();
                leitor.Close();

            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return null;
            }
            return null;
        }
    }
}
