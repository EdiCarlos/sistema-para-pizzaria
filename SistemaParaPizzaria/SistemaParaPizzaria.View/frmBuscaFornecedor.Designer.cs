namespace SistemaParaPizzaria
{
    partial class frmBuscaFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaFornecedor));
            this.groupBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.btnCadFornecedor = new System.Windows.Forms.Button();
            this.btnRetorna = new System.Windows.Forms.Button();
            this.rbFornecedor = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dtgBuscaFornecedor = new System.Windows.Forms.DataGridView();
            this.groupBoxPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscaFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPesquisa
            // 
            this.groupBoxPesquisa.Controls.Add(this.btnCadFornecedor);
            this.groupBoxPesquisa.Controls.Add(this.btnRetorna);
            this.groupBoxPesquisa.Controls.Add(this.rbFornecedor);
            this.groupBoxPesquisa.Controls.Add(this.rbCodigo);
            this.groupBoxPesquisa.Controls.Add(this.txtPesquisa);
            this.groupBoxPesquisa.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPesquisa.Location = new System.Drawing.Point(7, -2);
            this.groupBoxPesquisa.Name = "groupBoxPesquisa";
            this.groupBoxPesquisa.Size = new System.Drawing.Size(540, 68);
            this.groupBoxPesquisa.TabIndex = 3;
            this.groupBoxPesquisa.TabStop = false;
            this.groupBoxPesquisa.Text = "Pesquisa";
            // 
            // btnCadFornecedor
            // 
            this.btnCadFornecedor.Image = global::SistemaParaPizzaria.Properties.Resources.list;
            this.btnCadFornecedor.Location = new System.Drawing.Point(455, 26);
            this.btnCadFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadFornecedor.Name = "btnCadFornecedor";
            this.btnCadFornecedor.Size = new System.Drawing.Size(35, 30);
            this.btnCadFornecedor.TabIndex = 40;
            this.btnCadFornecedor.UseVisualStyleBackColor = true;
            this.btnCadFornecedor.Click += new System.EventHandler(this.btnCadFornecedor_Click);
            // 
            // btnRetorna
            // 
            this.btnRetorna.BackColor = System.Drawing.Color.Transparent;
            this.btnRetorna.BackgroundImage = global::SistemaParaPizzaria.Properties.Resources.undo;
            this.btnRetorna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRetorna.Location = new System.Drawing.Point(499, 26);
            this.btnRetorna.Name = "btnRetorna";
            this.btnRetorna.Size = new System.Drawing.Size(35, 30);
            this.btnRetorna.TabIndex = 39;
            this.btnRetorna.UseVisualStyleBackColor = false;
            this.btnRetorna.Click += new System.EventHandler(this.btnRetorna_Click);
            // 
            // rbFornecedor
            // 
            this.rbFornecedor.AutoSize = true;
            this.rbFornecedor.Checked = true;
            this.rbFornecedor.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFornecedor.Location = new System.Drawing.Point(316, 33);
            this.rbFornecedor.Name = "rbFornecedor";
            this.rbFornecedor.Size = new System.Drawing.Size(102, 26);
            this.rbFornecedor.TabIndex = 1;
            this.rbFornecedor.TabStop = true;
            this.rbFornecedor.Text = "Fornecedor";
            this.rbFornecedor.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.Location = new System.Drawing.Point(225, 33);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(74, 26);
            this.rbCodigo.TabIndex = 1;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(6, 33);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(195, 27);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // dtgBuscaFornecedor
            // 
            this.dtgBuscaFornecedor.AllowUserToAddRows = false;
            this.dtgBuscaFornecedor.AllowUserToDeleteRows = false;
            this.dtgBuscaFornecedor.AllowUserToResizeColumns = false;
            this.dtgBuscaFornecedor.AllowUserToResizeRows = false;
            this.dtgBuscaFornecedor.BackgroundColor = System.Drawing.Color.White;
            this.dtgBuscaFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscaFornecedor.Location = new System.Drawing.Point(7, 70);
            this.dtgBuscaFornecedor.MultiSelect = false;
            this.dtgBuscaFornecedor.Name = "dtgBuscaFornecedor";
            this.dtgBuscaFornecedor.ReadOnly = true;
            this.dtgBuscaFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBuscaFornecedor.Size = new System.Drawing.Size(540, 239);
            this.dtgBuscaFornecedor.TabIndex = 2;
            this.dtgBuscaFornecedor.DoubleClick += new System.EventHandler(this.dtgBuscaFornecedor_DoubleClick);
            // 
            // frmBuscaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 318);
            this.Controls.Add(this.groupBoxPesquisa);
            this.Controls.Add(this.dtgBuscaFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscaFornecedor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Fornecedor - Gourmet Management";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmBuscaFornecedor_Load);
            this.groupBoxPesquisa.ResumeLayout(false);
            this.groupBoxPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscaFornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPesquisa;
        internal System.Windows.Forms.Button btnCadFornecedor;
        internal System.Windows.Forms.Button btnRetorna;
        private System.Windows.Forms.RadioButton rbFornecedor;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.TextBox txtPesquisa;
        public System.Windows.Forms.DataGridView dtgBuscaFornecedor;
    }
}