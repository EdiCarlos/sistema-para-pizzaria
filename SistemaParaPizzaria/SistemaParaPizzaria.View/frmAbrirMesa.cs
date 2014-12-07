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
    public partial class frmAbrirMesa : Form
    {
     
        public frmAbrirMesa(String numeroMesa)
        {
            InitializeComponent();
            txtMesa.Text = numeroMesa;
        }

        private void btnRetorna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirMesa_Click(object sender, EventArgs e)
        {
            abrirPedidoMesa();
            alteraStatusMesa();
            retornaPrincipal();
        }


        #region Funções
        /// <summary>
        ///Abre o pedido para a mesa setada
        /// </summary>
        private void abrirPedidoMesa()
        {
            Pedido pedido = new Pedido();
            PedidoDao pedidoDao = new PedidoDao();
            pedido.DataPedido = DateTime.Now;
            pedido.Mesa = Convert.ToInt32(txtMesa.Text.Trim());
            if (txtQtdPessoas.Text == "")
            {
                pedido.QtdPessoas = 0;
            }
            else
            {
                pedido.QtdPessoas = Convert.ToInt32(txtQtdPessoas.Text.Trim());
            }
            pedido.IdFuncionario = 1;//Convert.ToInt32(pedido.IdFuncionario);        
            pedidoDao.GravaPedido(pedido);
        }

        /// <summary>
        ///  Altera o status da mesa para ocupada
        /// </summary>
        private void alteraStatusMesa()
        {

            Mesa mesa = new Mesa();
            MesaDao mesaDao = new MesaDao();
            mesa.StatusMesa = 1;
            mesa.NumeroMesa = Convert.ToInt32(txtMesa.Text.Trim());
            mesaDao.AlteraStatusMesa(mesa);
        }

        /// <summary>
        /// Retorna ao form principal(mesas) e atualiza o status das mesas
        /// </summary>
        private void retornaPrincipal()
        {
            frmPrincipal retorno = (frmPrincipal)this.Owner;
            retorno.carregaStatusMesa();
            this.Close();
        }
        #endregion

       

    }
}
