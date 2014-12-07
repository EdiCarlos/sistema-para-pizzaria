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
    public partial class frmMovimentacaoCaixa : Form
    {
        public frmMovimentacaoCaixa()
        {
            InitializeComponent();
        }

        private void btnRetorna_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
