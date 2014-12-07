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
    public partial class frmItemCardapio : Form
    {
        object codigo;
        decimal valorAnterior;
        decimal valorAtual;
        decimal total;

        public frmItemCardapio()
        {
            InitializeComponent();
        }

        private void btnRetorna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Eventos
        private void frmItemCardapio_Load(object sender, EventArgs e)
        {
            CarregaComboboxIngredientes();
            CarregaComboboxProdutoComposto();
            cmbProdComposto.Text = "";
            cmbIngredientes.Text = "";
        }

        private void btnCadIngrediente_Click(object sender, EventArgs e)
        {
            frmCadastroProduto cadProduto = new frmCadastroProduto();
            cadProduto.ShowDialog();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text != "" && txtCodCategoria.Text != "")
            {
                ProdutoCompostoDao produtoCompDao = new ProdutoCompostoDao();
                ProdutoComposto produtoComp = new ProdutoComposto();

                produtoComp.Descricao = txtProduto.Text.Trim();
                produtoComp.IdCategoria = Convert.ToInt32(txtCodCategoria.Text.Trim());
                produtoComp.Unidade = "Unid";
                produtoComp.ValorUnitario = 0.0M;
                produtoComp.Tipo = "Composto";
                produtoCompDao.Insert(produtoComp);

                CarregaComboboxProdutoComposto();
                cmbProdComposto.Text = "";
                txtProduto.Text = string.Empty;
                txtQtdProduto.Text = string.Empty;
                txtCodCategoria.Text = string.Empty;
                lblCategoria.Text = string.Empty;
                cmbIngredientes.Focus();
            }

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbIngredientes.Text != "" && cmbProdComposto.Text != "")
            {
                ProdutoCompostoDao produtoCompDao = new ProdutoCompostoDao();
                ProdutoComposto produtoComp = new ProdutoComposto();

                //Inclui ingredientes no produto composto////////////////////////////
                produtoComp.IdProdutoComposto = Convert.ToInt32(cmbProdComposto.SelectedValue.ToString());
                produtoComp.IdProduto = Convert.ToInt32(cmbIngredientes.SelectedValue.ToString());
                produtoComp.QtdIngrediente = Convert.ToDecimal(txtQtdProduto.Text.Trim());
                produtoCompDao.AddItemProdutoComposto(produtoComp);
                carregaItensDoProdutoComposto();
                ////////////////////////////////////////////////////////////////////

                //Atualiza valor do Produto Composto///////////////////////////////
                produtoComp.ValorUnitario = Convert.ToDecimal(lblTotal.Text.Trim());
                produtoComp.IdProduto = produtoComp.IdProdutoComposto;
                produtoCompDao.AlteraPrecoProdutoComposto(produtoComp);
                ///////////////////////////////////////////////////////////////////

                //Inclui Valor na Tabela ValorProduto/////////////////////////////
                ProdutoDao inserir = new ProdutoDao();
                Produto produto = new Produto();

                decimal valorCompra = Convert.ToDecimal(lblTotal.Text.Trim());
                decimal porcentagem = 30.0M;
                decimal valorVenda = valorCompra + (valorCompra * (porcentagem / 100));

                produto.ValorUnitario = valorVenda;

                produto.ValorCompra = Convert.ToDecimal(lblTotal.Text.Trim());
                produto.Porcentagem = porcentagem;

                inserir.IncluiValorProduto(produto);
                //////////////////////////////////////////////////////////////////

                //Baixa o estoque do referido produto/////////////////////////////
                ProdutoDao produtoDao = new ProdutoDao();
                //Produto produto = new Produto();
                produto = produtoDao.GetProduto(Convert.ToInt32(cmbIngredientes.SelectedValue.ToString()));
                produto.BaixarEstoque(Convert.ToDecimal(txtQtdProduto.Text));
                produtoDao.AtualizaEstoque(produto);
                /////////////////////////////////////////////////////////////////

                cmbIngredientes.Text = string.Empty;
                txtQtdProduto.Text = string.Empty;
                lblUnidade.Text = string.Empty;
                cmbIngredientes.Focus();
            }
            else if (cmbProdComposto.Text == "")
            {
                MessageBox.Show("Você tem que selecionar um Produto Composto para adicionar um ingrediente!", "Gourmet Management",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbProdComposto.BackColor = Color.Yellow;
                cmbProdComposto.Focus();
            }
            else if (cmbIngredientes.Text == "")
            {
                MessageBox.Show("Você tem que selecionar um ingrediente para adicionar no Produto Composto!", "Gourmet Management",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbIngredientes.BackColor = Color.Yellow;
                cmbIngredientes.Focus();
            }
        }

        private void cmbIngredientes_Validating(object sender, CancelEventArgs e)
        {
            cmbIngredientes.BackColor = Color.White;
            try
            {
                if (cmbIngredientes.Text != "")
                {
                    ProdutoDao produtoDao = new ProdutoDao();
                    Produto produto = new Produto();

                    produto = produtoDao.GetProduto(Convert.ToInt32(cmbIngredientes.SelectedValue.ToString()));
                    lblUnidade.Text = produto.Unidade;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados. - " + ex.Message, "Gourmet Management - **ERRO**",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbProdComposto.Text = "";
                cmbProdComposto.Focus();
            }
        }


        private void cmbProdComposto_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigo = cmbProdComposto.SelectedValue.ToString();
        }

        private void cmbProdComposto_Validating(object sender, CancelEventArgs e)
        {
            cmbProdComposto.BackColor = Color.White;
            try
            {
                if (cmbProdComposto.Text != "")
                {
                    carregaItensDoProdutoComposto();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar ingredientes do produto. - " + ex.Message, "Gourmet Management - **ERRO**",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbProdComposto.Text = "";
                cmbProdComposto.Focus();
            }
        }
        #endregion

        #region Funções
        private void CarregaComboboxIngredientes()
        {
            ProdutoDao produtoDao = new ProdutoDao();
            cmbIngredientes.DataSource = produtoDao.Produtos();
            cmbIngredientes.DisplayMember = "descricao";
            cmbIngredientes.ValueMember = "idProduto";
        }

        private void CarregaComboboxProdutoComposto()
        {
            ProdutoCompostoDao produtoDao = new ProdutoCompostoDao();
            cmbProdComposto.DataSource = produtoDao.ProdutoComposto();
            cmbProdComposto.DisplayMember = "descricao";
            cmbProdComposto.ValueMember = "idProduto";
        }

        public void carregaItensDoProdutoComposto()
        {
            if (cmbProdComposto.Text != "")
            {
                ProdutoCompostoDao produto = new ProdutoCompostoDao();

                dtgItem.AutoGenerateColumns = false;
                dtgItem.DataSource = produto.ItensProdutoComposto(Convert.ToInt32(codigo));
                var grid1 = this.dtgItem.Columns[0];
                grid1.DefaultCellStyle.Format = "000000";
                grid1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
                grid1.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                var grid2 = this.dtgItem.Columns[2];
                grid2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
                grid2.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                var grid3 = this.dtgItem.Columns[4];
                grid3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
                grid3.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                var grid4 = this.dtgItem.Columns[5];
                grid4.DefaultCellStyle.Format = "N4";
                grid4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
                grid4.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                lblTotal.Text = calculaValorPedido().ToString("N4");
            }
        }

        //Calcula o valor do produto composto
        private decimal calculaValorPedido()
        {
            decimal valorTotal = 0;
            int i = 0;
            for (i = 0; i < dtgItem.Rows.Count; i++)
            {
                valorTotal = valorTotal + Convert.ToDecimal(dtgItem.Rows[i].Cells[5].Value.ToString());
            }
            return valorTotal;
        }
        #endregion

        #region Eventos para mudar TAB no ENTER
        private void cmbProdComposto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
            }
        }

        private void cmbIngredientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
            }
        }


        //Mudar tab no enter. A propriedade Preview do form tem estar como TRUE
        private void frmItemCardapio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }
        #endregion

        #region Eventos do DataGridView
        private void dtgItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ProdutoDao produtoDao = new ProdutoDao();
            Produto produto = new Produto();

            ProdutoCompostoDao prodCompDao = new ProdutoCompostoDao();
            ProdutoComposto prodComp = new ProdutoComposto();

            produto = produtoDao.GetProduto(Convert.ToInt32(dtgItem.CurrentRow.Cells[0].Value.ToString()));
            valorAtual = Convert.ToDecimal(dtgItem.CurrentRow.Cells[2].Value.ToString());

            if (valorAtual > valorAnterior)
            {
                total = valorAtual - valorAnterior;
                if (dtgItem.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn && e.RowIndex != -1)
                {
                    produto.BaixarEstoque(total);
                    produtoDao.AtualizaEstoque(produto);
                    prodComp.IdProdutoComposto = Convert.ToInt32(codigo);
                    prodComp.QtdIngrediente = Convert.ToDecimal(dtgItem.CurrentRow.Cells[2].Value.ToString());
                    prodComp.IdProduto = Convert.ToInt32(dtgItem.CurrentRow.Cells[0].Value.ToString());
                    prodCompDao.AlterarQtdItemDoProdutoComposto(prodComp);
                    carregaItensDoProdutoComposto();
                }
            }
            else if (valorAtual < valorAnterior)
            {
                total = valorAnterior - valorAtual;
                if (dtgItem.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn && e.RowIndex != -1)
                {
                    produto.EstornaEstoque(total);
                    produtoDao.AtualizaEstoque(produto);
                    prodComp.IdProdutoComposto = Convert.ToInt32(codigo);
                    prodComp.QtdIngrediente = Convert.ToDecimal(dtgItem.CurrentRow.Cells[2].Value.ToString());
                    prodComp.IdProduto = Convert.ToInt32(dtgItem.CurrentRow.Cells[0].Value.ToString());
                    prodCompDao.AlterarQtdItemDoProdutoComposto(prodComp);
                    carregaItensDoProdutoComposto();
                }
            }
        }

        private void dtgItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valorAnterior = Convert.ToDecimal(dtgItem.CurrentRow.Cells[2].Value.ToString());
        }

        private void dtgItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgItem.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1)
            {
                ProdutoDao produtoDao = new ProdutoDao();
                Produto produto = new Produto();

                produto = produtoDao.GetProduto(Convert.ToInt32(dtgItem.CurrentRow.Cells[0].Value.ToString()));

                produto.EstornaEstoque(Convert.ToDecimal(dtgItem.CurrentRow.Cells[2].Value.ToString()));
                produtoDao.AtualizaEstoque(produto);


                ProdutoCompostoDao prodCompDao = new ProdutoCompostoDao();
                ProdutoComposto prodComp = new ProdutoComposto();
                prodComp.IdProdutoComposto = Convert.ToInt32(codigo);
                prodComp.IdProduto = Convert.ToInt32(dtgItem.CurrentRow.Cells[0].Value.ToString());
                prodCompDao.RemoveItemDoProdutoComposto(prodComp);
                carregaItensDoProdutoComposto();
            }
        }
        #endregion


        private void txtCodCategoria_Validating(object sender, CancelEventArgs e)
        {
            txtCodCategoria.Text = txtCodCategoria.Text.PadLeft(6, '0');
            CategoriaDao categoriaDao = new CategoriaDao();
            Categoria categoria = new Categoria();
            categoria.IdCategoria = Convert.ToInt32(txtCodCategoria.Text.Trim());
            categoriaDao.BuscaCategoriaIndividual(categoria);

            lblCategoria.Text = categoria.NomeCategoria;
        }


    }
}
