using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaParaPizzaria
{
    class MovimentacaoCaixa
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string tipoMovimento;
        public string TipoMovimento
        {
            get { return tipoMovimento; }
            set { tipoMovimento = value; }
        }

        private string caixa;
        public string Caixa
        {
            get { return caixa; }
            set { caixa = value; }
        }

        private string operador;
        public string Operador
        {
            get { return operador; }
            set { operador = value; }
        }

        private decimal valor;
        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private string motivo;
        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }





    }
}
