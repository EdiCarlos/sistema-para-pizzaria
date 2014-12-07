using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaParaPizzaria
{
    class UnidadeDao
    {
        Conexao bd;

        public UnidadeDao()
        {
            bd = new Conexao();
        }

        /// <summary>
        /// Insere unidade de medida
        /// </summary>
        /// <param name="unidade">Tipo de unidade</param>
        public void Insert(Unidade unidade)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "INSERT INTO unidade(unidade) "
                               + "values (@Unidade)";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Unidade", unidade.Unid);

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
        /// Altera a unidade para inativo, podendo o ite ser ativado através do banco de dados
        /// </summary>
        /// <param name="unidade">Unidade de medida</param>
        public void Altera(Unidade unidade)
        {
            int ativo = 1;
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE unidade SET ativo = @Ativo "
                                  + "WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Id", unidade.IdUnidade);
                cmd.Parameters.AddWithValue("@Ativo", ativo);


                int x = 0; //coletar o número de registros afetados.
                x = cmd.ExecuteNonQuery();

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
       /// Recupera unidade
       /// </summary>
       /// <returns>Lista de unidades</returns>
        public Unidade[] FindAll()
        {
            MySqlConnection con = bd.IniciaConexao();
            MySqlDataReader reader = null;
            List<Unidade> listUnidades = new List<Unidade>();
            String cmdText = "SELECT id, unidade "
                           + "FROM unidade WHERE ativo = 0 "
                           + "ORDER BY unidade ASC";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listUnidades.Add(new Unidade()
                {
                    IdUnidade = reader.GetInt32(0),
                    Unid = reader.GetString(1),

                });
            }
            bd.FinalizaConexao();
            return listUnidades.ToArray();
        }


        /// <summary>
        /// Busca lista de unidade para autocomplete.
        /// </summary>
        /// <returns>lista unidade</returns>
        public AutoCompleteStringCollection PreencheListaUnidade()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                MySqlDataReader leitor = null;
                String cmdText = "SELECT unidade "
                              + "FROM unidade WHERE ativo = 0 "
                              + "ORDER BY unidade ASC";
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
    }
}
