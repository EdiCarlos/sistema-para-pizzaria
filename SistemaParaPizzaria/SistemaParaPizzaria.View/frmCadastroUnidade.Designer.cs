namespace SistemaParaPizzaria
{
    partial class frmCadastroUnidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUnidade));
            this.label7 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRetorna = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExclui = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Unidade";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnRetorna);
            this.GroupBox2.Controls.Add(this.btnIncluir);
            this.GroupBox2.Controls.Add(this.btnExclui);
            this.GroupBox2.Controls.Add(this.btnCancela);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(12, 114);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox2.Size = new System.Drawing.Size(389, 62);
            this.GroupBox2.TabIndex = 15;
            this.GroupBox2.TabStop = false;
            // 
            // btnRetorna
            // 
            this.btnRetorna.BackColor = System.Drawing.Color.Transparent;
            this.btnRetorna.Image = global::SistemaParaPizzaria.Properties.Resources.undo;
            this.btnRetorna.Location = new System.Drawing.Point(289, 13);
            this.btnRetorna.Name = "btnRetorna";
            this.btnRetorna.Size = new System.Drawing.Size(77, 41);
            this.btnRetorna.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnRetorna, "Retorna");
            this.btnRetorna.UseVisualStyleBackColor = false;
            this.btnRetorna.Click += new System.EventHandler(this.btnRetorna_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.Transparent;
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.Location = new System.Drawing.Point(22, 13);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(77, 41);
            this.btnIncluir.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnIncluir, "Salvar");
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExclui
            // 
            this.btnExclui.BackColor = System.Drawing.Color.Transparent;
            this.btnExclui.Image = ((System.Drawing.Image)(resources.GetObject("btnExclui.Image")));
            this.btnExclui.Location = new System.Drawing.Point(200, 14);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(77, 41);
            this.btnExclui.TabIndex = 32;
            this.toolTip1.SetToolTip(this.btnExclui, "Excluir");
            this.btnExclui.UseVisualStyleBackColor = false;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.Color.Transparent;
            this.btnCancela.Image = ((System.Drawing.Image)(resources.GetObject("btnCancela.Image")));
            this.btnCancela.Location = new System.Drawing.Point(111, 13);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(77, 41);
            this.btnCancela.TabIndex = 31;
            this.toolTip1.SetToolTip(this.btnCancela, "Cancelar");
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUnidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Location = new System.Drawing.Point(12, 75);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(389, 24);
            this.cmbUnidade.TabIndex = 16;
            this.cmbUnidade.SelectedIndexChanged += new System.EventHandler(this.cmbUnidade_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(302, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 4);
            this.label12.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DimGray;
            this.label11.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(-1, -2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(420, 51);
            this.label11.TabIndex = 27;
            this.label11.Text = "Cadastro de Unidades";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCadastroUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 181);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbUnidade);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroUnidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gourmet Management";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCadastroUnidade_Load);
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnIncluir;
        internal System.Windows.Forms.Button btnExclui;
        internal System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button btnRetorna;
    }
}