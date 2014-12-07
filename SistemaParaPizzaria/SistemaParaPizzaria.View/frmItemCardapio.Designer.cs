namespace SistemaParaPizzaria
{
    partial class frmItemCardapio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemCardapio));
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbIngredientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgItem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdNaReceita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCadIngrediente = new System.Windows.Forms.Button();
            this.btnRetorna = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnBuscaCategoria = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtQtdProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProdComposto = new System.Windows.Forms.ComboBox();
            this.txtCodCategoria = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(411, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(499, 4);
            this.label12.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.DimGray;
            this.label11.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(910, 62);
            this.label11.TabIndex = 27;
            this.label11.Text = "Cadastro de Itens do Cardápio";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbIngredientes
            // 
            this.cmbIngredientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbIngredientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbIngredientes.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIngredientes.FormattingEnabled = true;
            this.cmbIngredientes.Location = new System.Drawing.Point(12, 224);
            this.cmbIngredientes.Name = "cmbIngredientes";
            this.cmbIngredientes.Size = new System.Drawing.Size(451, 24);
            this.cmbIngredientes.TabIndex = 0;
            this.cmbIngredientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbIngredientes_KeyDown);
            this.cmbIngredientes.Validating += new System.ComponentModel.CancelEventHandler(this.cmbIngredientes_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ingredientes";
            // 
            // dtgItem
            // 
            this.dtgItem.AllowUserToAddRows = false;
            this.dtgItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgItem.BackgroundColor = System.Drawing.Color.White;
            this.dtgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ingrediente,
            this.qtdNaReceita,
            this.unidade,
            this.valorUnit,
            this.valorTotal,
            this.excluir});
            this.dtgItem.Location = new System.Drawing.Point(12, 255);
            this.dtgItem.Name = "dtgItem";
            this.dtgItem.Size = new System.Drawing.Size(892, 274);
            this.dtgItem.TabIndex = 31;
            this.dtgItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgItem_CellClick);
            this.dtgItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgItem_CellContentClick);
            this.dtgItem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgItem_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idIngrediente";
            this.Column1.HeaderText = "Cód. Produto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // ingrediente
            // 
            this.ingrediente.DataPropertyName = "descricao";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            this.ingrediente.DefaultCellStyle = dataGridViewCellStyle1;
            this.ingrediente.HeaderText = "Ingrediente";
            this.ingrediente.Name = "ingrediente";
            this.ingrediente.ReadOnly = true;
            this.ingrediente.Width = 320;
            // 
            // qtdNaReceita
            // 
            this.qtdNaReceita.DataPropertyName = "qtdIngrediente";
            this.qtdNaReceita.HeaderText = "Qtd. Itens Receita";
            this.qtdNaReceita.Name = "qtdNaReceita";
            // 
            // unidade
            // 
            this.unidade.DataPropertyName = "unidade";
            this.unidade.HeaderText = "Unidade";
            this.unidade.Name = "unidade";
            this.unidade.ReadOnly = true;
            // 
            // valorUnit
            // 
            this.valorUnit.DataPropertyName = "valorUnitario";
            this.valorUnit.HeaderText = "Valor Unit.";
            this.valorUnit.Name = "valorUnit";
            this.valorUnit.ReadOnly = true;
            // 
            // valorTotal
            // 
            this.valorTotal.DataPropertyName = "total";
            this.valorTotal.HeaderText = "Valor Total";
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.ReadOnly = true;
            // 
            // excluir
            // 
            this.excluir.HeaderText = "Remover";
            this.excluir.Image = global::SistemaParaPizzaria.Properties.Resources.cancel1;
            this.excluir.Name = "excluir";
            this.excluir.Width = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(750, 547);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Total:";
            // 
            // btnCadIngrediente
            // 
            this.btnCadIngrediente.Image = global::SistemaParaPizzaria.Properties.Resources.list;
            this.btnCadIngrediente.Location = new System.Drawing.Point(469, 221);
            this.btnCadIngrediente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadIngrediente.Name = "btnCadIngrediente";
            this.btnCadIngrediente.Size = new System.Drawing.Size(28, 28);
            this.btnCadIngrediente.TabIndex = 38;
            this.toolTip1.SetToolTip(this.btnCadIngrediente, "Cadastrar Ingrediente");
            this.btnCadIngrediente.UseVisualStyleBackColor = true;
            this.btnCadIngrediente.Click += new System.EventHandler(this.btnCadIngrediente_Click);
            // 
            // btnRetorna
            // 
            this.btnRetorna.BackColor = System.Drawing.Color.Transparent;
            this.btnRetorna.Image = global::SistemaParaPizzaria.Properties.Resources.undo;
            this.btnRetorna.Location = new System.Drawing.Point(806, 18);
            this.btnRetorna.Name = "btnRetorna";
            this.btnRetorna.Size = new System.Drawing.Size(77, 41);
            this.btnRetorna.TabIndex = 37;
            this.toolTip1.SetToolTip(this.btnRetorna, "Sair.");
            this.btnRetorna.UseVisualStyleBackColor = false;
            this.btnRetorna.Click += new System.EventHandler(this.btnRetorna_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.Transparent;
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.Location = new System.Drawing.Point(640, 18);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(77, 41);
            this.btnIncluir.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnIncluir, "Salvar Receita");
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.Color.Transparent;
            this.btnCancela.Image = ((System.Drawing.Image)(resources.GetObject("btnCancela.Image")));
            this.btnCancela.Location = new System.Drawing.Point(723, 18);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(77, 41);
            this.btnCancela.TabIndex = 36;
            this.toolTip1.SetToolTip(this.btnCancela, "Cancelar Receita");
            this.btnCancela.UseVisualStyleBackColor = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Image = global::SistemaParaPizzaria.Properties.Resources.list_add;
            this.btnAddItem.Location = new System.Drawing.Point(671, 208);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(40, 40);
            this.btnAddItem.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAddItem, "Adicionar item na receita.");
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnBuscaCategoria
            // 
            this.btnBuscaCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCategoria.Image")));
            this.btnBuscaCategoria.Location = new System.Drawing.Point(460, 82);
            this.btnBuscaCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscaCategoria.Name = "btnBuscaCategoria";
            this.btnBuscaCategoria.Size = new System.Drawing.Size(28, 28);
            this.btnBuscaCategoria.TabIndex = 47;
            this.toolTip1.SetToolTip(this.btnBuscaCategoria, "Pesquisar Categoria");
            this.btnBuscaCategoria.UseVisualStyleBackColor = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Remover";
            this.dataGridViewImageColumn1.Image = global::SistemaParaPizzaria.Properties.Resources.close;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 65;
            // 
            // txtQtdProduto
            // 
            this.txtQtdProduto.BackColor = System.Drawing.Color.White;
            this.txtQtdProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdProduto.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdProduto.ForeColor = System.Drawing.Color.Black;
            this.txtQtdProduto.Location = new System.Drawing.Point(503, 224);
            this.txtQtdProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQtdProduto.Name = "txtQtdProduto";
            this.txtQtdProduto.Size = new System.Drawing.Size(78, 24);
            this.txtQtdProduto.TabIndex = 1;
            this.txtQtdProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Qtd. Ingr.";
            // 
            // lblUnidade
            // 
            this.lblUnidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnidade.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.Location = new System.Drawing.Point(587, 224);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(78, 24);
            this.lblUnidade.TabIndex = 30;
            this.lblUnidade.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(587, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Unid.";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(790, 539);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(114, 24);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscaCategoria);
            this.groupBox1.Controls.Add(this.cmbProdComposto);
            this.groupBox1.Controls.Add(this.txtCodCategoria);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Controls.Add(this.btnRetorna);
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.btnIncluir);
            this.groupBox1.Controls.Add(this.btnCancela);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(9, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Produto";
            // 
            // cmbProdComposto
            // 
            this.cmbProdComposto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProdComposto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProdComposto.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProdComposto.FormattingEnabled = true;
            this.cmbProdComposto.Location = new System.Drawing.Point(3, 35);
            this.cmbProdComposto.Name = "cmbProdComposto";
            this.cmbProdComposto.Size = new System.Drawing.Size(451, 24);
            this.cmbProdComposto.TabIndex = 46;
            this.cmbProdComposto.SelectedIndexChanged += new System.EventHandler(this.cmbProdComposto_SelectedIndexChanged);
            this.cmbProdComposto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProdComposto_KeyDown);
            this.cmbProdComposto.Validating += new System.ComponentModel.CancelEventHandler(this.cmbProdComposto_Validating);
            // 
            // txtCodCategoria
            // 
            this.txtCodCategoria.BackColor = System.Drawing.Color.White;
            this.txtCodCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCategoria.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCategoria.ForeColor = System.Drawing.Color.Black;
            this.txtCodCategoria.Location = new System.Drawing.Point(345, 83);
            this.txtCodCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodCategoria.Name = "txtCodCategoria";
            this.txtCodCategoria.Size = new System.Drawing.Size(109, 24);
            this.txtCodCategoria.TabIndex = 1;
            this.txtCodCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodCategoria_Validating);
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.Color.White;
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.ForeColor = System.Drawing.Color.Black;
            this.txtProduto.Location = new System.Drawing.Point(6, 83);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(329, 24);
            this.txtProduto.TabIndex = 0;
            // 
            // lblCategoria
            // 
            this.lblCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCategoria.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(494, 84);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(388, 24);
            this.lblCategoria.TabIndex = 44;
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(491, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Cód. Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Buscar Produto Composto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Produto";
            // 
            // frmItemCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 572);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtQtdProduto);
            this.Controls.Add(this.btnCadIngrediente);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgItem);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIngredientes);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItemCardapio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto Composto  -  Gourmet Management";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmItemCardapio_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmItemCardapio_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dtgItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbIngredientes;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgItem;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddItem;
        internal System.Windows.Forms.Button btnIncluir;
        internal System.Windows.Forms.Button btnCancela;
        internal System.Windows.Forms.Button btnRetorna;
        internal System.Windows.Forms.Button btnCadIngrediente;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.TextBox txtQtdProduto;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label lblUnidade;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox txtCodCategoria;
        internal System.Windows.Forms.TextBox txtProduto;
        internal System.Windows.Forms.Label lblCategoria;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProdComposto;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdNaReceita;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
        private System.Windows.Forms.DataGridViewImageColumn excluir;
        internal System.Windows.Forms.Button btnBuscaCategoria;
    }
}