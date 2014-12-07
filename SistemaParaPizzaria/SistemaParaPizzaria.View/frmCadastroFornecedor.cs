using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ValidacoesLibrary;

namespace SistemaParaPizzaria
{
    public partial class frmCadastroFornecedor : Form
    {
        string opcao;
        Object CodigoFornecedor = null;

        public frmCadastroFornecedor()
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
            cmbCidade.DataSource = cidade.Cidades(cmbUf.Text);
            cmbCidade.DisplayMember = "nome";
            cmbCidade.ValueMember = "id";
        }

        public void CarregaComboboxFornecedor()
        {
            FornecedorDao fornecedor = new FornecedorDao();
            cmbFornecedor.DataSource = fornecedor.Fornecedor("");
            cmbFornecedor.DisplayMember = "nome";
            cmbFornecedor.ValueMember = "id";
            cmbFornecedor.Text = "";
            opcao = "Incluir";
        }

        public void LimpaCampo()
        {
            txtFornecedor.Text = String.Empty;
            txtFantasia.Text = String.Empty;
            txtCnpj.Text = String.Empty;
            txtInscEstadual.Text = String.Empty;
            txtTelefone1.Text = String.Empty;
            txtTelefone2.Text = String.Empty;
            txtContato.Text = String.Empty;
            txtFax.Text = String.Empty;
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
        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            opcao = "Incluir";
            CarregaComboboxFornecedor();
            carregarComboboxEstado();
            carregarComboboxCidade();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            FornecedorDao fornecedorDao = new FornecedorDao();


            fornecedor.RazaoSocial = txtFornecedor.Text.Trim();
            fornecedor.NomeFantasia = txtFantasia.Text.Trim();
            fornecedor.Cnpj = txtCnpj.Text.Trim();
            fornecedor.IncricaoEstadual = txtInscEstadual.Text.Trim();
            fornecedor.Observacao = txtObservacao.Text.Trim();
            fornecedor.Telefone1 = txtTelefone1.Text.Trim();
            fornecedor.Telefone2 = txtTelefone2.Text.Trim();
            fornecedor.Contato = txtContato.Text.Trim();
            fornecedor.Fax = txtFax.Text.Trim();
            fornecedor.Logradouro = txtLogradouro.Text.Trim();
            fornecedor.Numero = txtNumero.Text.Trim();
            fornecedor.Bairro = txtBairro.Text.Trim();
            fornecedor.Complemento = txtComplemento.Text.Trim();
            fornecedor.Uf = cmbUf.Text.Trim();
            fornecedor.Cidade = cmbCidade.Text.Trim();
            fornecedor.Cep = txtCep.Text.Trim();
            fornecedor.Email = txtEmail.Text.Trim();


            if (opcao == "Incluir")
            {
                fornecedorDao.CadastraFornecedor(fornecedor);
                fornecedorDao.CadastraContato(fornecedor);
                fornecedorDao.CadastraEndereco(fornecedor);

                LimpaCampo();
                CarregaComboboxFornecedor();
                txtFornecedor.Focus();
            }
            else if (opcao == "Alterar")
            {
                fornecedor.Id = Convert.ToInt32(CodigoFornecedor);
                fornecedorDao.AlteraFornecedor(fornecedor);
                fornecedorDao.AlteraContato(fornecedor);
                fornecedorDao.AlteraEndereco(fornecedor);
                LimpaCampo();
                CarregaComboboxFornecedor();
            }
        }

        private void btnRetorna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CodigoFornecedor = cmbFornecedor.SelectedValue.ToString();
            opcao = "Alterar";
        }

        private void cmbFornecedor_Validating(object sender, CancelEventArgs e)
        {
            if (cmbFornecedor.Text != "")
            {
                FornecedorDao fornecedorDao = new FornecedorDao();
                Fornecedor fornecedor = new Fornecedor();

                fornecedor.Id = Convert.ToInt32(CodigoFornecedor);

                fornecedor = fornecedorDao.GetFornecedor(fornecedor);
                txtFornecedor.Text = fornecedor.RazaoSocial;
                txtFantasia.Text = fornecedor.NomeFantasia;
                txtCnpj.Text = fornecedor.Cnpj;
                txtInscEstadual.Text = fornecedor.IncricaoEstadual;
                txtObservacao.Text = fornecedor.Observacao;
                txtTelefone1.Text = fornecedor.Telefone1;
                txtTelefone2.Text = fornecedor.Telefone2;
                txtContato.Text = fornecedor.Contato;
                txtFax.Text = fornecedor.Fax;
                txtLogradouro.Text = fornecedor.Logradouro;
                txtNumero.Text = fornecedor.Numero;
                txtBairro.Text = fornecedor.Bairro;
                txtComplemento.Text = fornecedor.Complemento;
                cmbUf.Text = fornecedor.Uf;
                cmbCidade.Text = fornecedor.Cidade;
                txtCep.Text = fornecedor.Cep;
                txtEmail.Text = fornecedor.Email;
            }
        }

        private void cmbUf_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarComboboxCidade();
        }

        private void txtCnpj_Validating(object sender, CancelEventArgs e)
        {
            Fornecedor cnpj = new Fornecedor();
            txtCnpj.Text = cnpj.FormatarCpfCnpj(txtCnpj.Text);
            if (txtCnpj.Text == "ENTRADA INVÁLIDA")
            {
                MessageBox.Show("CNPJ Inválido.", "Gourmet Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCnpj.Text = "";
                //txtCnpj.Focus();
            }
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            FornecedorDao fornecedorDao = new FornecedorDao();
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Id = Convert.ToInt32(CodigoFornecedor);
            fornecedorDao.Exclui(fornecedor);
            LimpaCampo();
            txtFornecedor.Focus();
            opcao = "Incluir";
            CarregaComboboxFornecedor();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            LimpaCampo();
            txtFornecedor.Focus();
        }
        #endregion

        private void txtInscEstadual_Validating(object sender, CancelEventArgs e)
        {
          
            Util inscEst = new Util();
           
            if(inscEst.InscEstadualValida(txtInscEstadual.Text, cmbUf.Text))
            {
             MessageBox.Show("Inscrição Estadual Inválida.", "Gourmet Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInscEstadual.Text = "";
            }
        }





    }
}
