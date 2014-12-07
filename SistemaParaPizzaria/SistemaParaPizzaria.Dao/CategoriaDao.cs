using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace SistemaParaPizzaria
{
    class CategoriaDao
    {
        Conexao bd;

        public CategoriaDao()
        {
            bd = new Conexao();
        }

        /// <summary>
        /// Insere categoria de produto
        /// </summary>
        /// <param name="unidade">Categoria</param>
        public void Insert(Categoria categoria)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "INSERT INTO categoria(categoria) "
                               + "values (@Categoria)";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Categoria", categoria.NomeCategoria);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro inserido com sucesso!", Mensagem.GetMensagemTitulo("Confirmação do Sistema"));
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }


        /// <summary>
        /// Altera a categoria para inativo, podendo ser ativado através do banco de dados
        /// </summary>
        /// <param name="unidade">Categoria</param>
        public void Altera(Categoria categoria)
        {
            int ativo = 1;
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE categoria SET ativo = @Ativo "
                                  + "WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Id", categoria.IdCategoria);
                cmd.Parameters.AddWithValue("@Ativo", ativo);


                int x = 0; //coletar o número de registros afetados.
                x = cmd.ExecuteNonQuery();

                MessageBox.Show("Registro alterado com sucesso! - " + x + "  - Registro(s) afetado(s).", Mensagem.GetMensagemTitulo("Confirmação do Sistema"));
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }

        /// <summary>
        /// Busca tabela de id e categoria.
        /// </summary>
        /// <returns>tb_categoria</returns>
        public DataTable BuscaCategoria(string pesquisa)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                DataTable DT = new DataTable();
                String cmdText = "SELECT id, categoria "
                              + "FROM categoria WHERE " + pesquisa + " ativo = 0 "
                              + "ORDER BY categoria ASC";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                DT.Load(cmd.ExecuteReader());
                bd.FinalizaConexao();
                return DT;
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return null;
            }
        }

        /// <summary>
        /// Busca lista de categoria para autocomplete.
        /// </summary>
        /// <returns>lista categoria</returns>
        public AutoCompleteStringCollection PreencheListaCategoria()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                MySqlDataReader leitor = null;
                String cmdText = "SELECT categoria "
                              + "FROM categoria WHERE ativo = 0 "
                              + "ORDER BY categoria ASC";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        lista.Add(leitor.GetString(0));
                    }
                }

                bd.FinalizaConexao();
                leitor.Close();
                return lista;
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return null;
            }
        }


        /// <summary>
        /// Busca categoria cadastrada
        /// </summary>
        /// <param name="categoria">Id Categoria</param>
        /// <returns>Categoria</returns>
        public Categoria BuscaCategoriaIndividual(Categoria categoria)
        {

            try
            {
                MySqlConnection con = bd.IniciaConexao();
                MySqlDataReader leitor = null;
                String cmdText = "SELECT id, categoria "
                              + "FROM categoria WHERE id = @Id AND ativo = 0 ";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Id", categoria.IdCategoria);
                leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        categoria.IdCategoria = leitor.GetInt32(0);
                        categoria.NomeCategoria = leitor.GetString(1);
                    }
                }

                bd.FinalizaConexao();
                leitor.Close();
                return categoria;
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return null;
            }
        }

    }
}
