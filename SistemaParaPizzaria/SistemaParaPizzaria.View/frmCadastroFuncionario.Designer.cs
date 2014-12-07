namespace SistemaParaPizzaria
{
    partial class frmCadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFuncionario));
            this.GroupBoxInfoUsuario = new System.Windows.Forms.GroupBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.rbLimitado = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.btnRetorna = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnExclui = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBoxInfoUsuario.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxInfoUsuario
            // 
            this.GroupBoxInfoUsuario.Controls.Add(this.cmbUsuario);
            this.GroupBoxInfoUsuario.Controls.Add(this.rbLimitado);
            this.GroupBoxInfoUsuario.Controls.Add(this.rbAdmin);
            this.GroupBoxInfoUsuario.Controls.Add(this.txtConfSenha);
            this.GroupBoxInfoUsuario.Controls.Add(this.txtSenha);
            this.GroupBoxInfoUsuario.Controls.Add(this.txtFuncao);
            this.GroupBoxInfoUsuario.Controls.Add(this.txtUserName);
            this.GroupBoxInfoUsuario.Controls.Add(this.label5);
            this.GroupBoxInfoUsuario.Controls.Add(this.label1);
            this.GroupBoxInfoUsuario.Controls.Add(this.label2);
            this.GroupBoxInfoUsuario.Controls.Add(this.label16);
            this.GroupBoxInfoUsuario.Controls.Add(this.label7);
            this.GroupBoxInfoUsuario.Location = new System.Drawing.Point(11, 66);
            this.GroupBoxInfoUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxInfoUsuario.Name = "GroupBoxInfoUsuario";
            this.GroupBoxInfoUsuario.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxInfoUsuario.Size = new System.Drawing.Size(490, 195);
            this.GroupBoxInfoUsuario.TabIndex = 37;
            this.GroupBoxInfoUsuario.TabStop = false;
            this.GroupBoxInfoUsuario.Text = "Informações do Usuário";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(16, 35);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(462, 24);
            this.cmbUsuario.TabIndex = 0;
            this.cmbUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.cmbUsuario_Validating);
            // 
            // rbLimitado
            // 
            this.rbLimitado.AutoSize = true;
            this.rbLimitado.Location = new System.Drawing.Point(141, 163);
            this.rbLimitado.Name = "rbLimitado";
            this.rbLimitado.Size = new System.Drawing.Size(64, 17);
            this.rbLimitado.TabIndex = 6;
            this.rbLimitado.TabStop = true;
            this.rbLimitado.Text = "Limitado";
            this.rbLimitado.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(17, 163);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(88, 17);
            this.rbAdmin.TabIndex = 5;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Administrador";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.BackColor = System.Drawing.Color.White;
            this.txtConfSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfSenha.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txtConfSenha.ForeColor = System.Drawing.Color.Black;
            this.txtConfSenha.Location = new System.Drawing.Point(265, 125);
            this.txtConfSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '*';
            this.txtConfSenha.Size = new System.Drawing.Size(215, 25);
            this.txtConfSenha.TabIndex = 4;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(16, 125);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(215, 25);
            this.txtSenha.TabIndex = 3;
            // 
            // txtFuncao
            // 
            this.txtFuncao.BackColor = System.Drawing.Color.White;
            this.txtFuncao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFuncao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFuncao.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncao.ForeColor = System.Drawing.Color.Black;
            this.txtFuncao.Location = new System.Drawing.Point(265, 81);
            this.txtFuncao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(215, 22);
            this.txtFuncao.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(16, 81);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(215, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Confirma  a Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Função";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Senha";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 16);
            this.label16.TabIndex = 12;
            this.label16.Text = "User Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nome";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(284, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 4);
            this.label12.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DimGray;
            this.label11.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(-1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(515, 62);
            this.label11.TabIndex = 43;
            this.label11.Text = "Cadastro de Usuário";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.btnRetorna);
            this.groupBoxMenu.Controls.Add(this.btnSalva);
            this.groupBoxMenu.Controls.Add(this.btnExclui);
            this.groupBoxMenu.Controls.Add(this.btnCancela);
            this.groupBoxMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMenu.Location = new System.Drawing.Point(12, 267);
            this.groupBoxMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMenu.Size = new System.Drawing.Size(490, 62);
            this.groupBoxMenu.TabIndex = 44;
            this.groupBoxMenu.TabStop = false;
            // 
            // btnRetorna
            // 
            this.btnRetorna.BackColor = System.Drawing.Color.Transparent;
            this.btnRetorna.Image = global::SistemaParaPizzaria.Properties.Resources.undo;
            this.btnRetorna.Location = new System.Drawing.Point(367, 14);
            this.btnRetorna.Name = "btnRetorna";
            this.btnRetorna.Size = new System.Drawing.Size(77, 41);
            this.btnRetorna.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnRetorna, "Sair");
            this.btnRetorna.UseVisualStyleBackColor = false;
            this.btnRetorna.Click += new System.EventHandler(this.btnRetorna_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.Transparent;
            this.btnSalva.Image = ((System.Drawing.Image)(resources.GetObject("btnSalva.Image")));
            this.btnSalva.Location = new System.Drawing.Point(46, 14);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(77, 41);
            this.btnSalva.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnSalva, "Salvar");
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnExclui
            // 
            this.btnExclui.BackColor = System.Drawing.Color.Transparent;
            this.btnExclui.Image = ((System.Drawing.Image)(resources.GetObject("btnExclui.Image")));
            this.btnExclui.Location = new System.Drawing.Point(260, 14);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(77, 41);
            this.btnExclui.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnExclui, "Excluir");
            this.btnExclui.UseVisualStyleBackColor = false;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.Color.Transparent;
            this.btnCancela.Image = ((System.Drawing.Image)(resources.GetObject("btnCancela.Image")));
            this.btnCancela.Location = new System.Drawing.Point(153, 14);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(77, 41);
            this.btnCancela.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnCancela, "Cancelar");
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // frmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 336);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.GroupBoxInfoUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário - Gourmet Management";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCadastroFuncionario_Load);
            this.GroupBoxInfoUsuario.ResumeLayout(false);
            this.GroupBoxInfoUsuario.PerformLayout();
            this.groupBoxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBoxInfoUsuario;
        internal System.Windows.Forms.TextBox txtSenha;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.GroupBox groupBoxMenu;
        internal System.Windows.Forms.Button btnRetorna;
        internal System.Windows.Forms.Button btnSalva;
        internal System.Windows.Forms.Button btnExclui;
        internal System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton rbLimitado;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.ComboBox cmbUsuario;
        internal System.Windows.Forms.TextBox txtFuncao;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtConfSenha;
    }
}