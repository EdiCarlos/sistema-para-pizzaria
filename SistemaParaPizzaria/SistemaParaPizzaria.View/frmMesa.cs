using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaParaPizzaria.SistemaParaPizzaria.Model;


namespace SistemaParaPizzaria
{
    public partial class frmMesa : Form
    {
        Object codigoProduto;
        public int idPedido;
        decimal valorAnterior;
        decimal valorAtual;
        decimal total;
        AutoCompleteStringCollection ListaNomeCliente;
        AutoCompleteStringCollection ListaCpfCliente;
        AutoCompleteStringCollection ListaTelefoneCliente;

        public frmMesa() { }
        public frmMesa(string numeroMesa)
        {
            InitializeComponent();
            lblNumeroMesa.Text = numeroMesa;
        }


        #region Eventos
        private void frmMesa_Load(object sender, EventArgs e)
        {
            carregaPedido();
            carregaItensDoPedido();
            carregaProdutoCombobox();
            cmbProduto.Text = "";
            CarregaListaCliente();
            ConfiguraTextBoxsGrupoCliente();

        }



        private void btnRetorna_Click(object sender, EventArgs e)
        {
            frmPrincipal atualizaStatusMesa = (frmPrincipal)this.Owner;
            atualizaStatusMesa.carregaStatusMesa();
            this.Close();
        }

        //Calcula o item da venda
        private void txtQtd_TextChanged(object sender, EventArgs e)
        {
            if (txtQtd.Text != "")
            {
                Produto calculo = new Produto();
                decimal qtdDeItem = Convert.ToDecimal(txtQtd.Text);
                lblValorTotal.Text = calculo.CalculaValorDoItem(qtdDeItem, Convert.ToDecimal(lblValorUnitario.Text)).ToString();
            }
        }


        //Pega o codigo do produto
        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoProduto = cmbProduto.SelectedValue.ToString();
        }


        //Pega o valor unitario do prduto
        private void cmbProduto_Validating(object sender, CancelEventArgs e)
        {
            string tipo = "";
            try
            {
                if (cmbProduto.Text != "")
                {
                    ProdutoDao produtoDao = new ProdutoDao();
                    Produto produto = new Produto();
                    produto = produtoDao.GetProduto(Convert.ToInt32(codigoProduto));

                    lblValorUnitario.Text = Convert.ToString(produto.ValorUnitario);
                    tipo = produto.Tipo;
                    listComposicaoProduto.Items.Clear();
                    if (tipo == "Composto")
                    {
                        CarregaListaIngredientes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar produto para venda. - " + ex.Message, "Gourmet Management - **ERRO**",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbProduto.Text = "";
                cmbProduto.Focus();
            }

        }


        //Adiciona item a venda
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtQtd.Text != "")
            {
                ItemPedidoDao itemPedidoDao = new ItemPedidoDao();
                ItemPedido itemPedido = new ItemPedido();

                itemPedido.IdProduto = Convert.ToInt32(codigoProduto);

                itemPedido.QtdProduto = Convert.ToDecimal(txtQtd.Text.Trim());

                itemPedido.IdPedido = idPedido;

                itemPedidoDao.IncluirItemNoPedido(itemPedido);

                carregaItensDoPedido();

                ProdutoDao produtoDao = new ProdutoDao();
                Produto produto = new Produto();

                produto = produtoDao.GetProduto(Convert.ToInt32(codigoProduto));

                produto.BaixarEstoque(Convert.ToDecimal(txtQtd.Text));
                produtoDao.AtualizaEstoque(produto);
                listComposicaoProduto.Items.Clear();
                codigoProduto = "";

                cmbProduto.Text = "";
                lblValorUnitario.Text = "";
                txtQtd.Text = "";
                lblValorTotal.Text = "";
                cmbProduto.Focus();

            }
            else
            {
                MessageBox.Show("O campo quantidade não pode ser vazio", "Gourmet Management - **ERRO**",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtd.Focus();
            }
        }


        //Exclui item da venda
        private void dtgItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgItem.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1)
            {
                ProdutoDao produtoDao = new ProdutoDao();
                Produto produto = new Produto();

                produto = produtoDao.GetProduto(Convert.ToInt32(dtgItem.CurrentRow.Cells[0].Value.ToString()));

                produto.EstornaEstoque(Convert.ToDecimal(dtgItem.CurrentRow.Cells[2].Value.ToString()));
                produtoDao.AtualizaEstoque(produto);


                ItemPedidoDao itemPedidoDao = new ItemPedidoDao();
                ItemPedido itemPedido = new ItemPedido();
                itemPedido.IdProduto = Convert.ToInt32(dtgItem.CurrentRow.Cells[0].Value.ToString());
                itemPedidoDao.RemoveItemDoPedido(itemPedido);
                carregaItensDoPedido();


            }
        }
        //Pegar valor da célula do grid
        private void dtgItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valorAnterior = Convert.ToDecimal(dtgItem.CurrentRow.Cells[2].Value.ToString());
        }

        //Alterar quantidade de itens da venda
        private void dtgItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ProdutoDao produtoDao = new ProdutoDao();
            Produto produto = new Produto();

            ItemPedidoDao itemPedidoDao = new ItemPedidoDao();
            ItemPedido itemPedido = new ItemPedido();

            produto = produtoDao.GetProduto(Convert.ToInt32(dtgItem.CurrentRow.Cells[0].Value.ToString()));
            valorAtual = Convert.ToDecimal(dtgItem.CurrentRow.Cells[2].Value.ToString());

            if (valorAtual > valorAnterior)
            {
                total = valorAtual - valorAnterior;
                if (dtgItem.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn && e.RowIndex != -1)
                {
                    produto.BaixarEstoque(total);
                    produtoDao.AtualizaEstoque(produto);
                    itemPedido.IdProduto = Convert.ToInt32(dtgItem.CurrentRow.Cells[0].Value.ToString());
                    itemPedido.QtdProduto = Convert.ToDecimal(dtgItem.CurrentRow.Cells[2].Value.ToString());
                    itemPedido.IdPedido = idPedido;
                    itemPedidoDao.AlterarQtdItemDoPedido(itemPedido);
                    carregaItensDoPedido();
                }
            }
            else if (valorAtual < valorAnterior)
            {
                total = valorAnterior - valorAtual;
                if (dtgItem.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn && e.RowIndex != -1)
                {
                    produto.EstornaEstoque(total);
                    produtoDao.AtualizaEstoque(produto);
                    itemPedido.IdProduto = Convert.ToInt32(dtgItem.CurrentRow.Cells[0].Value.ToString());
                    itemPedido.QtdProduto = Convert.ToDecimal(dtgItem.CurrentRow.Cells[2].Value.ToString());
                    itemPedido.IdPedido = idPedido;
                    itemPedidoDao.AlterarQtdItemDoPedido(itemPedido);
                    carregaItensDoPedido();
                }
            }
        }

        private void btnFazerPagamento_Click(object sender, EventArgs e)
        {
            pagamento();
            fecharPedido();
        }

        private void txtCliente_Validating(object sender, CancelEventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteDao clienteDao = new ClienteDao();

            cliente.Nome = txtCliente.Text.Trim();
            clienteDao.BuscaCliente(cliente);
            lblCodCliente.Text = Convert.ToString(cliente.Id).PadLeft(6, '0');
            txtCpf.Text = cliente.Cpf;
            txtTelefone.Text = cliente.Telefone1;
            lblEnderecoCliente.Text = String.Format("ENDEREÇO: {0} Nº{1}, {2}, {3}-{4}",
                                     cliente.Logradouro, cliente.Numero, cliente.Bairro, cliente.Cidade, cliente.Uf);

        }

        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteDao clienteDao = new ClienteDao();

            cliente.Cpf = txtCpf.Text.Trim().Replace(".","").Replace("-","");
            clienteDao.BuscaCliente(cliente);
            lblCodCliente.Text = Convert.ToString(cliente.Id).PadLeft(6, '0');
            txtCliente.Text = cliente.Nome;
            txtTelefone.Text = cliente.Telefone1;
            lblEnderecoCliente.Text = String.Format("ENDEREÇO: {0} Nº{1}, {2}, {3}-{4}",
                                     cliente.Logradouro, cliente.Numero, cliente.Bairro, cliente.Cidade, cliente.Uf);

            txtCpf.Text = cliente.FormatarCpfCnpj(txtCpf.Text.Trim());
            txtTelefone.Text = cliente.FormataTelefone(txtTelefone.Text.Trim());
        }

        private void txtTelefone_Validating(object sender, CancelEventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteDao clienteDao = new ClienteDao();

            cliente.Telefone1 = txtTelefone.Text.Trim();
            cliente.Telefone2 = txtTelefone.Text.Trim();
            clienteDao.BuscaCliente(cliente);
            lblCodCliente.Text = Convert.ToString(cliente.Id).PadLeft(6, '0');
            txtCliente.Text = cliente.Nome;
            txtCpf.Text = cliente.Cpf;
            lblEnderecoCliente.Text = String.Format("ENDEREÇO: {0} Nº{1}, {2}, {3}-{4}",
                                     cliente.Logradouro, cliente.Numero, cliente.Bairro, cliente.Cidade, cliente.Uf);

            txtTelefone.Text = cliente.FormataTelefone(txtTelefone.Text.Trim());
            txtCpf.Text = cliente.FormatarCpfCnpj(txtCpf.Text.Trim());

        }

        #endregion

        #region Funções
        //Carrega item nos campos de venda
        private void carregaPedido()
        {
            PedidoDao pedidoDao = new PedidoDao();
            Pedido pedido = new Pedido();

            pedido = pedidoDao.GetPedido(Convert.ToInt32(lblNumeroMesa.Text)); //Passa o parâmetro para o select e recebe o resultado.

            idPedido = pedido.IdPedido; //Passa o id do pedido para variável global
            lblNumeroMesa.Text = pedido.Mesa.ToString().PadLeft(3, '0');
            lblQtdPessoas.Text = pedido.QtdPessoas.ToString().PadLeft(3, '0');
            lblGarcom.Text = pedido.IdFuncionario.ToString().PadLeft(6, '0');

        }


        //Carrega o combobox produto
        private void carregaProdutoCombobox()
        {
            ProdutoDao produtoDao = new ProdutoDao();
            Produto produto = new Produto();

            cmbProduto.DataSource = produtoDao.FindAll();
            cmbProduto.DisplayMember = "descricao";
            cmbProduto.ValueMember = "idProduto";
            cmbProduto.Text = "";
        }


        //Carrega os itens da venda
        public void carregaItensDoPedido()
        {
            ItemPedidoDao itemPedidoDao = new ItemPedidoDao();
            // ItemPedido itemPedido = new ItemPedido();
            dtgItem.AutoGenerateColumns = false;
            dtgItem.DataSource = itemPedidoDao.ListaGrid(idPedido, lblNumeroMesa.Text);
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

            lblTotalPagar.Text = calculaValorPedido().ToString("N4");
        }


        //Calcula o valor do pedido
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


        /// <summary>
        ///  Altera o status da mesa para aguardando pagamento
        /// </summary>
        private void alteraStatusMesa()
        {

            Mesa mesa = new Mesa();
            MesaDao mesaDao = new MesaDao();
            mesa.StatusMesa = 2;
            mesa.NumeroMesa = Convert.ToInt32(lblNumeroMesa.Text.Trim());
            mesaDao.AlteraStatusMesa(mesa);
        }

        /// <summary>
        /// Validar campo para receber valor somente numérico
        /// </summary>
        /// <param name="e"></param>
        public static void ValorNumerico(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Validar campo para receber valor somente letras
        /// </summary>
        /// <param name="e"></param>
        public static void ValidaCampoLetras(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CarregaListaIngredientes()
        {
            listComposicaoProduto.Items.Clear();
            ProdutoCompostoDao produtoCompostoDao = new ProdutoCompostoDao();
            listComposicaoProduto.Items.AddRange(produtoCompostoDao.BuscaIngredientesProdutoComposto(Convert.ToInt32(codigoProduto)));
        }

        private void CarregaListaCliente()
        {
            ListaNomeCliente = new AutoCompleteStringCollection();
            ListaCpfCliente = new AutoCompleteStringCollection();
            ListaTelefoneCliente = new AutoCompleteStringCollection();

            ClienteDao clienteDao = new ClienteDao();
            ListaNomeCliente = clienteDao.BuscaListaClienteCadastrado();
            ListaCpfCliente = clienteDao.BuscaListaClienteCadastradoPeloCpf();
            ListaTelefoneCliente = clienteDao.BuscaListaClienteCadastradoPeloTelefone();
        }

        private void ConfiguraTextBoxsGrupoCliente()
        {
            txtCliente.AutoCompleteCustomSource = ListaNomeCliente;
            txtCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtCpf.AutoCompleteCustomSource = ListaCpfCliente;
            txtCpf.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCpf.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtTelefone.AutoCompleteCustomSource = ListaTelefoneCliente;
            txtTelefone.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTelefone.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        #endregion

        #region Eventos para mudar o TAB no ENTER
        private void frmMesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }


        private void cmbProduto_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
            }
        }

        private void txtCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
            }
        }

        private void txtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
            }
        }
        #endregion

        #region Fazer Pagamento

        private void pagamento()
        {
            decimal totalPagar = Convert.ToDecimal(lblTotalPagar.Text.Trim());
            decimal valorDinheiro = Convert.ToDecimal(txtDinheiro.Text.Trim());
            decimal valorCartao = Convert.ToDecimal(txtCartao.Text.Trim());
            decimal valorDesconto = Convert.ToDecimal(txtDesconto.Text.Trim());
            Pedido pedido = new Pedido();
            lblTroco.Text = pedido.FazerPagamento(totalPagar, valorDinheiro, valorCartao, valorDesconto).ToString();

        }


        private void fecharPedido()
        {
            if (Convert.ToDecimal(lblTroco.Text) >= 0)
            {
                try
                {
                    Mesa mesa = new Mesa();
                    MesaDao mesaDao = new MesaDao();
                    mesa.StatusMesa = 0;
                    mesa.NumeroMesa = Convert.ToInt32(lblNumeroMesa.Text.Trim());
                    mesaDao.AlteraStatusMesa(mesa);

                    PedidoDao pedidoDao = new PedidoDao();
                    Pedido pedido = new Pedido();
                    pedido.StatusPedido = 1;
                    pedido.IdPedido = idPedido;
                    pedidoDao.AlteraStatusPedido(pedido);
                    MessageBox.Show("Operação efetuada com sucesso.", "Gourmet Management",
                                     MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Operação falhou. - " + ex.Message, "Gourmet Management",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Operação falhou, não consta pagamento para concluir o processo.", "Gourmet Management",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnFecharVendaParcial_Click(object sender, EventArgs e)
        {
            Mesa mesa = new Mesa();
            MesaDao mesaDao = new MesaDao();
            mesa.StatusMesa = 2;
            mesa.NumeroMesa = Convert.ToInt32(lblNumeroMesa.Text.Trim());
            mesaDao.AlteraStatusMesa(mesa);
            MessageBox.Show("Operação efetuada com sucesso. Aguardando pagamento!!!", "Gourmet Management",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValorNumerico(e);
        }




    }
}
