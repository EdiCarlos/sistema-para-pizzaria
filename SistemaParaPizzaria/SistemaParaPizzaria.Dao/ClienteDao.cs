using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;



namespace SistemaParaPizzaria
{
    class ClienteDao
    {
        AutoCompleteStringCollection listaNomeCliente = new AutoCompleteStringCollection();
        AutoCompleteStringCollection listaCpfCliente = new AutoCompleteStringCollection();
        AutoCompleteStringCollection listaTelefoneCliente = new AutoCompleteStringCollection();

        Conexao bd;

        public ClienteDao()
        {
            bd = new Conexao();
        }
        #region Cliente
        /// <summary>
        /// Cadastra cliente
        /// </summary>
        /// <param name="cliente">Atributos da classe Cliente</param>
        public void CadastraCliente(Cliente cliente)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "INSERT INTO cliente(nome,cpf,rg,observacao) "
                               + "values (@Nome,@Cpf,@Rg,@Observacao)";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@Cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@Rg", cliente.Rg);
                cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao);
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
        /// Altera dados do cliente
        /// </summary>
        /// <param name="cliente">Atributos da classe cliente</param>
        public void AlteraCliente(Cliente cliente)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE cliente SET nome = @Nome, cpf = @Cpf, rg = @Rg, observacao = @Observacao " +
                                 "WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@Cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@Rg", cliente.Rg);
                cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao);
                cmd.Parameters.AddWithValue("@Id", cliente.Id);

                cmd.ExecuteNonQuery();
            }

            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }
        #endregion

        #region Contato Cliente
        /// <summary>
        /// Cadastra contato
        /// </summary>
        /// <param name="contato">Contatos da classe Cliente</param>
        public void CadastraContato(Cliente contato)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "INSERT INTO contato(idPessoa,telefone1,telefone2,contato) "
                               + "values (@IdPessoa,@Telefone1,@Telefone2,@Contato)";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@IdPessoa", GetIdCliente());
                cmd.Parameters.AddWithValue("@Telefone1", contato.Telefone1);
                cmd.Parameters.AddWithValue("@Telefone2", contato.Telefone2);
                cmd.Parameters.AddWithValue("@Contato", contato.Contato);

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
        /// Altera dodos do contato do cliente cadastrado.
        /// </summary>
        /// <param name="contato">Id Cliente</param>
        public void AlteraContato(Cliente contato)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE contato SET telefone1=@Telefone1, telefone2=@Telefone2, contato=@Contato  " +
                                 "WHERE idPessoa=@IdPessoa";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@IdPessoa", contato.Id);
                cmd.Parameters.AddWithValue("@Telefone1", contato.Telefone1);
                cmd.Parameters.AddWithValue("@Telefone2", contato.Telefone2);
                cmd.Parameters.AddWithValue("@Contato", contato.Contato);

                cmd.ExecuteNonQuery();

            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }
        #endregion

        #region Endereço Cliente
        /// <summary>
        /// Cadastra endereço
        /// </summary>
        /// <param name="endereco">Endereco da classe Cliente</param>
        public void CadastraEndereco(Cliente endereco)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "INSERT INTO endereco(idPessoa,logradouro,numero,complemento,bairro,uf,cidade,cep,email) "
                               + "values (@IdPessoa,@Logradouro,@Numero,@Complemento,@Bairro,@Uf,@Cidade,@Cep,@Email)";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@IdPessoa", GetIdCliente());
                cmd.Parameters.AddWithValue("@Logradouro", endereco.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", endereco.Numero);
                cmd.Parameters.AddWithValue("@Complemento", endereco.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                cmd.Parameters.AddWithValue("@Uf", endereco.Uf);
                cmd.Parameters.AddWithValue("@Cidade", endereco.Cidade);
                cmd.Parameters.AddWithValue("@Cep", endereco.Cep);
                cmd.Parameters.AddWithValue("@Email", endereco.Email);

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
        /// Altera o endereço do cliente cadastrado.
        /// </summary>
        /// <param name="endereco">Id Cliente</param>
        public void AlteraEndereco(Cliente endereco)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE endereco SET logradouro=@Logradouro, numero=@Numero, " +
                                 "complemento=@Complemento, bairro=@Bairro, uf=@Uf, cidade=@Cidade, cep=@Cep, email=@Email " +
                                 "WHERE idPessoa=@IdPessoa";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@IdPessoa", endereco.Id);
                cmd.Parameters.AddWithValue("@Logradouro", endereco.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", endereco.Numero);
                cmd.Parameters.AddWithValue("@Complemento", endereco.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                cmd.Parameters.AddWithValue("@Uf", endereco.Uf);
                cmd.Parameters.AddWithValue("@Cidade", endereco.Cidade);
                cmd.Parameters.AddWithValue("@Cep", endereco.Cep);
                cmd.Parameters.AddWithValue("@Email", endereco.Email);

                cmd.ExecuteNonQuery();

            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }
        #endregion

        /// <summary>
        /// Busca o id do último cliente cadastrado
        /// </summary>
        /// <returns>id do cliente</returns>
        public int GetIdCliente()
        {
            int idCliente = 0;
            try
            {
                MySqlConnection con = bd.IniciaConexao();

                String cmdText = "SELECT id "
                               + "FROM cliente ORDER BY id DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                idCliente = Convert.ToInt32(cmd.ExecuteScalar());
                bd.FinalizaConexao();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return 0;
            }
            return idCliente;
        }

        /// <summary>
        /// Desativa o cliente
        /// </summary>
        /// <param name="cliente">Id do cliente</param>
        public void Exclui(Cliente cliente)
        {
            int ativo = 1;
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE cliente SET ativo = @Ativo "
                                  + "WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Ativo", ativo);
                cmd.Parameters.AddWithValue("@Id", cliente.Id);

                int x = 0; //coletar o número de registros afetados.
                x = cmd.ExecuteNonQuery();

                MessageBox.Show("Registro excluído com sucesso! - " + x + "  - Registro(s) afetado(s).", Mensagem.GetMensagemTitulo("Confirmação do Sistema"));
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }


        /// <summary>
        /// Carrega DataTable com id e nome do cliente
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable Cliente()
        {
            MySqlConnection con = bd.IniciaConexao();

            String cmdText = "SELECT id, nome "
                          + "FROM cliente WHERE ativo = 0 "
                          + "ORDER BY nome ASC";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            bd.FinalizaConexao();
            return DT;
        }


        /// <summary>
        /// Recupera dados do cliente
        /// </summary>
        /// <param name="idCliente">id do cliente</param>
        /// <returns>dados do cliente</returns>
        public Cliente BuscaCliente(Cliente cliente)
        {
            try
            {

                MySqlConnection con = bd.IniciaConexao();
                MySqlDataReader leitor = null;
                String cmdText = "SELECT A.id, A.nome, A.cpf, A.rg, A.observacao, "
                               + "B.telefone1, B.telefone2, B.contato, "
                               + "C.logradouro, C.numero, C.complemento, C.bairro, C.uf, C.cidade, C.cep, C.email "
                               + "FROM cliente A INNER JOIN contato B ON A.id = B.idPessoa "
                               + "INNER JOIN endereco C ON A.id = C.idPessoa where A.id = @Id " +
                                 "OR A.nome = @Nome OR A.cpf = @Cpf " +
                                 "OR B.telefone1 = @Telefone1 " +
                                 "OR B.telefone2 = @Telefone2 and A.ativo = 0;";

                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Id", cliente.Id);
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@Cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@Telefone1", cliente.Telefone1);
                cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2);
                leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {

                        cliente.Id = Convert.ToInt32(leitor["id"].ToString());
                        cliente.Nome = leitor["nome"].ToString();
                        cliente.Cpf = leitor["cpf"].ToString();
                        cliente.Rg = leitor["rg"].ToString();
                        cliente.Observacao = leitor["observacao"].ToString();
                        cliente.Telefone1 = leitor["telefone1"].ToString();
                        cliente.Telefone2 = leitor["telefone2"].ToString();
                        cliente.Contato = leitor["contato"].ToString();
                        cliente.Logradouro = leitor["logradouro"].ToString();
                        cliente.Numero = leitor["numero"].ToString();
                        cliente.Bairro = leitor["bairro"].ToString();
                        cliente.Complemento = leitor["complemento"].ToString();
                        cliente.Uf = leitor["uf"].ToString();
                        cliente.Cidade = leitor["cidade"].ToString();
                        cliente.Cep = leitor["cep"].ToString();
                        cliente.Email = leitor["email"].ToString();
                    }
                }


                bd.FinalizaConexao();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
            }
            return cliente;
        }


        public AutoCompleteStringCollection BuscaListaClienteCadastrado()
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                MySqlDataReader dr = null;
                String cmdText = "SELECT nome "
                              + "FROM cliente WHERE ativo = 0 "
                              + "ORDER BY nome ASC";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        listaNomeCliente.Add(dr.GetValue(0).ToString());
                    }
                }
                bd.FinalizaConexao();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
            }

            return listaNomeCliente;
        }


        public AutoCompleteStringCollection BuscaListaClienteCadastradoPeloCpf()
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                MySqlDataReader dr = null;
                String cmdText = "SELECT cpf "
                              + "FROM cliente WHERE ativo = 0 "
                              + "ORDER BY nome ASC";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        listaCpfCliente.Add(dr.GetValue(0).ToString());
                    }
                }
                bd.FinalizaConexao();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
            }

            return listaCpfCliente;
        }


        public AutoCompleteStringCollection BuscaListaClienteCadastradoPeloTelefone()
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                MySqlDataReader dr = null;
                String cmdText = "SELECT  A.telefone1 " +
                                 "FROM contato A INNER JOIN cliente B ON A.idPessoa = B.id WHERE B.ativo = 0 " +
                                 "UNION " + 
                                 "SELECT  A.telefone2 " +
                                 "FROM contato A INNER JOIN cliente B ON A.idPessoa = B.id WHERE B.ativo = 0 ";
                            
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        listaTelefoneCliente.Add(dr.GetValue(0).ToString());
                    }
                }
                bd.FinalizaConexao();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
            }

            return listaTelefoneCliente;
        }

    }
}
