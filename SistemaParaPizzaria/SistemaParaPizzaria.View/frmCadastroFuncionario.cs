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
    public partial class frmCadastroFuncionario : Form
    {
        string opcao;
        string tipo;
        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }


        #region Eventos
        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            CarregaComboboxUsuario();
            opcao = "Incluir";
        }

        private void btnRetorna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.Text != "")
            {
                if (rbAdmin.Checked)
                {
                    tipo = "Admin";
                }
                else if (rbLimitado.Checked)
                {
                    tipo = "Limitado";
                }
                else
                {
                    MessageBox.Show("Por favor, indique o tipo de permissão desse usuário.",
                                     Mensagem.GetMensagemTitulo("Aviso!"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

                UsuarioDao usuarioDao = new UsuarioDao();
                Usuario usuario = new Usuario();

                usuario.Nome = cmbUsuario.Text.Trim();
                usuario.UserName = txtUserName.Text.Trim();
                usuario.Senha = usuario.GetCriptografiaMD5(txtSenha.Text.Trim());
                usuario.Funcao = txtFuncao.Text.Trim();
                usuario.Tipo = tipo;


                if (usuario.ConfirmaSenha(txtSenha.Text.Trim(), txtConfSenha.Text.Trim()) == true)
                {
                    if (opcao == "Incluir")
                    {
                        usuarioDao.IncluiUsuario(usuario);
                    }

                    else if (opcao == "Alterar")
                    {
                        usuario.Id = Convert.ToInt32(cmbUsuario.SelectedValue);
                        usuarioDao.AlteraUsuario(usuario);
                    }
                }
                else
                {
                    txtSenha.Text = "";
                    txtConfSenha.Text = "";
                    txtSenha.Focus();
                    return;
                }
            }
            
            //Preparar form para novo registro
            opcao = "Incluir";
            LimpaCampo();
            cmbUsuario.Focus();
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.Text != "")
            {
                UsuarioDao usuarioDao = new UsuarioDao();
                Usuario usuario = new Usuario();

                usuario.Id = Convert.ToInt32(cmbUsuario.SelectedValue);
                usuarioDao.ExcluiUsuario(usuario);
                LimpaCampo();
                CarregaComboboxUsuario();
            }

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            opcao = "Incluir";
            LimpaCampo();
            cmbUsuario.Focus();
        }

        private void cmbUsuario_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (cmbUsuario.Text != "")
                {                  
                    UsuarioDao usuarioDao = new UsuarioDao();
                    Usuario usuario = new Usuario();
                    usuario.Id = Convert.ToInt32(cmbUsuario.SelectedValue);
                    if(usuario.Id != 0)
                    {
                        opcao = "Alterar";
                        usuarioDao.GetUsuario(usuario);

                        txtUserName.Text = usuario.UserName;
                        txtFuncao.Text = usuario.Funcao;
                        txtSenha.Text = usuario.Senha;
                      
                        if (usuario.Tipo == "Admin")
                        {
                            rbAdmin.Checked = true;
                        }
                        else if (usuario.Tipo == "Limitado")
                        {
                            rbLimitado.Checked = true;
                        }
                        else
                        {
                            usuario = null;
                            usuarioDao = null;
                            opcao = "Incluir";
                        }
                    }
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Mensagem.GetMensagemErro(ex.Message.ToString()), Mensagem.GetMensagemTitulo("ERRO").ToString());
            }
        }

        #endregion

        #region Funções
        private void CarregaComboboxUsuario()
        {
            UsuarioDao usuarioDao = new UsuarioDao();
            cmbUsuario.DataSource = usuarioDao.Usuario("");
            cmbUsuario.DisplayMember = "nome";
            cmbUsuario.ValueMember = "id";
            cmbUsuario.Text = "";
            opcao = "Incluir";
        }

        private void LimpaCampo()
        {
            cmbUsuario.Text = String.Empty;
            txtUserName.Text = String.Empty;
            txtFuncao.Text = String.Empty;
            txtSenha.Text = String.Empty;
            txtConfSenha.Text = String.Empty;
            rbAdmin.Checked = false;
            rbLimitado.Checked = false;
        }
        #endregion    

    }
}
