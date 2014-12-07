namespace SistemaParaPizzaria
{
    partial class frmAbrirMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbrirMesa));
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAbrirMesa = new System.Windows.Forms.Button();
            this.btnRetorna = new System.Windows.Forms.Button();
            this.btnCadUnidade = new System.Windows.Forms.Button();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.txtQtdPessoas = new System.Windows.Forms.TextBox();
            this.txtMesa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(239, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(269, 4);
            this.label12.TabIndex = 30;
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
            this.label11.Size = new System.Drawing.Size(508, 62);
            this.label11.TabIndex = 29;
            this.label11.Text = "Abertura de Mesa";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnAbrirMesa);
            this.GroupBox1.Controls.Add(this.btnRetorna);
            this.GroupBox1.Controls.Add(this.btnCadUnidade);
            this.GroupBox1.Controls.Add(this.cmbFuncionario);
            this.GroupBox1.Controls.Add(this.txtQtdPessoas);
            this.GroupBox1.Controls.Add(this.txtMesa);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(9, 72);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Size = new System.Drawing.Size(490, 216);
            this.GroupBox1.TabIndex = 37;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Informações da Mesa";
            // 
            // btnAbrirMesa
            // 
            this.btnAbrirMesa.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrirMesa.Image = global::SistemaParaPizzaria.Properties.Resources.accept_icon;
            this.btnAbrirMesa.Location = new System.Drawing.Point(307, 157);
            this.btnAbrirMesa.Name = "btnAbrirMesa";
            this.btnAbrirMesa.Size = new System.Drawing.Size(77, 41);
            this.btnAbrirMesa.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAbrirMesa, "Abrir Mesa");
            this.btnAbrirMesa.UseVisualStyleBackColor = false;
            this.btnAbrirMesa.Click += new System.EventHandler(this.btnAbrirMesa_Click);
            // 
            // btnRetorna
            // 
            this.btnRetorna.BackColor = System.Drawing.Color.Transparent;
            this.btnRetorna.Image = global::SistemaParaPizzaria.Properties.Resources.undo;
            this.btnRetorna.Location = new System.Drawing.Point(390, 157);
            this.btnRetorna.Name = "btnRetorna";
            this.btnRetorna.Size = new System.Drawing.Size(77, 41);
            this.btnRetorna.TabIndex = 40;
            this.toolTip1.SetToolTip(this.btnRetorna, "Sair");
            this.btnRetorna.UseVisualStyleBackColor = false;
            this.btnRetorna.Click += new System.EventHandler(this.btnRetorna_Click);
            // 
            // btnCadUnidade
            // 
            this.btnCadUnidade.Image = global::SistemaParaPizzaria.Properties.Resources.list;
            this.btnCadUnidade.Location = new System.Drawing.Point(431, 79);
            this.btnCadUnidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadUnidade.Name = "btnCadUnidade";
            this.btnCadUnidade.Size = new System.Drawing.Size(36, 30);
            this.btnCadUnidade.TabIndex = 31;
            this.toolTip1.SetToolTip(this.btnCadUnidade, "Cadastro de Funcionário");
            this.btnCadUnidade.UseVisualStyleBackColor = true;
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFuncionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Items.AddRange(new object[] {
            "Jose da Silva",
            "Joao dos Santos"});
            this.cmbFuncionario.Location = new System.Drawing.Point(17, 85);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(408, 24);
            this.cmbFuncionario.TabIndex = 1;
            // 
            // txtQtdPessoas
            // 
            this.txtQtdPessoas.BackColor = System.Drawing.Color.White;
            this.txtQtdPessoas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdPessoas.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdPessoas.ForeColor = System.Drawing.Color.Black;
            this.txtQtdPessoas.Location = new System.Drawing.Point(170, 30);
            this.txtQtdPessoas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQtdPessoas.Name = "txtQtdPessoas";
            this.txtQtdPessoas.Size = new System.Drawing.Size(111, 22);
            this.txtQtdPessoas.TabIndex = 0;
            this.txtQtdPessoas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMesa
            // 
            this.txtMesa.BackColor = System.Drawing.Color.White;
            this.txtMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMesa.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesa.ForeColor = System.Drawing.Color.Black;
            this.txtMesa.Location = new System.Drawing.Point(17, 30);
            this.txtMesa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.Size = new System.Drawing.Size(111, 22);
            this.txtMesa.TabIndex = 100;
            this.txtMesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Qtd. Pessoas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Funcionário";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(15, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(49, 16);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Nº Mesa";
            // 
            // frmAbrirMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 298);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbrirMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gourmet Management";
            this.TopMost = true;
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtQtdPessoas;
        internal System.Windows.Forms.TextBox txtMesa;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        internal System.Windows.Forms.Button btnCadUnidade;
        internal System.Windows.Forms.Button btnRetorna;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button btnAbrirMesa;
    }
}