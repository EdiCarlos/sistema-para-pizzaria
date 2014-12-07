using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using DesenvolveNet;
using System.Data;

namespace SistemaParaPizzaria
{
    class FornecedorDao
    {
        Conexao bd;

        public FornecedorDao()
        {
            bd = new Conexao();
        }


        #region Fornecedor
        /// <summary>
        /// Cadastra fornecedor
        /// </summary>
        /// <param name="fornecedor">Atributos da classe Fornecedor</param>
        public void CadastraFornecedor(Fornecedor fornecedor)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "INSERT INTO fornecedor(nome,fantasia,cnpj,inscEstadual,observacao) "
                               + "values (@Nome,@Fantasia,@Cnpj,@InscEstadual,@Observacao)";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Nome", fornecedor.RazaoSocial);
                cmd.Parameters.AddWithValue("@Fantasia", fornecedor.NomeFantasia);
                cmd.Parameters.AddWithValue("@Cnpj", fornecedor.Cnpj);
                cmd.Parameters.AddWithValue("@InscEstadual", fornecedor.IncricaoEstadual);
                cmd.Parameters.AddWithValue("@Observacao", fornecedor.Observacao);

                cmd.ExecuteNonQuery();
                // MessageBox.Show("Fornecedor cadastrado com sucesso!", "Gourmet Management");
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }

        /// <summary>
        /// Altera os dados do fornecedor cadastrado.
        /// </summary>
        /// <param name="fornecedor">Id do fornecedor</param>
        public void AlteraFornecedor(Fornecedor fornecedor)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE fornecedor SET nome = @Nome, fantasia = @Fantasia, cnpj = @Cnpj, inscEstadual = @InscEstadual, observacao = @Observacao " +
                                 "WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Nome", fornecedor.RazaoSocial);
                cmd.Parameters.AddWithValue("@Fantasia", fornecedor.NomeFantasia);
                cmd.Parameters.AddWithValue("@Cnpj", fornecedor.Cnpj);
                cmd.Parameters.AddWithValue("@InscEstadual", fornecedor.IncricaoEstadual);
                cmd.Parameters.AddWithValue("@Observacao", fornecedor.Observacao);
                cmd.Parameters.AddWithValue("@Id", fornecedor.Id);

                cmd.ExecuteNonQuery();
                // MessageBox.Show("Fornecedor cadastrado com sucesso!", "Gourmet Management");
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }
        #endregion

        #region Contato Fornecedor
        /// <summary>
        /// Cadastra contato
        /// </summary>
        /// <param name="contato">Contatos da classe Fornecedor</param>
        public void CadastraContato(Fornecedor contato)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "INSERT INTO contato(idPessoa,telefone1,telefone2,contato,fax) "
                               + "values (@IdPessoa,@Telefone1,@Telefone2,@Contato,@Fax)";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@IdPessoa", GetIdFornecedor());
                cmd.Parameters.AddWithValue("@Telefone1", contato.Telefone1);
                cmd.Parameters.AddWithValue("@Telefone2", contato.Telefone2);
                cmd.Parameters.AddWithValue("@Contato", contato.Contato);
                cmd.Parameters.AddWithValue("@Fax", contato.Fax);

                cmd.ExecuteNonQuery();
                // MessageBox.Show("Fornecedor cadastrado com sucesso!", "Gourmet Management");
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }

        /// <summary>
        /// Altera dodos do contato do fornecedor cadastrado.
        /// </summary>
        /// <param name="contato">Id Fornecedor</param>
        public void AlteraContato(Fornecedor contato)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE contato SET telefone1=@Telefone1, telefone2=@Telefone2, contato=@Contato, fax=@Fax " +
                                 "WHERE idPessoa=@IdPessoa";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@IdPessoa", contato.Id);
                cmd.Parameters.AddWithValue("@Telefone1", contato.Telefone1);
                cmd.Parameters.AddWithValue("@Telefone2", contato.Telefone2);
                cmd.Parameters.AddWithValue("@Contato", contato.Contato);
                cmd.Parameters.AddWithValue("@Fax", contato.Fax);

                cmd.ExecuteNonQuery();
                // MessageBox.Show("Fornecedor cadastrado com sucesso!", "Gourmet Management");
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }
        #endregion

        #region Endereço Fornecedor
        /// <summary>
        /// Cadastra endereço
        /// </summary>
        /// <param name="endereco">Endereco da classe Fornecedor</param>
        public void CadastraEndereco(Fornecedor endereco)
        {
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "INSERT INTO endereco(idPessoa,logradouro,numero,complemento,bairro,uf,cidade,cep,email) "
                               + "values (@IdPessoa,@Logradouro,@Numero,@Complemento,@Bairro,@Uf,@Cidade,@Cep,@Email)";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@IdPessoa", GetIdFornecedor());
                cmd.Parameters.AddWithValue("@Logradouro", endereco.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", endereco.Numero);
                cmd.Parameters.AddWithValue("@Complemento", endereco.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                cmd.Parameters.AddWithValue("@Uf", endereco.Uf);
                cmd.Parameters.AddWithValue("@Cidade", endereco.Cidade);
                cmd.Parameters.AddWithValue("@Cep", endereco.Cep);
                cmd.Parameters.AddWithValue("@Email", endereco.Email);

                cmd.ExecuteNonQuery();
                // MessageBox.Show("Fornecedor cadastrado com sucesso!", "Gourmet Management");
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }


        /// <summary>
        /// Altera o endereço do fornecedor cadastrado.
        /// </summary>
        /// <param name="endereco">Id Fornecedor</param>
        public void AlteraEndereco(Fornecedor endereco)
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
                // MessageBox.Show("Fornecedor cadastrado com sucesso!", "Gourmet Management");
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
        /// Busca o id do último fornecedor cadastrado
        /// </summary>
        /// <returns>id do fornecedor</returns>
        public int GetIdFornecedor()
        {
            int idFornecedor = 0;
            try
            {
                MySqlConnection con = bd.IniciaConexao();

                String cmdText = "SELECT id "
                               + "FROM fornecedor ORDER BY id DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                idFornecedor = Convert.ToInt32(cmd.ExecuteScalar());
                bd.FinalizaConexao();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return 0;
            }
            return idFornecedor;
        }

        /// <summary>
        /// Desativa o fornecedor
        /// </summary>
        /// <param name="fornecedor">Id do fornecedor</param>
        public void Exclui(Fornecedor fornecedor)
        {
            int ativo = 1;
            try
            {
                MySqlConnection con = bd.IniciaConexao();
                String cmdText = "UPDATE fornecedor SET ativo = @Ativo "
                                  + "WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Ativo", ativo);
                cmd.Parameters.AddWithValue("@Id", fornecedor.Id);

                int x = 0; //coletar o número de registros afetados.
                x = cmd.ExecuteNonQuery();

                MessageBox.Show("Registro excluído com sucesso! - " + x + "  - Registro(s) afetado(s).", "Gourmet Management");
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
                return;
            }
            bd.FinalizaConexao();
        }


        /// <summary>
        /// Preenche uma lista com os fornecedores cadastrados
        /// </summary>
        /// <returns>Lista de fornecedores</returns>
        public Fornecedor[] FindAll()
        {
            MySqlConnection con = bd.IniciaConexao();
            MySqlDataReader reader = null;
            List<Fornecedor> listFornecedor = new List<Fornecedor>();
            String cmdText = "SELECT A.id, A.nome, A.fantasia, A.cnpj, A.inscEstadual, A.observacao, "
                           + "B.telefone1, B.telefone2, B.contato, B.fax, "
                           + "C.logradouro, C.numero, C.complemento, C.bairro, C.uf, C.cidade, C.cep, C.email "
                           + "FROM fornecedor A  INNER JOIN contato B ON A.id = B.idPessoa "
                           + "INNER JOIN  endereco C ON A.id = C.idPessoa ";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listFornecedor.Add(new Fornecedor()
                {
                    Id = reader.GetInt32(0),
                    NomeFantasia = reader.GetString(1),
                    Cnpj = reader.GetString(2),
                    IncricaoEstadual = reader.GetString(3),
                    Observacao = reader.GetString(4),
                    Telefone1 = reader.GetString(5),
                    Telefone2 = reader.GetString(6),
                    Contato = reader.GetString(7),
                    Fax = reader.GetString(8),
                    Logradouro = reader.GetString(9),
                    Numero = reader.GetString(10),
                    Complemento = reader.GetString(11),
                    Bairro = reader.GetString(12),
                    Uf = reader.GetString(13),
                    Cidade = reader.GetString(14),
                    Cep = reader.GetString(15),
                    Email = reader.GetString(16)
                });
            }
            bd.FinalizaConexao();
            return listFornecedor.ToArray();
        }


        /// <summary>
        /// Cria uma tabela com as cidades cadastradas
        /// </summary>
        /// <param name="uf">Sigla dos estados</param>
        /// <returns>Tb Cidades</returns>
        public DataTable Cidades(String uf)
        {
            MySqlConnection con = bd.IniciaConexao();

            String cmdText = "SELECT id, nome "
                           + "FROM tb_cidades WHERE uf = '" + uf + "' "
                           + "ORDER BY nome ASC";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            bd.FinalizaConexao();
            return DT;
        }


        /// <summary>
        /// Cria uma tabela com as siglas dos estados cadastrados
        /// </summary>
        /// <returns>Sigls dos estados</returns>
        public DataTable Ufs()
        {
            MySqlConnection con = bd.IniciaConexao();

            String cmdText = "SELECT id, uf "
                          + "FROM tb_estados "
                          + "ORDER BY uf ASC";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            bd.FinalizaConexao();
            return DT;
        }

        /// <summary>
        /// Carrega DataTable com id e nome do fornecedor
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable Fornecedor(string pesquisa)
        {
            MySqlConnection con = bd.IniciaConexao();

            String cmdText = "SELECT id, nome "
                          + "FROM fornecedor WHERE " + pesquisa + " ativo = 0 "
                          + "ORDER BY nome ASC";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            bd.FinalizaConexao();
            return DT;
        }


        /// <summary>
        /// Recupera dados do fornecedor
        /// </summary>
        /// <param name="idFornecedor">id do fornecedor</param>
        /// <returns>dados do fornecedor</returns>
        public Fornecedor GetFornecedor(Fornecedor fornecedor)
        {
          
            try
            {

                MySqlConnection con = bd.IniciaConexao();
                MySqlDataReader leitor = null;
                String cmdText = "SELECT A.id, A.nome, A.fantasia, A.cnpj, A.inscEstadual, A.observacao, "
                               + "B.telefone1, B.telefone2, B.contato, B.fax, "
                               + "C.logradouro, C.numero, C.complemento, C.bairro, C.uf, C.cidade, C.cep, C.email "
                               + "FROM fornecedor A INNER JOIN contato B ON A.id = B.idPessoa "
                               + "INNER JOIN endereco C ON A.id = C.idPessoa where A.id = @Id and A.ativo = 0;";

                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Id", fornecedor.Id);
                leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {

                        fornecedor.Id = Convert.ToInt32(leitor["id"].ToString());
                        fornecedor.RazaoSocial = leitor["nome"].ToString();
                        fornecedor.NomeFantasia = leitor["fantasia"].ToString();
                        fornecedor.Cnpj = leitor["cnpj"].ToString();
                        fornecedor.IncricaoEstadual = leitor["inscEstadual"].ToString();
                        fornecedor.Observacao = leitor["observacao"].ToString();
                        fornecedor.Telefone1 = leitor["telefone1"].ToString();
                        fornecedor.Telefone2 = leitor["telefone2"].ToString();
                        fornecedor.Contato = leitor["contato"].ToString();
                        fornecedor.Fax = leitor["fax"].ToString();
                        fornecedor.Logradouro = leitor["logradouro"].ToString();
                        fornecedor.Numero = leitor["numero"].ToString();
                        fornecedor.Bairro = leitor["bairro"].ToString();
                        fornecedor.Complemento = leitor["complemento"].ToString();
                        fornecedor.Uf = leitor["uf"].ToString();
                        fornecedor.Cidade = leitor["cidade"].ToString();
                        fornecedor.Cep = leitor["cep"].ToString();
                        fornecedor.Email = leitor["email"].ToString();
                    }
                }


                bd.FinalizaConexao();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(err.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
            }
            return fornecedor;
        }

    }
}
