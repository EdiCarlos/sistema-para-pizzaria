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
    public partial class frmCadastroProduto : Form
    {
        string opcao;

        public frmCadastroProduto()
        {
            InitializeComponent();
        }




        #region Eventos
        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            carregarCombobox();
            CarregaComboboxProduto();
            opcao = "Incluir";

            habilitaCampos();
            habilitaControle();
            txtDescricao.Focus();
            CarregaProduto();
        }

        private void btnCadUnidade_Click(object sender, EventArgs e)
        {
            frmCadastroUnidade cadUnidade = new frmCadastroUnidade();
            cadUnidade.Owner = this;
            cadUnidade.ShowDialog();
        }

        private void btnRetorna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            opcao = "Incluir";
            limpaCampo();
            habilitaControle();
            txtDescricao.Focus();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (opcao == "Incluir")
            {
                if (txtIdCategoria.Text != ""  )
                {
                    ProdutoDao inserir = new ProdutoDao();
                    Produto produto = new Produto();
                    produto.Descricao = txtDescricao.Text.Trim();
                    produto.IdCategoria = Convert.ToInt32(txtIdCategoria.Text.Trim());
                    produto.IdFornecedor = Convert.ToInt32(txtIdFornecedor.Text.Trim());
                    produto.Unidade = cmbUnidade.Text.Trim();
                    // produto.QtdEstoque = 0;
                    produto.ValorUnitario = Convert.ToDecimal(txtValorUnitario.Text.Trim());
                    produto.EstoqueMinimo = Convert.ToDecimal(txtEstoqueMinimo.Text.Trim());
                    produto.ValorCompra = Convert.ToDecimal(txtVcompra.Text.Trim());
                    produto.Porcentagem = Convert.ToDecimal(txtPorcentagem.Text.Trim());
                    produto.Observacao = txtObservacao.Text.Trim();

                    inserir.Insert(produto);
                    inserir.IncluiValorProduto(produto);
                }
                

            }
            else if (opcao == "Alterar")
            {
                if (lblId.Text != "")
                {
                    ProdutoDao altera = new ProdutoDao();
                    Produto produto = new Produto();
                    produto.IdProduto = Convert.ToInt32(lblId.Text.Trim());
                    produto.Descricao = txtDescricao.Text.Trim();
                    produto.IdCategoria = Convert.ToInt32(txtIdCategoria.Text.Trim());
                    produto.IdFornecedor = Convert.ToInt32(txtIdFornecedor.Text.Trim());
                    produto.Unidade = cmbUnidade.Text.Trim();
                    // produto.QtdEstoque = Convert.ToDecimal(txtQtdEstoque.Text.Trim());
                    produto.ValorUnitario = Convert.ToDecimal(txtValorUnitario.Text.Trim());
                    produto.EstoqueMinimo = Convert.ToDecimal(txtEstoqueMinimo.Text.Trim());
                    produto.ValorCompra = Convert.ToDecimal(txtVcompra.Text.Trim());
                    produto.Porcentagem = Convert.ToDecimal(txtPorcentagem.Text.Trim());
                    produto.Observacao = txtObservacao.Text.Trim();

                    altera.Altera(produto);
                    altera.AlteraValorProduto(produto);
                    txtPesquisa.Text = "";
                }
            }

            //Preparar form para novo registro
            opcao = "Incluir";
            limpaCampo();
            habilitaCampos();
            habilitaControle();
            txtDescricao.Focus();
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            ProdutoDao desabilitaProduto = new ProdutoDao();
            Produto produto = new Produto();
            produto.IdProduto = Convert.ToInt32(lblId.Text.Trim());

            desabilitaProduto.Exclui(produto);

            //Preparar form para novo registro
            opcao = "Incluir";
            limpaCampo();
            habilitaCampos();
            habilitaControle();
            txtDescricao.Focus();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregaProduto();
        }

        private void txtIdCategoria_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCategoria.Text != "")
            {
                txtIdCategoria.Text = txtIdCategoria.Text.PadLeft(6, '0');
                CategoriaDao categoriaDao = new CategoriaDao();
                Categoria categoria = new Categoria();
                categoria.IdCategoria = Convert.ToInt32(txtIdCategoria.Text.Trim());
                categoriaDao.BuscaCategoriaIndividual(categoria);

                lblCategoria.Text = categoria.NomeCategoria;
            }
        }

        private void txtIdFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (txtIdFornecedor.Text != "")
            {
                txtIdFornecedor.Text = txtIdFornecedor.Text.PadLeft(6, '0');
                FornecedorDao fornecedorDao = new FornecedorDao();
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.Id = Convert.ToInt32(txtIdFornecedor.Text.Trim());
                fornecedorDao.GetFornecedor(fornecedor);
                lblFornecedor.Text = fornecedor.RazaoSocial;
            }
        }

        private void dtgProduto_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                opcao = "Alterar";
                ProdutoDao produtoDao = new ProdutoDao();
                Produto produto = new Produto();

                produto = produtoDao.GetProduto(Convert.ToInt32(dtgProduto.CurrentRow.Cells[0].Value.ToString()));
                lblId.Text = produto.IdProduto.ToString().PadLeft(6, '0');
                txtDescricao.Text = produto.Descricao;
                txtIdCategoria.Text = produto.IdCategoria.ToString().PadLeft(6, '0');
                txtIdFornecedor.Text = produto.IdFornecedor.ToString().PadLeft(6, '0');
                cmbUnidade.Text = produto.Unidade.ToString();
                txtQtdEstoque.Text = produto.QtdEstoque.ToString();
                txtValorUnitario.Text = produto.ValorUnitario.ToString();
                txtEstoqueMinimo.Text = produto.EstoqueMinimo.ToString();
                txtVcompra.Text = produto.ValorCompra.ToString("N4");
                txtPorcentagem.Text = produto.Porcentagem.ToString("N4");
                txtObservacao.Text = produto.Observacao;

                habilitaCampos();
                desabilitaControle();

                tabControlProduto.SelectedTab = tabPageDadosProduto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(ex.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
            }
        }

        private void txtValorUnitario_Validating(object sender, CancelEventArgs e)
        {
            if (txtVcompra.Text != "")
            {
                Produto produto = new Produto();
                produto.ValorCompra = Convert.ToDecimal(txtVcompra.Text);
                produto.CalculaValorProdutoVendaValor(Convert.ToDecimal(txtValorUnitario.Text.Trim()));
                txtPorcentagem.Text = produto.Porcentagem.ToString("N4");
            }
        }

        private void txtPorcentagem_Validating(object sender, CancelEventArgs e)
        {
            if (txtPorcentagem.Text != "")
            {
                Produto produto = new Produto();
                produto.ValorCompra = Convert.ToDecimal(txtVcompra.Text);
                produto.CalculaValorProdutoVendaPorcentagem(Convert.ToDecimal(txtPorcentagem.Text.Trim()));
                txtValorUnitario.Text = produto.ValorUnitario.ToString("N4");
            }
        }

        private void tabControlProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlProduto.SelectedTab.Name)
            {
                case "tabPageDadosProduto":

                    break;

                case "tabPageValorProduto":

                    break;

                case "tabPageBusca":
                    CarregaProduto();
                    break;

                case "tabPageObservacao":

                    break;
            }
        }
        #endregion

        #region Funções
        public void CarregaComboboxProduto()
        {
            ProdutoDao produto = new ProdutoDao();
            cmbProduto.DataSource = produto.PesquisaProduto("");
            cmbProduto.DisplayMember = "descricao";
            cmbProduto.ValueMember = "idProduto";
            cmbProduto.Text = "";
            opcao = "Incluir";
        }

        private void CarregaProduto()
        {
            string query = "";
            if (txtPesquisa.Text == "")
            {
                query = "";
            }
            else
            {
                query = " descricao LIKE '%" + txtPesquisa.Text + "%' AND ";
            }

            ProdutoDao produtoDao = new ProdutoDao();
            dtgProduto.DataSource = produtoDao.PesquisaProduto(query);

            var grid1 = this.dtgProduto.Columns[0];
            grid1.Width = 100;
            grid1.HeaderText = ("Código");
            grid1.DefaultCellStyle.Format = "000000";
            grid1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            grid1.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var grid2 = this.dtgProduto.Columns[1];
            grid2.Width = 300;
            grid2.HeaderText = ("Descrição");
            grid2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft;
            grid2.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var grid3 = this.dtgProduto.Columns[2];
            grid3.Width = 100;
            grid3.HeaderText = ("Valor");
            grid3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            grid3.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void carregarCombobox()
        {
            UnidadeDao acao = new UnidadeDao();
            Unidade unidade = new Unidade();
            cmbUnidade.DataSource = acao.FindAll();

            cmbUnidade.DisplayMember = "unid";
            cmbUnidade.ValueMember = "idUnidade";

        }
        #endregion

        #region Rotinas
        //Método para limpar os campos
        private void limpaCampo()
        {
            lblId.Text = String.Empty;
            txtDescricao.Text = String.Empty;
            txtIdCategoria.Text = String.Empty;
            lblCategoria.Text = String.Empty;
            txtIdFornecedor.Text = String.Empty;
            lblFornecedor.Text = String.Empty;
            cmbUnidade.Text = String.Empty;
            txtQtdEstoque.Text = String.Empty;
            txtValorUnitario.Text = String.Empty;
            txtEstoqueMinimo.Text = String.Empty;
            txtVcompra.Text = String.Empty;
            txtPorcentagem.Text = String.Empty;
            txtObservacao.Text = String.Empty;
        }

        //Métodos para Habilitar e Desabilitar controles
        private void habilitaControle()
        {
            btnIncluir.Enabled = true;
            btnExclui.Enabled = false;
            btnCancela.Enabled = true;
        }

        private void desabilitaControle()
        {
            btnIncluir.Enabled = true;
            btnExclui.Enabled = true;
            btnCancela.Enabled = true;
        }

        //Métodos para Hbilitar e Desabilitar campos
        private void habilitaCampos()
        {
            txtDescricao.Enabled = true;
            txtIdCategoria.Enabled = true;
            lblCategoria.Enabled = true;
            txtIdFornecedor.Enabled = true;
            lblFornecedor.Enabled = true;
            cmbUnidade.Enabled = true;
            txtQtdEstoque.Enabled = true;
            txtValorUnitario.Enabled = true;
            txtEstoqueMinimo.Enabled = true;
        }

        private void desabilitaCampos()
        {
            txtDescricao.Enabled = false;
            txtIdCategoria.Enabled = false;
            lblCategoria.Enabled = false;
            txtIdFornecedor.Enabled = false;
            lblFornecedor.Enabled = false;
            cmbUnidade.Enabled = false;
            txtQtdEstoque.Enabled = false;
            txtValorUnitario.Enabled = false;
            txtEstoqueMinimo.Enabled = false;
        }
        #endregion



        private void btnBuscaCategoria_Click(object sender, EventArgs e)
        {
            frmBuscaCategoria categoria = new frmBuscaCategoria();
            categoria.Owner = this;
            categoria.Show();
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cmbProduto_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (cmbProduto.Text != "")
                {
                    opcao = "Alterar";

                    ProdutoDao produtoDao = new ProdutoDao();
                    Produto produto = new Produto();

                    produto = produtoDao.GetProduto(Convert.ToInt32(cmbProduto.SelectedValue));
                    lblId.Text = produto.IdProduto.ToString().PadLeft(6, '0');
                    txtDescricao.Text = produto.Descricao;
                    txtIdCategoria.Text = produto.IdCategoria.ToString().PadLeft(6, '0');
                    txtIdFornecedor.Text = produto.IdFornecedor.ToString().PadLeft(6, '0');
                    cmbUnidade.Text = produto.Unidade.ToString();
                    txtQtdEstoque.Text = produto.QtdEstoque.ToString();
                    txtValorUnitario.Text = produto.ValorUnitario.ToString();
                    txtEstoqueMinimo.Text = produto.EstoqueMinimo.ToString();
                    txtVcompra.Text = produto.ValorCompra.ToString("N4");
                    txtPorcentagem.Text = produto.Porcentagem.ToString("N4");
                    txtObservacao.Text = produto.Observacao;

                    cmbProduto.Text = "";
                    habilitaCampos();
                    desabilitaControle();
                    tabControlProduto.SelectedTab = tabPageDadosProduto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(ex.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
            }
        }

        private void btnBuscaFornecedor_Click(object sender, EventArgs e)
        {
            frmBuscaFornecedor fornecedor = new frmBuscaFornecedor();
            fornecedor.Owner = this;
            fornecedor.Show();
        }

        private void txtIdFornecedor_Validating(object sender, CancelEventArgs e)
        {

        }







































    }
}
