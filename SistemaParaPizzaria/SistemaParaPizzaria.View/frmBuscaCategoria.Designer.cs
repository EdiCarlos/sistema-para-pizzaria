namespace SistemaParaPizzaria
{
    partial class frmBuscaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaCategoria));
            this.dtgBuscaCategoria = new System.Windows.Forms.DataGridView();
            this.groupBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.btnCadCategoria = new System.Windows.Forms.Button();
            this.btnRetorna = new System.Windows.Forms.Button();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscaCategoria)).BeginInit();
            this.groupBoxPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgBuscaCategoria
            // 
            this.dtgBuscaCategoria.AllowUserToAddRows = false;
            this.dtgBuscaCategoria.AllowUserToDeleteRows = false;
            this.dtgBuscaCategoria.AllowUserToResizeColumns = false;
            this.dtgBuscaCategoria.AllowUserToResizeRows = false;
            this.dtgBuscaCategoria.BackgroundColor = System.Drawing.Color.White;
            this.dtgBuscaCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscaCategoria.Location = new System.Drawing.Point(12, 77);
            this.dtgBuscaCategoria.MultiSelect = false;
            this.dtgBuscaCategoria.Name = "dtgBuscaCategoria";
            this.dtgBuscaCategoria.ReadOnly = true;
            this.dtgBuscaCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBuscaCategoria.Size = new System.Drawing.Size(540, 239);
            this.dtgBuscaCategoria.TabIndex = 0;          
            this.dtgBuscaCategoria.DoubleClick += new System.EventHandler(this.dtgBuscaCategoria_DoubleClick);
            // 
            // groupBoxPesquisa
            // 
            this.groupBoxPesquisa.Controls.Add(this.btnCadCategoria);
            this.groupBoxPesquisa.Controls.Add(this.btnRetorna);
            this.groupBoxPesquisa.Controls.Add(this.rbCategoria);
            this.groupBoxPesquisa.Controls.Add(this.rbCodigo);
            this.groupBoxPesquisa.Controls.Add(this.txtPesquisa);
            this.groupBoxPesquisa.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPesquisa.Location = new System.Drawing.Point(12, 3);
            this.groupBoxPesquisa.Name = "groupBoxPesquisa";
            this.groupBoxPesquisa.Size = new System.Drawing.Size(540, 68);
            this.groupBoxPesquisa.TabIndex = 1;
            this.groupBoxPesquisa.TabStop = false;
            this.groupBoxPesquisa.Text = "Pesquisa";
            // 
            // btnCadCategoria
            // 
            this.btnCadCategoria.Image = global::SistemaParaPizzaria.Properties.Resources.list;
            this.btnCadCategoria.Location = new System.Drawing.Point(455, 26);
            this.btnCadCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadCategoria.Name = "btnCadCategoria";
            this.btnCadCategoria.Size = new System.Drawing.Size(35, 30);
            this.btnCadCategoria.TabIndex = 40;
            this.toolTip1.SetToolTip(this.btnCadCategoria, "Cadastrar Categoria");
            this.btnCadCategoria.UseVisualStyleBackColor = true;
            this.btnCadCategoria.Click += new System.EventHandler(this.btnCadCategoria_Click);
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
            this.toolTip1.SetToolTip(this.btnRetorna, "Sair");
            this.btnRetorna.UseVisualStyleBackColor = false;
            this.btnRetorna.Click += new System.EventHandler(this.btnRetorna_Click);
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Checked = true;
            this.rbCategoria.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCategoria.Location = new System.Drawing.Point(316, 33);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(90, 26);
            this.rbCategoria.TabIndex = 1;
            this.rbCategoria.TabStop = true;
            this.rbCategoria.Text = "Categoria";
            this.rbCategoria.UseVisualStyleBackColor = true;
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
            this.toolTip1.SetToolTip(this.txtPesquisa, "Digite o texto para pesquisa");
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // frmBuscaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 328);
            this.Controls.Add(this.groupBoxPesquisa);
            this.Controls.Add(this.dtgBuscaCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscaCategoria";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Categoria - Gourmet Management";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmBuscaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscaCategoria)).EndInit();
            this.groupBoxPesquisa.ResumeLayout(false);
            this.groupBoxPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPesquisa;
        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.TextBox txtPesquisa;
        internal System.Windows.Forms.Button btnRetorna;
        internal System.Windows.Forms.Button btnCadCategoria;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.DataGridView dtgBuscaCategoria;
    }
}