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
    public partial class frmCadastroUnidade : Form
    {

        object codigoUnidade;
        public frmCadastroUnidade()
        {
            InitializeComponent();
        }

        private void btnRetorna_Click(object sender, EventArgs e)
        {
            frmCadastroProduto carregaCombo = (frmCadastroProduto)this.Owner;
            carregaCombo.carregarCombobox();
            this.Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            UnidadeDao acao = new UnidadeDao();
            Unidade unidade = new Unidade();
            unidade.Unid = cmbUnidade.Text.Trim();
            acao.Insert(unidade);
            carregarCombobox();
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            if (cmbUnidade.Text != "")
            {
                UnidadeDao acao = new UnidadeDao();
                Unidade unidade = new Unidade();
                unidade.IdUnidade = Convert.ToInt32(codigoUnidade);

                acao.Altera(unidade);
                carregarCombobox();
            }
        }


        private void carregarCombobox()
        {
            AutoComplete();
            UnidadeDao acao = new UnidadeDao();
            Unidade unidade = new Unidade();
            cmbUnidade.DataSource = acao.FindAll();

            cmbUnidade.DisplayMember = "unid";
            cmbUnidade.ValueMember = "idUnidade";
            cmbUnidade.Text = "";
            cmbUnidade.Focus();
        }

        private void frmCadastroUnidade_Load(object sender, EventArgs e)
        {        
            carregarCombobox();
        }

        private void cmbUnidade_SelectedIndexChanged(object sender, EventArgs e)
        {

            codigoUnidade = cmbUnidade.SelectedValue.ToString();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            cmbUnidade.Text = string.Empty;
            cmbUnidade.Focus();
        }

        private void AutoComplete()
        {
            UnidadeDao unidadeDao = new UnidadeDao();
            cmbUnidade.AutoCompleteCustomSource = unidadeDao.PreencheListaUnidade();
            cmbUnidade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUnidade.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }



    }
}
