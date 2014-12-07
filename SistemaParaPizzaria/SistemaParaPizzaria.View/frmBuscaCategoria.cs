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
    public partial class frmBuscaCategoria : Form
    {
        public frmBuscaCategoria()
        {
            InitializeComponent();
        }

        private void CarregaCategoria()
        {
            string query = "";
            if (rbCodigo.Checked)
            {
                query = "id LIKE '%" + txtPesquisa.Text.Trim() + "%' AND ";
            }
            else if (rbCategoria.Checked)
            {
                query = "categoria LIKE '%" + txtPesquisa.Text.Trim() + "%' AND ";
            }
            else if (txtPesquisa.Text == "")
            {
                query = "";
            }

            CategoriaDao categoriaDao = new CategoriaDao();
            Categoria categoria = new Categoria();

            dtgBuscaCategoria.DataSource = categoriaDao.BuscaCategoria(query);


            var grid0 = this.dtgBuscaCategoria.Columns[0];
            grid0.Width = 100;
            grid0.HeaderText = ("Código");
            grid0.DefaultCellStyle.Format = "000000";
            grid0.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            grid0.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var grid1 = this.dtgBuscaCategoria.Columns[1];
            grid1.Width = 350;
            grid1.HeaderText = ("Descrição");
            grid1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft;
            grid1.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregaCategoria();
        }

        private void frmBuscaCategoria_Load(object sender, EventArgs e)
        {
            CarregaCategoria();
        }

        private void btnCadCategoria_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria categoria = new frmCadastroCategoria();
            categoria.Show();
        }

        private void btnRetorna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgBuscaCategoria_DoubleClick(object sender, EventArgs e)
        {
            frmCadastroProduto produto = (frmCadastroProduto)this.Owner;
            produto.txtIdCategoria.Text = System.Convert.IsDBNull(dtgBuscaCategoria.CurrentRow.Cells[0].Value.ToString()) ? null :
                                                                 (dtgBuscaCategoria.CurrentRow.Cells[0].Value.ToString());

            this.Close();
        }


    }
}
