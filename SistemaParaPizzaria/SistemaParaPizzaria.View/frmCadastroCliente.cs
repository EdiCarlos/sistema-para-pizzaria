using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaParaPizzaria
{
    public partial class frmCadastroCliente : Form
    {
        string opcao = "";
        public frmCadastroCliente()
        {
            InitializeComponent();
        }


        #region Funções
        private void carregarComboboxEstado()
        {
            FornecedorDao uf = new FornecedorDao();
            cmbUf.DataSource = uf.Ufs();
            cmbUf.DisplayMember = "uf";
            cmbUf.ValueMember = "uf";
        }

        private void carregarComboboxCidade()
        {
            FornecedorDao cidade = new FornecedorDao();
            cmbCidade.DataSource = cidade.Cidades(cmbUf.SelectedValue.ToString());
            cmbCidade.DisplayMember = "nome";
            cmbCidade.ValueMember = "id";
        }

        public void CarregaComboboxCliente()
        {
            ClienteDao cliente = new ClienteDao();
            cmbCliente.DataSource = cliente.Cliente();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.Text = "";
            opcao = "Incluir";
        }

        public void LimpaCampo()
        {
            txtCliente.Text = String.Empty;
            txtCpf.Text = String.Empty;
            txtRg.Text = String.Empty;
            txtTelefone1.Text = String.Empty;
            txtTelefone2.Text = String.Empty;
            txtContato.Text = String.Empty;
            txtLogradouro.Text = String.Empty;
            txtNumero.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtComplemento.Text = String.Empty;
            txtCep.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtObservacao.Text = String.Empty;
        }
        #endregion

        #region Eventos
        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            opcao = "Incluir";
            CarregaComboboxCliente();
            carregarComboboxEstado();
            carregarComboboxCidade();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteDao clienteDao = new ClienteDao();

            cliente.Nome = txtCliente.Text.Trim();
            cliente.Cpf = txtCpf.Text.Trim().Replace(".", "").Replace("-", "");
            cliente.Rg = txtRg.Text.Trim();
            cliente.Observacao = txtObservacao.Text.Trim();
            cliente.Telefone1 = txtTelefone1.Text.Trim().Replace("-", "");
            cliente.Telefone2 = txtTelefone2.Text.Trim().Replace("-", "");
            cliente.Contato = txtContato.Text.Trim();
            cliente.Logradouro = txtLogradouro.Text.Trim();
            cliente.Numero = txtNumero.Text.Trim();
            cliente.Bairro = txtBairro.Text.Trim();
            cliente.Complemento = txtComplemento.Text.Trim();
            cliente.Uf = cmbUf.Text.Trim();
            cliente.Cidade = cmbCidade.Text.Trim();
            cliente.Cep = txtCep.Text.Trim();
            cliente.Email = txtEmail.Text.Trim();


            if (opcao == "Incluir")
            {
                clienteDao.CadastraCliente(cliente);
                clienteDao.CadastraContato(cliente);
                clienteDao.CadastraEndereco(cliente);

                LimpaCampo();
                CarregaComboboxCliente();
                txtCliente.Focus();
            }
            else if (opcao == "Alterar")
            {
                cliente.Id = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
                clienteDao.AlteraCliente(cliente);
                clienteDao.AlteraContato(cliente);
                clienteDao.AlteraEndereco(cliente);
                LimpaCampo();
                CarregaComboboxCliente();
            }
        }

        private void btnRetorna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CodigoFornecedor = cmbFornecedor.SelectedValue.ToString();
            opcao = "Alterar";
        }

        private void cmbCliente_Validating(object sender, CancelEventArgs e)
        {
            if (cmbCliente.Text != "")
            {
                ClienteDao clienteDao = new ClienteDao();
                Cliente cliente = new Cliente();

                cliente.Id = Convert.ToInt32(cmbCliente.SelectedValue.ToString());

                cliente = clienteDao.BuscaCliente(cliente);
                txtCliente.Text = cliente.Nome;
                txtCpf.Text = cliente.FormatarCpfCnpj(cliente.Cpf);
                txtRg.Text = cliente.Rg;
                txtObservacao.Text = cliente.Observacao;
                txtTelefone1.Text = cliente.FormataTelefone(cliente.Telefone1);
                txtTelefone2.Text = cliente.FormataTelefone(cliente.Telefone2);
                txtContato.Text = cliente.Contato;
                txtLogradouro.Text = cliente.Logradouro;
                txtNumero.Text = cliente.Numero;
                txtBairro.Text = cliente.Bairro;
                txtComplemento.Text = cliente.Complemento;
                cmbUf.Text = cliente.Uf;
                cmbCidade.Text = cliente.Cidade;
                txtCep.Text = cliente.Cep;
                txtEmail.Text = cliente.Email;
            }
        }

        private void cmbUf_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarComboboxCidade();
        }

        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            Cliente cpf = new Cliente();
            txtCpf.Text = cpf.FormatarCpfCnpj(txtCpf.Text);
            if (txtCpf.Text == "ENTRADA INVÁLIDA")
            {
                MessageBox.Show("CPF Inválido.", "Gourmet Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpf.Text = "";
                // txtCpf.Focus();
            }
        }

        private void txtTelefone1_Validating(object sender, CancelEventArgs e)
        {
            Cliente tel = new Cliente();
            txtTelefone1.Text = tel.FormataTelefone(txtTelefone1.Text);
            if (txtTelefone1.Text == "ENTRADA INVÁLIDA")
            {
                MessageBox.Show("Telefone Inválido.", "Gourmet Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefone1.Text = "";
            }
        }

        private void txtTelefone2_Validating(object sender, CancelEventArgs e)
        {
            Cliente tel = new Cliente();
            txtTelefone2.Text = tel.FormataTelefone(txtTelefone2.Text);
            if (txtTelefone2.Text == "ENTRADA INVÁLIDA")
            {
                MessageBox.Show("Telefone Inválido.", "Gourmet Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefone2.Text = "";
            }
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            ClienteDao clienteDao = new ClienteDao();
            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
            clienteDao.Exclui(cliente);
            LimpaCampo();
            txtCliente.Focus();
            opcao = "Incluir";
            CarregaComboboxCliente();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            LimpaCampo();
            txtCliente.Focus();
        }
        #endregion




    }
}
