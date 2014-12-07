namespace SistemaParaPizzaria
{
    partial class frmMesa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listComposicaoProduto = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFazerPagamento = new System.Windows.Forms.Button();
            this.txtCartao = new System.Windows.Forms.TextBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.rbMastercard = new System.Windows.Forms.RadioButton();
            this.rbVisa = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRetorna = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grupoDetalheVenda = new System.Windows.Forms.GroupBox();
            this.btnFecharVendaParcial = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumeroMesa = new System.Windows.Forms.Label();
            this.lblGarcom = new System.Windows.Forms.Label();
            this.lblQtdPessoas = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgItem = new System.Windows.Forms.DataGridView();
            this.codProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excluirItem = new System.Windows.Forms.DataGridViewImageColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblEnderecoCliente = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grupoDetalheVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItem)).BeginInit();
            this.groupBoxCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listComposicaoProduto);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.grupoDetalheVenda);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtgItem);
            this.groupBox1.Location = new System.Drawing.Point(11, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1194, 498);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // listComposicaoProduto
            // 
            this.listComposicaoProduto.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listComposicaoProduto.ForeColor = System.Drawing.Color.Black;
            this.listComposicaoProduto.FormattingEnabled = true;
            this.listComposicaoProduto.ItemHeight = 17;
            this.listComposicaoProduto.Location = new System.Drawing.Point(17, 272);
            this.listComposicaoProduto.Name = "listComposicaoProduto";
            this.listComposicaoProduto.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listComposicaoProduto.Size = new System.Drawing.Size(266, 208);
            this.listComposicaoProduto.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFazerPagamento);
            this.groupBox3.Controls.Add(this.txtCartao);
            this.groupBox3.Controls.Add(this.txtDinheiro);
            this.groupBox3.Controls.Add(this.txtDesconto);
            this.groupBox3.Controls.Add(this.rbMastercard);
            this.groupBox3.Controls.Add(this.rbVisa);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lblTroco);
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(881, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 237);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pagamento";
            // 
            // btnFazerPagamento
            // 
            this.btnFazerPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFazerPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFazerPagamento.Location = new System.Drawing.Point(180, 198);
            this.btnFazerPagamento.Name = "btnFazerPagamento";
            this.btnFazerPagamento.Size = new System.Drawing.Size(112, 33);
            this.btnFazerPagamento.TabIndex = 4;
            this.btnFazerPagamento.Text = "Pagamento";
            this.btnFazerPagamento.UseVisualStyleBackColor = true;
            this.btnFazerPagamento.Click += new System.EventHandler(this.btnFazerPagamento_Click);
            // 
            // txtCartao
            // 
            this.txtCartao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCartao.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartao.ForeColor = System.Drawing.Color.Red;
            this.txtCartao.Location = new System.Drawing.Point(135, 69);
            this.txtCartao.Name = "txtCartao";
            this.txtCartao.Size = new System.Drawing.Size(157, 31);
            this.txtCartao.TabIndex = 1;
            this.txtCartao.Text = "00,0000";
            this.txtCartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDinheiro.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinheiro.ForeColor = System.Drawing.Color.Red;
            this.txtDinheiro.Location = new System.Drawing.Point(135, 26);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(157, 31);
            this.txtDinheiro.TabIndex = 0;
            this.txtDinheiro.Text = "00,0000";
            this.txtDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDesconto
            // 
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesconto.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.ForeColor = System.Drawing.Color.Red;
            this.txtDesconto.Location = new System.Drawing.Point(135, 112);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(157, 31);
            this.txtDesconto.TabIndex = 2;
            this.txtDesconto.Text = "00,0000";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbMastercard
            // 
            this.rbMastercard.AutoSize = true;
            this.rbMastercard.Image = global::SistemaParaPizzaria.Properties.Resources.mastercard_curved;
            this.rbMastercard.Location = new System.Drawing.Point(80, 194);
            this.rbMastercard.Name = "rbMastercard";
            this.rbMastercard.Size = new System.Drawing.Size(65, 32);
            this.rbMastercard.TabIndex = 5;
            this.rbMastercard.TabStop = true;
            this.rbMastercard.UseVisualStyleBackColor = true;
            // 
            // rbVisa
            // 
            this.rbVisa.AutoSize = true;
            this.rbVisa.Image = global::SistemaParaPizzaria.Properties.Resources.visa_curved;
            this.rbVisa.Location = new System.Drawing.Point(11, 194);
            this.rbVisa.Name = "rbVisa";
            this.rbVisa.Size = new System.Drawing.Size(65, 32);
            this.rbVisa.TabIndex = 5;
            this.rbVisa.TabStop = true;
            this.rbVisa.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(6, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Troco:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(6, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Desconto:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(6, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Cartão:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(6, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Dinheiro:";
            // 
            // lblTroco
            // 
            this.lblTroco.BackColor = System.Drawing.Color.White;
            this.lblTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTroco.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.Color.Red;
            this.lblTroco.Location = new System.Drawing.Point(135, 154);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(157, 31);
            this.lblTroco.TabIndex = 1;
            this.lblTroco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRetorna);
            this.groupBox2.Controls.Add(this.btnAddItem);
            this.groupBox2.Controls.Add(this.cmbProduto);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtQtd);
            this.groupBox2.Controls.Add(this.lblValorUnitario);
            this.groupBox2.Controls.Add(this.lblValorTotal);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 237);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicionar Item";
            // 
            // btnRetorna
            // 
            this.btnRetorna.BackColor = System.Drawing.Color.Transparent;
            this.btnRetorna.Image = global::SistemaParaPizzaria.Properties.Resources.undo;
            this.btnRetorna.Location = new System.Drawing.Point(407, 190);
            this.btnRetorna.Name = "btnRetorna";
            this.btnRetorna.Size = new System.Drawing.Size(80, 38);
            this.btnRetorna.TabIndex = 38;
            this.toolTip1.SetToolTip(this.btnRetorna, "Sair");
            this.btnRetorna.UseVisualStyleBackColor = false;
            this.btnRetorna.Click += new System.EventHandler(this.btnRetorna_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Image = global::SistemaParaPizzaria.Properties.Resources.list_add;
            this.btnAddItem.Location = new System.Drawing.Point(172, 135);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(40, 40);
            this.btnAddItem.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAddItem, "Adicionar Item");
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // cmbProduto
            // 
            this.cmbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProduto.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.IntegralHeight = false;
            this.cmbProduto.ItemHeight = 18;
            this.cmbProduto.Location = new System.Drawing.Point(9, 37);
            this.cmbProduto.MaxDropDownItems = 5;
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(475, 26);
            this.cmbProduto.TabIndex = 0;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            this.cmbProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCpf_KeyDown);
            this.cmbProduto.Validating += new System.ComponentModel.CancelEventHandler(this.cmbProduto_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quantidade";
            // 
            // txtQtd
            // 
            this.txtQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtd.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.ForeColor = System.Drawing.Color.Red;
            this.txtQtd.Location = new System.Drawing.Point(9, 140);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(157, 31);
            this.txtQtd.TabIndex = 1;
            this.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQtd.TextChanged += new System.EventHandler(this.txtQtd_TextChanged);
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd_KeyPress);
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.BackColor = System.Drawing.Color.White;
            this.lblValorUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorUnitario.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorUnitario.ForeColor = System.Drawing.Color.Red;
            this.lblValorUnitario.Location = new System.Drawing.Point(9, 89);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(157, 32);
            this.lblValorUnitario.TabIndex = 100;
            this.lblValorUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.BackColor = System.Drawing.Color.White;
            this.lblValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorTotal.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.Color.Red;
            this.lblValorTotal.Location = new System.Drawing.Point(172, 89);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(155, 32);
            this.lblValorTotal.TabIndex = 200;
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(170, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "Valor Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Valor Unitário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "Produto";
            // 
            // grupoDetalheVenda
            // 
            this.grupoDetalheVenda.Controls.Add(this.btnFecharVendaParcial);
            this.grupoDetalheVenda.Controls.Add(this.label4);
            this.grupoDetalheVenda.Controls.Add(this.lblNumeroMesa);
            this.grupoDetalheVenda.Controls.Add(this.lblGarcom);
            this.grupoDetalheVenda.Controls.Add(this.lblQtdPessoas);
            this.grupoDetalheVenda.Controls.Add(this.lblTotalPagar);
            this.grupoDetalheVenda.Controls.Add(this.label2);
            this.grupoDetalheVenda.Controls.Add(this.label5);
            this.grupoDetalheVenda.Controls.Add(this.label1);
            this.grupoDetalheVenda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoDetalheVenda.Location = new System.Drawing.Point(519, 12);
            this.grupoDetalheVenda.Name = "grupoDetalheVenda";
            this.grupoDetalheVenda.Size = new System.Drawing.Size(356, 237);
            this.grupoDetalheVenda.TabIndex = 6;
            this.grupoDetalheVenda.TabStop = false;
            this.grupoDetalheVenda.Text = "Detalhe da Venda";
            // 
            // btnFecharVendaParcial
            // 
            this.btnFecharVendaParcial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFecharVendaParcial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFecharVendaParcial.Location = new System.Drawing.Point(251, 198);
            this.btnFecharVendaParcial.Name = "btnFecharVendaParcial";
            this.btnFecharVendaParcial.Size = new System.Drawing.Size(96, 33);
            this.btnFecharVendaParcial.TabIndex = 4;
            this.btnFecharVendaParcial.Text = "Fechar Pedido";
            this.btnFecharVendaParcial.UseVisualStyleBackColor = true;
            this.btnFecharVendaParcial.Click += new System.EventHandler(this.btnFecharVendaParcial_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(21, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total a Pagar:";
            // 
            // lblNumeroMesa
            // 
            this.lblNumeroMesa.BackColor = System.Drawing.Color.White;
            this.lblNumeroMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumeroMesa.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroMesa.ForeColor = System.Drawing.Color.Red;
            this.lblNumeroMesa.Location = new System.Drawing.Point(190, 27);
            this.lblNumeroMesa.Name = "lblNumeroMesa";
            this.lblNumeroMesa.Size = new System.Drawing.Size(157, 32);
            this.lblNumeroMesa.TabIndex = 1;
            this.lblNumeroMesa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGarcom
            // 
            this.lblGarcom.BackColor = System.Drawing.Color.White;
            this.lblGarcom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGarcom.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarcom.ForeColor = System.Drawing.Color.Red;
            this.lblGarcom.Location = new System.Drawing.Point(190, 69);
            this.lblGarcom.Name = "lblGarcom";
            this.lblGarcom.Size = new System.Drawing.Size(157, 32);
            this.lblGarcom.TabIndex = 1;
            this.lblGarcom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQtdPessoas
            // 
            this.lblQtdPessoas.BackColor = System.Drawing.Color.White;
            this.lblQtdPessoas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQtdPessoas.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdPessoas.ForeColor = System.Drawing.Color.Red;
            this.lblQtdPessoas.Location = new System.Drawing.Point(190, 111);
            this.lblQtdPessoas.Name = "lblQtdPessoas";
            this.lblQtdPessoas.Size = new System.Drawing.Size(157, 32);
            this.lblQtdPessoas.TabIndex = 1;
            this.lblQtdPessoas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.BackColor = System.Drawing.Color.White;
            this.lblTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPagar.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPagar.Location = new System.Drawing.Point(190, 153);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(157, 32);
            this.lblTotalPagar.TabIndex = 1;
            this.lblTotalPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(21, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qtd. Pessoas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(21, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Garçom:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mesa:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(15, 252);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(227, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "Composição do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(299, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Itens do Pedido";
            // 
            // dtgItem
            // 
            this.dtgItem.AllowUserToAddRows = false;
            this.dtgItem.BackgroundColor = System.Drawing.Color.White;
            this.dtgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProduto,
            this.descricao,
            this.quantidade,
            this.Column1,
            this.valorUnitario,
            this.Column2,
            this.excluirItem});
            this.dtgItem.Location = new System.Drawing.Point(301, 272);
            this.dtgItem.Name = "dtgItem";
            this.dtgItem.Size = new System.Drawing.Size(884, 212);
            this.dtgItem.TabIndex = 3;
            this.dtgItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgItem_CellClick);
            this.dtgItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgItem_CellContentClick);
            this.dtgItem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgItem_CellEndEdit);
            // 
            // codProduto
            // 
            this.codProduto.DataPropertyName = "idProduto";
            this.codProduto.HeaderText = "Cód. Produto";
            this.codProduto.Name = "codProduto";
            this.codProduto.ReadOnly = true;
            this.codProduto.ToolTipText = "Código do produto.";
            this.codProduto.Width = 60;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição do Produto";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 320;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "qtdProduto";
            this.quantidade.HeaderText = "Qtd.";
            this.quantidade.Name = "quantidade";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "unidade";
            this.Column1.HeaderText = "Unid.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // valorUnitario
            // 
            this.valorUnitario.DataPropertyName = "valorUnitario";
            this.valorUnitario.HeaderText = "Valor Unit.";
            this.valorUnitario.Name = "valorUnitario";
            this.valorUnitario.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "total";
            this.Column2.HeaderText = "Valor Total";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // excluirItem
            // 
            this.excluirItem.HeaderText = "Remover";
            this.excluirItem.Image = global::SistemaParaPizzaria.Properties.Resources.cancel1;
            this.excluirItem.Name = "excluirItem";
            this.excluirItem.ReadOnly = true;
            this.excluirItem.ToolTipText = "Excluir Produto";
            this.excluirItem.Width = 60;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(83, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1211, 4);
            this.label12.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.DimGray;
            this.label11.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1294, 56);
            this.label11.TabIndex = 27;
            this.label11.Text = "Caixa";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Excluir";
            this.dataGridViewImageColumn1.Image = global::SistemaParaPizzaria.Properties.Resources.cancel;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ToolTipText = "Excluir Produto";
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.txtCpf);
            this.groupBoxCliente.Controls.Add(this.txtTelefone);
            this.groupBoxCliente.Controls.Add(this.label21);
            this.groupBoxCliente.Controls.Add(this.lblEnderecoCliente);
            this.groupBoxCliente.Controls.Add(this.label19);
            this.groupBoxCliente.Controls.Add(this.txtCliente);
            this.groupBoxCliente.Controls.Add(this.lblCodCliente);
            this.groupBoxCliente.Controls.Add(this.label18);
            this.groupBoxCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCliente.Location = new System.Drawing.Point(11, 557);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(949, 94);
            this.groupBoxCliente.TabIndex = 29;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.Color.Red;
            this.txtCpf.Location = new System.Drawing.Point(488, 31);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(223, 26);
            this.txtCpf.TabIndex = 1;
            this.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtQtd_TextChanged);
            this.txtCpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCpf_KeyDown);
            this.txtCpf.Validating += new System.ComponentModel.CancelEventHandler(this.txtCpf_Validating);
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.Red;
            this.txtTelefone.Location = new System.Drawing.Point(717, 31);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(223, 26);
            this.txtTelefone.TabIndex = 1;
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtQtd_TextChanged);
            this.txtTelefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefone_KeyDown);
            this.txtTelefone.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefone_Validating);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(715, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 12);
            this.label21.TabIndex = 3;
            this.label21.Text = "Telefone";
            // 
            // lblEnderecoCliente
            // 
            this.lblEnderecoCliente.AutoSize = true;
            this.lblEnderecoCliente.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoCliente.Location = new System.Drawing.Point(23, 69);
            this.lblEnderecoCliente.Name = "lblEnderecoCliente";
            this.lblEnderecoCliente.Size = new System.Drawing.Size(0, 17);
            this.lblEnderecoCliente.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(113, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 12);
            this.label19.TabIndex = 3;
            this.label19.Text = "Nome";
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.Red;
            this.txtCliente.Location = new System.Drawing.Point(113, 31);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(368, 26);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtQtd_TextChanged);
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            this.txtCliente.Validating += new System.ComponentModel.CancelEventHandler(this.txtCliente_Validating);
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCliente.Location = new System.Drawing.Point(17, 31);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(90, 26);
            this.lblCodCliente.TabIndex = 3;
            this.lblCodCliente.Text = "000000";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(489, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 12);
            this.label18.TabIndex = 3;
            this.label18.Text = "CPF";
            // 
            // frmMesa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1294, 662);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmMesa";
            this.ShowInTaskbar = false;
            this.Text = "Gourmet Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMesa_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMesa_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grupoDetalheVenda.ResumeLayout(false);
            this.grupoDetalheVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItem)).EndInit();
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grupoDetalheVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Button btnFecharVendaParcial;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnFazerPagamento;
        internal System.Windows.Forms.Button btnRetorna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.Label lblGarcom;
        private System.Windows.Forms.Label lblQtdPessoas;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public System.Windows.Forms.Label lblTotalPagar;
        public System.Windows.Forms.Label lblNumeroMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn excluirItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCartao;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.RadioButton rbMastercard;
        private System.Windows.Forms.RadioButton rbVisa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.ListBox listComposicaoProduto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblEnderecoCliente;

    }
}