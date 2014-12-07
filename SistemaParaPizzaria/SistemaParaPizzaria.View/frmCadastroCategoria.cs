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
    public partial class frmCadastroCategoria : Form
    {
        public frmCadastroCategoria()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            CategoriaDao categoriaDao = new CategoriaDao();
            Categoria categoria = new Categoria();

            categoria.NomeCategoria = cmbCategoria.Text.Trim();
            categoriaDao.Insert(categoria);
            carregarComboboxCategoria();           
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            if (cmbCategoria.Text != "")
            {
                CategoriaDao categoriaDao = new CategoriaDao();
                Categoria categoria = new Categoria();
                categoria.IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue.ToString());
                categoriaDao.Altera(categoria);
                carregarComboboxCategoria();
            }
        }

        private void carregarComboboxCategoria()
        {
            AutoComplete();  
            CategoriaDao categoriaDao = new CategoriaDao();
            Categoria categoria = new Categoria();
            cmbCategoria.DataSource = categoriaDao.BuscaCategoria("");

            cmbCategoria.DisplayMember = "categoria";
            cmbCategoria.ValueMember = "id";
            cmbCategoria.Text = "";
            cmbCategoria.Focus();
        }

        private void frmCadastroCategoria_Load(object sender, EventArgs e)
        {             
            carregarComboboxCategoria();           
        }

        private void btnRetorna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AutoComplete() 
        {
            CategoriaDao categoriaDao = new CategoriaDao();
            cmbCategoria.AutoCompleteCustomSource = categoriaDao.PreencheListaCategoria();
            cmbCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategoria.AutoCompleteSource = AutoCompleteSource.CustomSource;   
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            cmbCategoria.Text = "";
            cmbCategoria.Focus();
        }    
    }
}
