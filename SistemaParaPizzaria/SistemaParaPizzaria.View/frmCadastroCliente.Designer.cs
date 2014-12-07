namespace SistemaParaPizzaria
{
    partial class frmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControlCliente = new System.Windows.Forms.TabControl();
            this.tabPageDadosCliente = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefone2 = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtTelefone1 = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageEndereco = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPageObservacao = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxMenuLateral = new System.Windows.Forms.GroupBox();
            this.lblProcurar = new System.Windows.Forms.Label();
            this.lblDadosCadastrais = new System.Windows.Forms.Label();
            this.lblProdutosVinculados = new System.Windows.Forms.Label();
            this.GroupBoxMenuSuperior = new System.Windows.Forms.GroupBox();
            this.btnRetorna = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExclui = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControlCliente.SuspendLayout();
            this.tabPageDadosCliente.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPageEndereco.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageObservacao.SuspendLayout();
            this.groupBoxMenuLateral.SuspendLayout();
            this.GroupBoxMenuSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tabControlCliente);
            this.groupBox1.Controls.Add(this.groupBoxMenuLateral);
            this.groupBox1.Controls.Add(this.GroupBoxMenuSuperior);
            this.groupBox1.Location = new System.Drawing.Point(6, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 478);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbCliente);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(237, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 52);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCliente.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(22, 23);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(527, 24);
            this.cmbCliente.TabIndex = 0;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            this.cmbCliente.Validating += new System.ComponentModel.CancelEventHandler(this.cmbCliente_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Buscar";
            // 
            // tabControlCliente
            // 
            this.tabControlCliente.Controls.Add(this.tabPageDadosCliente);
            this.tabControlCliente.Controls.Add(this.tabPageEndereco);
            this.tabControlCliente.Controls.Add(this.tabPageObservacao);
            this.tabControlCliente.ImageList = this.imageList1;
            this.tabControlCliente.Location = new System.Drawing.Point(237, 150);
            this.tabControlCliente.Name = "tabControlCliente";
            this.tabControlCliente.SelectedIndex = 0;
            this.tabControlCliente.Size = new System.Drawing.Size(585, 320);
            this.tabControlCliente.TabIndex = 0;
            // 
            // tabPageDadosCliente
            // 
            this.tabPageDadosCliente.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageDadosCliente.Controls.Add(this.groupBox5);
            this.tabPageDadosCliente.ImageKey = "fileopen.png";
            this.tabPageDadosCliente.Location = new System.Drawing.Point(4, 23);
            this.tabPageDadosCliente.Name = "tabPageDadosCliente";
            this.tabPageDadosCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDadosCliente.Size = new System.Drawing.Size(577, 293);
            this.tabPageDadosCliente.TabIndex = 0;
            this.tabPageDadosCliente.Text = "Dados do Cliente";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txtRg);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtTelefone2);
            this.groupBox5.Controls.Add(this.txtCpf);
            this.groupBox5.Controls.Add(this.txtContato);
            this.groupBox5.Controls.Add(this.txtTelefone1);
            this.groupBox5.Controls.Add(this.txtCliente);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(6, 7);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(563, 281);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // txtRg
            // 
            this.txtRg.BackColor = System.Drawing.Color.White;
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRg.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.ForeColor = System.Drawing.Color.Black;
            this.txtRg.Location = new System.Drawing.Point(265, 78);
            this.txtRg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(213, 22);
            this.txtRg.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nome do Cliente";
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.BackColor = System.Drawing.Color.White;
            this.txtTelefone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefone2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone2.ForeColor = System.Drawing.Color.Black;
            this.txtTelefone2.Location = new System.Drawing.Point(265, 117);
            this.txtTelefone2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefone2.MaxLength = 11;
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(213, 22);
            this.txtTelefone2.TabIndex = 5;
            this.txtTelefone2.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefone2_Validating);
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.White;
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCpf.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.Color.Black;
            this.txtCpf.Location = new System.Drawing.Point(16, 78);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(213, 22);
            this.txtCpf.TabIndex = 2;
            this.txtCpf.Validating += new System.ComponentModel.CancelEventHandler(this.txtCpf_Validating);
            // 
            // txtContato
            // 
            this.txtContato.BackColor = System.Drawing.Color.White;
            this.txtContato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContato.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContato.ForeColor = System.Drawing.Color.Black;
            this.txtContato.Location = new System.Drawing.Point(16, 156);
            this.txtContato.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(213, 22);
            this.txtContato.TabIndex = 6;
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.BackColor = System.Drawing.Color.White;
            this.txtTelefone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefone1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone1.ForeColor = System.Drawing.Color.Black;
            this.txtTelefone1.Location = new System.Drawing.Point(16, 117);
            this.txtTelefone1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefone1.MaxLength = 11;
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(213, 22);
            this.txtTelefone1.TabIndex = 4;
            this.txtTelefone1.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefone1_Validating);
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCliente.Location = new System.Drawing.Point(16, 37);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(527, 22);
            this.txtCliente.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "RG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Telefone 2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(13, 141);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 16);
            this.label19.TabIndex = 12;
            this.label19.Text = "Contato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefone 1";
            // 
            // tabPageEndereco
            // 
            this.tabPageEndereco.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageEndereco.Controls.Add(this.groupBox3);
            this.tabPageEndereco.ImageIndex = 3;
            this.tabPageEndereco.Location = new System.Drawing.Point(4, 23);
            this.tabPageEndereco.Name = "tabPageEndereco";
            this.tabPageEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEndereco.Size = new System.Drawing.Size(577, 293);
            this.tabPageEndereco.TabIndex = 1;
            this.tabPageEndereco.Text = "Endereço";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbCidade);
            this.groupBox3.Controls.Add(this.cmbUf);
            this.groupBox3.Controls.Add(this.txtBairro);
            this.groupBox3.Controls.Add(this.txtCep);
            this.groupBox3.Controls.Add(this.txtNumero);
            this.groupBox3.Controls.Add(this.txtComplemento);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.txtLogradouro);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(6, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(563, 278);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // cmbCidade
            // 
            this.cmbCidade.BackColor = System.Drawing.Color.White;
            this.cmbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbCidade.Location = new System.Drawing.Point(91, 159);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(449, 24);
            this.cmbCidade.TabIndex = 6;
            // 
            // cmbUf
            // 
            this.cmbUf.BackColor = System.Drawing.Color.White;
            this.cmbUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbUf.Location = new System.Drawing.Point(16, 159);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(69, 24);
            this.cmbUf.TabIndex = 5;
            this.cmbUf.SelectedIndexChanged += new System.EventHandler(this.cmbUf_SelectedIndexChanged);
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.Black;
            this.txtBairro.Location = new System.Drawing.Point(146, 75);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(394, 22);
            this.txtBairro.TabIndex = 3;
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.Color.White;
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCep.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.ForeColor = System.Drawing.Color.Black;
            this.txtCep.Location = new System.Drawing.Point(16, 203);
            this.txtCep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(213, 22);
            this.txtCep.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.Black;
            this.txtNumero.Location = new System.Drawing.Point(16, 75);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(124, 22);
            this.txtNumero.TabIndex = 2;
            // 
            // txtComplemento
            // 
            this.txtComplemento.BackColor = System.Drawing.Color.White;
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.ForeColor = System.Drawing.Color.Black;
            this.txtComplemento.Location = new System.Drawing.Point(16, 117);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(524, 22);
            this.txtComplemento.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(16, 245);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(462, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.BackColor = System.Drawing.Color.White;
            this.txtLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogradouro.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouro.ForeColor = System.Drawing.Color.Black;
            this.txtLogradouro.Location = new System.Drawing.Point(16, 33);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(524, 22);
            this.txtLogradouro.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(143, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bairro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Número";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 16);
            this.label15.TabIndex = 12;
            this.label15.Text = "CEP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Complemento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "UF";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 228);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 16);
            this.label18.TabIndex = 12;
            this.label18.Text = "E-mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(88, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Cidade";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "Logradouro";
            // 
            // tabPageObservacao
            // 
            this.tabPageObservacao.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageObservacao.Controls.Add(this.label20);
            this.tabPageObservacao.Controls.Add(this.txtObservacao);
            this.tabPageObservacao.ImageIndex = 2;
            this.tabPageObservacao.Location = new System.Drawing.Point(4, 23);
            this.tabPageObservacao.Name = "tabPageObservacao";
            this.tabPageObservacao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageObservacao.Size = new System.Drawing.Size(577, 293);
            this.tabPageObservacao.TabIndex = 2;
            this.tabPageObservacao.Text = "Observações";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 7);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(3, 23);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(571, 264);
            this.txtObservacao.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "produto.png");
            this.imageList1.Images.SetKeyName(1, "fileopen.png");
            this.imageList1.Images.SetKeyName(2, "observacao.png");
            this.imageList1.Images.SetKeyName(3, "address-book.png");
            // 
            // groupBoxMenuLateral
            // 
            this.groupBoxMenuLateral.Controls.Add(this.lblProcurar);
            this.groupBoxMenuLateral.Controls.Add(this.lblDadosCadastrais);
            this.groupBoxMenuLateral.Controls.Add(this.lblProdutosVinculados);
            this.groupBoxMenuLateral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMenuLateral.Location = new System.Drawing.Point(6, 15);
            this.groupBoxMenuLateral.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMenuLateral.Name = "groupBoxMenuLateral";
            this.groupBoxMenuLateral.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMenuLateral.Size = new System.Drawing.Size(225, 455);
            this.groupBoxMenuLateral.TabIndex = 45;
            this.groupBoxMenuLateral.TabStop = false;
            // 
            // lblProcurar
            // 
            this.lblProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblProcurar.Image = global::SistemaParaPizzaria.Properties.Resources._1408_16x16;
            this.lblProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProcurar.Location = new System.Drawing.Point(30, 26);
            this.lblProcurar.Name = "lblProcurar";
            this.lblProcurar.Size = new System.Drawing.Size(89, 33);
            this.lblProcurar.TabIndex = 0;
            this.lblProcurar.Text = "Procurar";
            this.lblProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDadosCadastrais
            // 
            this.lblDadosCadastrais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDadosCadastrais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosCadastrais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDadosCadastrais.Image = global::SistemaParaPizzaria.Properties.Resources.fileopen;
            this.lblDadosCadastrais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDadosCadastrais.Location = new System.Drawing.Point(30, 96);
            this.lblDadosCadastrais.Name = "lblDadosCadastrais";
            this.lblDadosCadastrais.Size = new System.Drawing.Size(148, 33);
            this.lblDadosCadastrais.TabIndex = 0;
            this.lblDadosCadastrais.Text = "Dados Cadastrais";
            this.lblDadosCadastrais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProdutosVinculados
            // 
            this.lblProdutosVinculados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProdutosVinculados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutosVinculados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblProdutosVinculados.Image = global::SistemaParaPizzaria.Properties.Resources.produto;
            this.lblProdutosVinculados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProdutosVinculados.Location = new System.Drawing.Point(30, 59);
            this.lblProdutosVinculados.Name = "lblProdutosVinculados";
            this.lblProdutosVinculados.Size = new System.Drawing.Size(164, 33);
            this.lblProdutosVinculados.TabIndex = 0;
            this.lblProdutosVinculados.Text = "Produtos Vinculados";
            this.lblProdutosVinculados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GroupBoxMenuSuperior
            // 
            this.GroupBoxMenuSuperior.Controls.Add(this.btnRetorna);
            this.GroupBoxMenuSuperior.Controls.Add(this.btnIncluir);
            this.GroupBoxMenuSuperior.Controls.Add(this.btnExclui);
            this.GroupBoxMenuSuperior.Controls.Add(this.btnCancela);
            this.GroupBoxMenuSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxMenuSuperior.Location = new System.Drawing.Point(486, 15);
            this.GroupBoxMenuSuperior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxMenuSuperior.Name = "GroupBoxMenuSuperior";
            this.GroupBoxMenuSuperior.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxMenuSuperior.Size = new System.Drawing.Size(332, 57);
            this.GroupBoxMenuSuperior.TabIndex = 45;
            this.GroupBoxMenuSuperior.TabStop = false;
            // 
            // btnRetorna
            // 
            this.btnRetorna.BackColor = System.Drawing.Color.Transparent;
            this.btnRetorna.Image = global::SistemaParaPizzaria.Properties.Resources.undo;
            this.btnRetorna.Location = new System.Drawing.Point(246, 11);
            this.btnRetorna.Name = "btnRetorna";
            this.btnRetorna.Size = new System.Drawing.Size(77, 41);
            this.btnRetorna.TabIndex = 38;
            this.btnRetorna.UseVisualStyleBackColor = false;
            this.btnRetorna.Click += new System.EventHandler(this.btnRetorna_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.Transparent;
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.Location = new System.Drawing.Point(9, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(77, 41);
            this.btnIncluir.TabIndex = 9;
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExclui
            // 
            this.btnExclui.BackColor = System.Drawing.Color.Transparent;
            this.btnExclui.Image = ((System.Drawing.Image)(resources.GetObject("btnExclui.Image")));
            this.btnExclui.Location = new System.Drawing.Point(167, 11);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(77, 41);
            this.btnExclui.TabIndex = 32;
            this.btnExclui.UseVisualStyleBackColor = false;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.Color.Transparent;
            this.btnCancela.Image = ((System.Drawing.Image)(resources.GetObject("btnCancela.Image")));
            this.btnCancela.Location = new System.Drawing.Point(88, 11);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(77, 41);
            this.btnCancela.TabIndex = 31;
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(273, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(570, 4);
            this.label12.TabIndex = 44;
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
            this.label11.Size = new System.Drawing.Size(855, 62);
            this.label11.TabIndex = 45;
            this.label11.Text = "Cadastro de Cliente";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(77, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 16);
            this.label16.TabIndex = 12;
            this.label16.Text = "Ex.: (00-00000000)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(324, 101);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 16);
            this.label17.TabIndex = 13;
            this.label17.Text = "Ex.: (00-00000000)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label21.Location = new System.Drawing.Point(77, 61);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 16);
            this.label21.TabIndex = 14;
            this.label21.Text = "Ex.: (000000000000)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label22.Location = new System.Drawing.Point(324, 61);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 16);
            this.label22.TabIndex = 15;
            this.label22.Text = "Ex.: (000000000)";
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 546);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroCliente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControlCliente.ResumeLayout(false);
            this.tabPageDadosCliente.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPageEndereco.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageObservacao.ResumeLayout(false);
            this.tabPageObservacao.PerformLayout();
            this.groupBoxMenuLateral.ResumeLayout(false);
            this.GroupBoxMenuSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbCliente;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabControlCliente;
        private System.Windows.Forms.TabPage tabPageDadosCliente;
        internal System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.TextBox txtRg;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtTelefone2;
        internal System.Windows.Forms.TextBox txtCpf;
        internal System.Windows.Forms.TextBox txtContato;
        internal System.Windows.Forms.TextBox txtTelefone1;
        internal System.Windows.Forms.TextBox txtCliente;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageEndereco;
        internal System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.ComboBox cmbUf;
        internal System.Windows.Forms.TextBox txtBairro;
        internal System.Windows.Forms.TextBox txtCep;
        internal System.Windows.Forms.TextBox txtNumero;
        internal System.Windows.Forms.TextBox txtComplemento;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtLogradouro;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPageObservacao;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtObservacao;
        internal System.Windows.Forms.GroupBox groupBoxMenuLateral;
        private System.Windows.Forms.Label lblProcurar;
        private System.Windows.Forms.Label lblDadosCadastrais;
        private System.Windows.Forms.Label lblProdutosVinculados;
        internal System.Windows.Forms.GroupBox GroupBoxMenuSuperior;
        internal System.Windows.Forms.Button btnRetorna;
        internal System.Windows.Forms.Button btnIncluir;
        internal System.Windows.Forms.Button btnExclui;
        internal System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ImageList imageList1;
        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.Label label21;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label16;
    }
}