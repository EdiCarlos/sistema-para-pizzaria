using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace SistemaParaPizzaria
{
    class ProdutoDao
    {
        Conexao bd;

        public ProdutoDao()
        {
            bd = new Conexao();
        }


        //Método para inserir dados
        public void Insert(Produto produto)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "INSERT INTO produto(descricao, idCategoria, idFornecedor, unidade, qtdEstoque, valorUnitario, estoqueMinimo,tipo,observacao) "
                               + "values (@Descricao, @IdCategoria, @IdFornecedor, @Unidade, @QtdEstoque, @ValorUnitario, @EstoqueMinimo,@Tipo,@Observacao)";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@IdCategoria", produto.IdCategoria);
                cmd.Parameters.AddWithValue("@IdFornecedor", produto.IdFornecedor);
                cmd.Parameters.AddWithValue("@Unidade", produto.Unidade);
                cmd.Parameters.AddWithValue("@QtdEstoque", produto.QtdEstoque);
                cmd.Parameters.AddWithValue("@ValorUnitario", produto.ValorUnitario);
                cmd.Parameters.AddWithValue("@EstoqueMinimo", produto.EstoqueMinimo);
                cmd.Parameters.AddWithValue("@Tipo", produto.Tipo);
                cmd.Parameters.AddWithValue("@Observacao", produto.Observacao);

                cmd.ExecuteNonQuery();

            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }

        //Método para alterar dados
        public void Altera(Produto produto)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE produto SET descricao = @Descricao, idCategoria = @IdCategoria, idFornecedor = @IdFornecedor, "
                               + "unidade = @Unidade, qtdEstoque = @QtdEstoque, valorUnitario = @ValorUnitario, estoqueMinimo = @EstoqueMinimo "
                               + "WHERE idProduto = @IdProduto";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@IdCategoria", produto.IdCategoria);
                cmd.Parameters.AddWithValue("@IdFornecedor", produto.IdFornecedor);
                cmd.Parameters.AddWithValue("@Unidade", produto.Unidade);
                cmd.Parameters.AddWithValue("@QtdEstoque", produto.QtdEstoque);
                cmd.Parameters.AddWithValue("@ValorUnitario", produto.ValorUnitario);
                cmd.Parameters.AddWithValue("@EstoqueMinimo", produto.EstoqueMinimo);
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
        /// Inclui o valor do produto.
        /// </summary>
        /// <param name="valor">Id Produto</param>
        public void IncluiValorProduto(Produto valor)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "INSERT INTO valorProduto(idProduto,valorCompra,valorVenda,porcentagem) "
                               + "values (@IdProduto, @ValorCompra, @ValorVenda, @Porcentagem)";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@IdProduto", GetIdProduto());
                cmd.Parameters.AddWithValue("@ValorCompra", valor.ValorCompra);
                cmd.Parameters.AddWithValue("@ValorVenda", valor.ValorUnitario);
                cmd.Parameters.AddWithValue("@Porcentagem", valor.Porcentagem);

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
        /// Altera dados do valor do produto
        /// </summary>
        /// <param name="valor">Id Produto</param>
        public void AlteraValorProduto(Produto valor)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE valorProduto SET idProduto=@IdProduto,valorCompra=@ValorCompra, " +
                                 "valorVenda=@ValorVenda,porcentagem=@Porcentagem " +
                                 "WHERE idProduto=@IdProduto";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@ValorCompra", valor.ValorCompra);
                cmd.Parameters.AddWithValue("@ValorVenda", valor.ValorUnitario);
                cmd.Parameters.AddWithValue("@Porcentagem", valor.Porcentagem);
                cmd.Parameters.AddWithValue("@IdProduto", valor.IdProduto);

                cmd.ExecuteNonQuery();

            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }

        //Método para excluir dados
        public void Exclui(Produto produto)
        {
            int ativo = 1;
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE produto SET ativo = @Ativo "
                                  + "WHERE idProduto = @IdProduto";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Ativo", ativo);
                cmd.Parameters.AddWithValue("@IdProduto", produto.IdProduto);

                int x = 0; //coletar o número de registros afetados.
                x = cmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluído com sucesso! - " + x + "  - Registro(s) afetado(s).", "Gourmet Management");
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }

        //Método para buscar dados
        public Produto[] FindAll(string criterio)
        {
            MySqlConnection con = bd.IniciaConexao();
            MySqlDataReader reader = null;
            List<Produto> listProdutos = new List<Produto>();
            String cmdText = "SELECT descricao, idCategoria, idFornecedor, unidade, qtdEstoque, valorUnitario, estoqueMinimo "
                           + "FROM produto WHERE idProduto = @IdProduto AND ativo = 0 ";



            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listProdutos.Add(new Produto()
                {
                    IdProduto = reader.GetInt32(0),
                    Descricao = reader.GetString(1),
                    IdCategoria = reader.GetInt32(2),
                    IdFornecedor = reader.GetInt32(3),
                    Unidade = reader.GetString(4),
                    QtdEstoque = reader.GetDecimal(5),
                    ValorUnitario = reader.GetDecimal(6),
                    EstoqueMinimo = reader.GetDecimal(7)
                });
            }
            bd.FinalizaConexao();
            return listProdutos.ToArray();
        }


        //Método para buscar dados
        public Produto[] FindAll()
        {
            MySqlConnection con = bd.IniciaConexao();
            MySqlDataReader reader = null;
            List<Produto> listProdutos = new List<Produto>();
            String cmdText = "SELECT idProduto, descricao, idCategoria, idFornecedor, unidade, qtdEstoque, valorUnitario, estoqueMinimo "
                           + "FROM produto WHERE ativo = 0 "
                           + "ORDER BY descricao ASC";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listProdutos.Add(new Produto()
                {
                    IdProduto = reader.GetInt32(0),
                    Descricao = reader.GetString(1),
                    IdCategoria = reader.GetInt32(2),
                    IdFornecedor = reader.GetInt32(3),
                    Unidade = reader.GetString(4),
                    QtdEstoque = reader.GetDecimal(5),
                    ValorUnitario = reader.GetDecimal(6),
                    EstoqueMinimo = reader.GetDecimal(7)
                });
            }
            bd.FinalizaConexao();
            return listProdutos.ToArray();
        }

        //Buscar produto individual
        public Produto GetProduto(int idProduto)
        {
            Produto produto = new Produto();
            try
            {

                MySqlConnection con = bd.IniciaConexao();
                MySqlDataReader leitor = null;
                String cmdText = "SELECT A.idProduto,A.descricao, A.idCategoria, A.idFornecedor, " +
                                 "A.unidade, A.qtdEstoque, A.valorUnitario, A.estoqueMinimo, " +
                                 "A.tipo, A.observacao, B.valorCompra, B.valorVenda, B.porcentagem " +
                                 "FROM produto A " +
                                 "INNER JOIN valorProduto B ON A.idProduto = B.idProduto " +
                                 "WHERE A.ativo = 0 AND A.idProduto = @IdProduto";

                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@IdProduto", idProduto);
                leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        produto.IdProduto = Convert.ToInt32(System.Convert.IsDBNull(leitor["idProduto"]) ? null : leitor["idProduto"]);
                        produto.Descricao = System.Convert.IsDBNull(leitor["descricao"]) ? null : leitor["descricao"].ToString();
                        produto.IdCategoria = Convert.ToInt32(System.Convert.IsDBNull(leitor["idCategoria"]) ? null : leitor["idCategoria"]);
                        produto.IdFornecedor = Convert.ToInt32(Convert.IsDBNull(leitor["idFornecedor"]) ? null : leitor["idFornecedor"]);
                        produto.Unidade = System.Convert.IsDBNull(leitor["unidade"]) ? null : leitor["unidade"].ToString();
                        produto.QtdEstoque = Convert.ToDecimal(Convert.IsDBNull(leitor["qtdEstoque"]) ? null : leitor["qtdEstoque"]);
                        produto.ValorUnitario = Convert.ToDecimal(Convert.IsDBNull(leitor["valorUnitario"]) ? null : leitor["valorUnitario"]);
                        produto.EstoqueMinimo = Convert.ToDecimal(Convert.IsDBNull(leitor["estoqueMinimo"]) ? null : leitor["estoqueMinimo"]);
                        produto.Tipo = System.Convert.IsDBNull(leitor["tipo"]) ? null : leitor["tipo"].ToString();
                        produto.ValorCompra = Convert.ToDecimal(System.Convert.IsDBNull(leitor["valorCompra"]) ? null : leitor["valorCompra"]);
                        produto.ValorUnitario = Convert.ToDecimal(System.Convert.IsDBNull(leitor["valorVenda"]) ? null : leitor["valorVenda"]);
                        produto.Porcentagem = Convert.ToInt32(System.Convert.IsDBNull(leitor["porcentagem"]) ? null : leitor["porcentagem"]);
                        produto.Observacao = System.Convert.IsDBNull(leitor["observacao"]) ? null : leitor["observacao"].ToString();
                    }
                }


                bd.FinalizaConexao();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
            }
            return produto;
        }


        /// <summary>
        /// Atualiza o saldo do estoque
        /// </summary>
        /// <param name="produto"></param>
        public void AtualizaEstoque(Produto produto)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE produto SET qtdEstoque = @QtdEstoque "
                               + "WHERE idProduto = @IdProduto";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@QtdEstoque", produto.QtdEstoque);
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
        /// Recupera tabela com a descrição dos produtos cadastrados e ativos.
        /// </summary>
        /// <returns>Tabela com lista de produtos</returns>
        public DataTable Produtos()
        {
            MySqlConnection con = bd.IniciaConexao();

            String cmdText = "SELECT idProduto,descricao "
                          + "FROM produto WHERE ativo = 0 AND tipo = 'Normal' "
                          + "ORDER BY descricao ASC";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            bd.FinalizaConexao();
            return DT;
        }


        /// <summary>
        /// Recupera o id do ultimo produto cadastrado.
        /// </summary>
        /// <returns>id do produto</returns>
        public int GetIdProduto()
        {
            int idProduto = 0;
            try
            {
                MySqlConnection con = bd.IniciaConexao();

                String cmdText = "SELECT idProduto "
                               + "FROM produto ORDER BY idProduto DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                idProduto = Convert.ToInt32(cmd.ExecuteScalar());
                bd.FinalizaConexao();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return 0;
            }
            return idProduto;
        }



        public DataTable PesquisaProduto(string pesquisa)
        {
            try
            {
            MySqlConnection con = bd.IniciaConexao();
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT idProduto, descricao,valorUnitario " +
                                                               "FROM produto WHERE " + pesquisa + " ativo = 0 " +
                                                               "ORDER BY descricao ASC", con);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            bd.FinalizaConexao();
            return DT;
             }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return null;
            }
        }

    }
}
