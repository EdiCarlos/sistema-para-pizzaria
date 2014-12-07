using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaParaPizzaria
{
    class Pedido
    {
        //Atributos
        private int idPedido;
        private DateTime dataPedido;
        private int mesa;
        private int qtdPessoas;
        private int idFuncionario;
        private int statusPedido;



        //Propriedades
        public int IdPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }

        public DateTime DataPedido
        {
            get { return dataPedido; }
            set { dataPedido = value; }
        }

        public int Mesa
        {
            get { return mesa; }
            set { mesa = value; }
        }

        public int QtdPessoas
        {
            get { return qtdPessoas; }
            set { qtdPessoas = value; }
        }

        public int IdFuncionario
        {
            get { return idFuncionario; }
            set { idFuncionario = value; }
        }

        public int StatusPedido
        {
            get { return statusPedido; }
            set { statusPedido = value; }
        }

        //Métodos
        /// <summary>
        /// Calcular pagamento
        /// </summary>
        /// <param name="valorPagamento"></param>
        /// <param name="valorDinheiro"></param>
        /// <param name="valorCartao"></param>
        /// <param name="desconto"></param>
        /// <returns>Retorna o toco se tiver</returns>
        public Decimal FazerPagamento(decimal valorPagamento, decimal valorDinheiro = 0.0m, decimal valorCartao = 0.0m, decimal desconto = 0.0m)
        {
            decimal troco = 0;
            decimal valorPagar = valorDinheiro + valorCartao + desconto;
            troco = valorPagar - valorPagamento;
            return troco;
        }
    }
}
