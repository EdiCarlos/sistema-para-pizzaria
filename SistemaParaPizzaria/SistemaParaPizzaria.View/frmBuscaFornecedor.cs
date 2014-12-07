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
    public partial class frmBuscaFornecedor : Form
    {
        public frmBuscaFornecedor()
        {
            InitializeComponent();
        }

        private void CarregaFornecedor()
        {
            string query = "";
            if (rbCodigo.Checked)
            {
                query = "id LIKE '%" + txtPesquisa.Text.Trim() + "%' AND ";
            }
            else if (rbFornecedor.Checked)
            {
                query = "nome LIKE '%" + txtPesquisa.Text.Trim() + "%' AND ";
            }
            else if (txtPesquisa.Text == "")
            {
                query = "";
            }

            FornecedorDao fornecedorDao = new FornecedorDao();
            Fornecedor fornecedor = new Fornecedor();

            dtgBuscaFornecedor.DataSource = fornecedorDao.Fornecedor(query);


            var grid0 = this.dtgBuscaFornecedor.Columns[0];
            grid0.Width = 100;
            grid0.HeaderText = ("Código");
            grid0.DefaultCellStyle.Format = "000000";
            grid0.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            grid0.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var grid1 = this.dtgBuscaFornecedor.Columns[1];
            grid1.Width = 350;
            grid1.HeaderText = ("Fornecedor");
            grid1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft;
            grid1.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregaFornecedor();
        }

        private void frmBuscaFornecedor_Load(object sender, EventArgs e)
        {
            CarregaFornecedor();
        }

        private void btnCadFornecedor_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor fornecedor = new frmCadastroFornecedor();
            fornecedor.Show();
        }

        private void btnRetorna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgBuscaFornecedor_DoubleClick(object sender, EventArgs e)
        {
            frmCadastroProduto produto = (frmCadastroProduto)this.Owner;
            produto.txtIdFornecedor.Text = System.Convert.IsDBNull(dtgBuscaFornecedor.CurrentRow.Cells[0].Value.ToString()) ? null :
                                                                 (dtgBuscaFornecedor.CurrentRow.Cells[0].Value.ToString());

            this.Close();
        }
    }
}
