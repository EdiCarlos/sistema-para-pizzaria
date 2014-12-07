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
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            carregaStatusMesa();

        }

        //Mudar o tab no Enter
        private void frmPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                logar();
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }


        //Eventos
        #region Eventos de Mesas

        private void pcMesa1_Click_1(object sender, EventArgs e)
        {
            string mesa = lblMesa1.Text;
            controlaMesa(mesa);
        }

        private void pcMesa2_Click_1(object sender, EventArgs e)
        {
            string mesa = lblMesa2.Text;
            controlaMesa(mesa);
        }

        private void pcMesa3_Click(object sender, EventArgs e)
        {
            string mesa = lblMesa3.Text;
            controlaMesa(mesa);
        }

        private void pcMesa4_Click(object sender, EventArgs e)
        {
            string mesa = lblMesa4.Text;
            controlaMesa(mesa);
        }

        private void pcMesa5_Click(object sender, EventArgs e)
        {
            string mesa = lblMesa5.Text;
            controlaMesa(mesa);
        }

        private void pcMesa6_Click(object sender, EventArgs e)
        {
            string mesa = lblMesa6.Text;
            controlaMesa(mesa);
        }

        private void pcMesa7_Click(object sender, EventArgs e)
        {
            string mesa = lblMesa7.Text;
            controlaMesa(mesa);
        }

        private void pcMesa8_Click(object sender, EventArgs e)
        {
            string mesa = lblMesa8.Text;
            controlaMesa(mesa);
        }

        private void pcMesa9_Click(object sender, EventArgs e)
        {
            string mesa = lblMesa9.Text;
            controlaMesa(mesa);
        }

        private void pcMesa10_Click(object sender, EventArgs e)
        {
            string mesa = lblMesa10.Text;
            controlaMesa(mesa);
        }

        private void pcMesa11_Click(object sender, EventArgs e)
        {
            string mesa = lblMesa11.Text;
            controlaMesa(mesa);
        }

        private void pcMesa12_Click(object sender, EventArgs e)
        {
            string mesa = lblMesa12.Text;
            controlaMesa(mesa);
        }

        private void pcMesa13_Click(object sender, EventArgs e)
        {
            string mesa = lblMesa13.Text;
            controlaMesa(mesa);
        }

        private void pcMesa14_Click(object sender, EventArgs e)
        {
            string mesa = lblMesa14.Text;
            controlaMesa(mesa);
        }

        private void pcMesa15_Click(object sender, EventArgs e)
        {
            string mesa = lblMesa15.Text;
            controlaMesa(mesa);
        }

        private void pcMesa16_Click(object sender, EventArgs e)
        {
            string mesa = lblMesa16.Text;
            controlaMesa(mesa);
        }

        private void pcMesa17_Click(object sender, EventArgs e)
        {
            string mesa = lblMesa17.Text;
            controlaMesa(mesa);
        }

        private void pcMesa18_Click(object sender, EventArgs e)
        {
            string mesa = lblMesa18.Text;
            controlaMesa(mesa);
        }
        #endregion

        #region Eventos do MenuStrip
        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do sistema?", Mensagem.GetMensagemTitulo("Sair"),
                                 MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto cadProduto = new frmCadastroProduto();
            cadProduto.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor cadFornecedor = new frmCadastroFornecedor();
            cadFornecedor.ShowDialog();
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemCardapio cadItemCardapio = new frmItemCardapio();
            cadItemCardapio.ShowDialog();
        }
        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario cadFuncionario = new frmCadastroFuncionario();
            cadFuncionario.ShowDialog();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioProduto relProduto = new frmRelatorioProduto();
            relProduto.ShowDialog();
        }

        private void movimentoDoCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioMovimentoCaixa relMovCaixa = new frmRelatorioMovimentoCaixa();
            relMovCaixa.ShowDialog();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioVendas relVenda = new frmRelatorioVendas();
            relVenda.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria cadCategoria = new frmCadastroCategoria();
            cadCategoria.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cadCliente = new frmCadastroCliente();
            cadCliente.Show();
        }
        #endregion

        #region Outros Eventos

        private void timerData_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do sistema?",
                Mensagem.GetMensagemTitulo("Sair"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }

        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult frmclose = MessageBox.Show("Tem certeza que deseja sair do sistema?",
                Mensagem.GetMensagemTitulo("Sair"), MessageBoxButtons.YesNo);
            if (frmclose == DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }

        }
        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            frmMesa mesa = new frmMesa("00");
            mesa.Owner = this;
            abrirPedidoBalcao();
            mesa.ShowDialog();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor cadFornecedor = new frmCadastroFornecedor();
            cadFornecedor.ShowDialog();
        }

        private void btnAddItemCardapio_Click(object sender, EventArgs e)
        {
            frmItemCardapio cadItemCardapio = new frmItemCardapio();
            cadItemCardapio.ShowDialog();
        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario cadFuncionario = new frmCadastroFuncionario();
            cadFuncionario.ShowDialog();
        }

        private void btnMovimentacaoCaixa_Click(object sender, EventArgs e)
        {
            frmMovimentacaoCaixa movimentacaoCaixa = new frmMovimentacaoCaixa();
            movimentacaoCaixa.ShowDialog();
        }

        #endregion

        //Métodos
        #region Login
        private void btnLogar_Click(object sender, EventArgs e)
        {
            logar();
        }

        private void logar()
        {
            bool retorno;

            if (txtUsuario.Text != "" || txtSenha.Text != "")
            {
                retorno = Login.Logar(txtUsuario.Text.Trim(), txtSenha.Text.Trim());
                if (retorno == true)
                {
                    grupoUsuario.Visible = false;
                    painelMesas.Visible = true;
                    painelMenu.Enabled = true;
                    menuStrip1.Enabled = true;
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                    lblLogin.Text = "Login: " + Login.User.ToString() + " / " + Login.Tipo.ToString();
                    PermissaoAcessoSistema();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha inválido(s).", Mensagem.GetMensagemTitulo("Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Usuário e Senha não pode(m) ficar vazio(s).", Mensagem.GetMensagemTitulo("Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja efetuar logoff?", Mensagem.GetMensagemTitulo("Logout"),
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login.Logout();
                grupoUsuario.Visible = true;
                painelMesas.Visible = false;
                painelMenu.Enabled = false;
                menuStrip1.Enabled = false;
                lblLogin.Text = "";
            }
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja efetuar logoff?", Mensagem.GetMensagemTitulo("Logout"),
                                 MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login.Logout();
                grupoUsuario.Visible = true;
                painelMesas.Visible = false;
                painelMenu.Enabled = false;
                menuStrip1.Enabled = false;
                lblLogin.Text = "";
            }
        }
        #endregion

        #region Funções
        /// <summary>
        /// Controla a mesa se está aberta ou fechada, e chama o form de itens ou de abertura
        /// </summary>
        /// <param name="_mesa">número da mesa a ser chamada no procedimento</param>
        private void controlaMesa(string _mesa)
        {
            int statusMesa;
            MesaDao mesaDao = new MesaDao();
            statusMesa = mesaDao.GetStatusMesa(Convert.ToInt32(_mesa));

            if (statusMesa == 0)
            {
                frmAbrirMesa mesa = new frmAbrirMesa(_mesa);
                mesa.Owner = this;
                mesa.ShowDialog();
            }
            else if (statusMesa == 1 || statusMesa == 2)
            {
                frmMesa mesa = new frmMesa(_mesa);
                mesa.Owner = this;
                mesa.ShowDialog();
            }
        }

        /// <summary>
        /// Carrega o status das mesas do ambiente
        /// </summary>
        public void carregaStatusMesa()
        {
            int[] status = new int[18];
            Mesa mesa = new Mesa();
            status = mesa.VerificaStatusMesa();

            //Mesa 01
            switch (status[0])
            {
                case 0:
                    lblStatusMesa1.BackColor = Color.Lime;
                    break;
                case 1:
                    lblStatusMesa1.BackColor = Color.Red;
                    break;
                case 2:
                    lblStatusMesa1.BackColor = Color.Yellow;
                    break;
            }

            //Mesa 02
            switch (status[1])
            {
                case 0:
                    lblStatusMesa2.BackColor = Color.Lime;
                    break;
                case 1:
                    lblStatusMesa2.BackColor = Color.Red;
                    break;
                case 2:
                    lblStatusMesa2.BackColor = Color.Yellow;
                    break;
            }

            //Mesa 03
            switch (status[2])
            {
                case 0:
                    lblStatusMesa3.BackColor = Color.Lime;
                    break;
                case 1:
                    lblStatusMesa3.BackColor = Color.Red;
                    break;
                case 2:
                    lblStatusMesa3.BackColor = Color.Yellow;
                    break;
            }

            //Mesa 04
            switch (status[3])
            {
                case 0:
                    lblStatusMesa4.BackColor = Color.Lime;
                    break;
                case 1:
                    lblStatusMesa4.BackColor = Color.Red;
                    break;
                case 2:
                    lblStatusMesa4.BackColor = Color.Yellow;
                    break;
            }

            //Mesa 05
            switch (status[4])
            {
                case 0:
                    lblStatusMesa5.BackColor = Color.Lime;
                    break;
                case 1:
                    lblStatusMesa5.BackColor = Color.Red;
                    break;
                case 2:
                    lblStatusMesa5.BackColor = Color.Yellow;
                    break;
            }

            //Mesa 06
            switch (status[5])
            {
                case 0:
                    lblStatusMesa6.BackColor = Color.Lime;
                    break;
                case 1:
                    lblStatusMesa6.BackColor = Color.Red;
                    break;
                case 2:
                    lblStatusMesa6.BackColor = Color.Yellow;
                    break;
            }

            //Mesa 07
            switch (status[6])
            {
                case 0:
                    lblStatusMesa7.BackColor = Color.Lime;
                    break;
                case 1:
                    lblStatusMesa7.BackColor = Color.Red;
                    break;
                case 2:
                    lblStatusMesa7.BackColor = Color.Yellow;
                    break;
            }

            //Mesa 08
            switch (status[7])
            {
                case 0:
                    lblStatusMesa8.BackColor = Color.Lime;
                    break;
                case 1:
                    lblStatusMesa8.BackColor = Color.Red;
                    break;
                case 2:
                    lblStatusMesa8.BackColor = Color.Yellow;
                    break;
            }

            //Mesa 09
            switch (status[8])
            {
                case 0:
                    lblStatusMesa9.BackColor = Color.Lime;
                    break;
                case 1:
                    lblStatusMesa9.BackColor = Color.Red;
                    break;
                case 2:
                    lblStatusMesa9.BackColor = Color.Yellow;
                    break;
            }

            //Mesa 10
            switch (status[9])
            {
                case 0:
                    lblStatusMesa10.BackColor = Color.Lime;
                    break;
                case 1:
                    lblStatusMesa10.BackColor = Color.Red;
                    break;
                case 2:
                    lblStatusMesa10.BackColor = Color.Yellow;
                    break;
            }

            //Mesa 11
            switch (status[10])
            {
                case 0:
                    lblStatusMesa11.BackColor = Color.Lime;
                    break;
                case 1:
                    lblStatusMesa11.BackColor = Color.Red;
                    break;
                case 2:
                    lblStatusMesa11.BackColor = Color.Yellow;
                    break;
            }

            //Mesa 12
            switch (status[11])
            {
                case 0:
                    lblStatusMesa12.BackColor = Color.Lime;
                    break;
                case 1:
                    lblStatusMesa12.BackColor = Color.Red;
                    break;
                case 2:
                    lblStatusMesa12.BackColor = Color.Yellow;
                    break;
            }

            //Mesa 13
            switch (status[12])
            {
                case 0:
                    lblStatusMesa13.BackColor = Color.Lime;
                    break;
                case 1:
                    lblStatusMesa13.BackColor = Color.Red;
                    break;
                case 2:
                    lblStatusMesa13.BackColor = Color.Yellow;
                    break;
            }

            //Mesa 14
            switch (status[13])
            {
                case 0:
                    lblStatusMesa14.BackColor = Color.Lime;
                    break;
                case 1:
                    lblStatusMesa14.BackColor = Color.Red;
                    break;
                case 2:
                    lblStatusMesa14.BackColor = Color.Yellow;
                    break;
            }

            //Mesa 15
            switch (status[14])
            {
                case 0:
                    lblStatusMesa15.BackColor = Color.Lime;
                    break;
                case 1:
                    lblStatusMesa15.BackColor = Color.Red;
                    break;
                case 2:
                    lblStatusMesa15.BackColor = Color.Yellow;
                    break;
            }

            //Mesa 16
            switch (status[15])
            {
                case 0:
                    lblStatusMesa16.BackColor = Color.Lime;
                    break;
                case 1:
                    lblStatusMesa16.BackColor = Color.Red;
                    break;
                case 2:
                    lblStatusMesa16.BackColor = Color.Yellow;
                    break;
            }

            //Mesa 17
            switch (status[16])
            {
                case 0:
                    lblStatusMesa17.BackColor = Color.Lime;
                    break;
                case 1:
                    lblStatusMesa17.BackColor = Color.Red;
                    break;
                case 2:
                    lblStatusMesa17.BackColor = Color.Yellow;
                    break;
            }

            //Mesa 18
            switch (status[17])
            {
                case 0:
                    lblStatusMesa18.BackColor = Color.Lime;
                    break;
                case 1:
                    lblStatusMesa18.BackColor = Color.Red;
                    break;
                case 2:
                    lblStatusMesa18.BackColor = Color.Yellow;
                    break;
            }
        }

        /// <summary>
        /// abre o pedido no balcão
        /// </summary>
        private void abrirPedidoBalcao()
        {
            Pedido pedido = new Pedido();
            PedidoDao pedidoDao = new PedidoDao();
            pedido.DataPedido = DateTime.Now;
            pedido.Mesa = Convert.ToInt32("00");
            pedido.QtdPessoas = Convert.ToInt32("00");
            pedido.IdFuncionario = 1;//Convert.ToInt32(pedido.IdFuncionario);        
            pedidoDao.GravaPedido(pedido);
        }

        /// <summary>
        /// permissão de acesso do sistema
        /// </summary>
        private void PermissaoAcessoSistema()
        {
            if (Login.Tipo == "Limitado")
            {
                btnAddItemCardapio.Enabled = false;
                btnCadFuncionario.Enabled = false;
                btnFornecedor.Enabled = false;

                cadastroToolStripMenuItem.Enabled = false;
            }
            else if (Login.Tipo == "Admin")
            {
                btnAddItemCardapio.Enabled = true;
                btnCadFuncionario.Enabled = true;
                btnFornecedor.Enabled = true;

                cadastroToolStripMenuItem.Enabled = true;
            }
        }
        #endregion

    }
}
