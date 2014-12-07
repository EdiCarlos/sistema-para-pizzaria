using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SistemaParaPizzaria
{
    class Produto
    {
        //Atributos
        private int idProduto;
        private string descricao;
        private int idCategoria;
        private int idFornecedor;
        private string unidade;
        private decimal qtdEstoque;
        private decimal valorUnitario; //valor de venda 
        private decimal estoqueMinimo;
        private string tipo;
        private decimal valorCompra;
        private decimal porcentagem;
        private string observacao;

       


        //Propriedades
        public int IdProduto
        {
            get { return idProduto; }
            set { idProduto = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }


        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        public int IdFornecedor
        {
            get { return idFornecedor; }
            set { idFornecedor = value; }
        }

        public string Unidade
        {
            get { return unidade; }
            set { unidade = value; }
        }

        public decimal QtdEstoque
        {
            get { return qtdEstoque; }
            set { qtdEstoque = value; }
        }

        public decimal ValorUnitario
        {
            get { return valorUnitario; }
            set { valorUnitario = value; }
        }

        public decimal EstoqueMinimo
        {
            get { return estoqueMinimo; }
            set { estoqueMinimo = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public decimal ValorCompra
        {
            get { return valorCompra; }
            set { valorCompra = value; }
        }

        public decimal Porcentagem
        {
            get { return porcentagem; }
            set { porcentagem = value; }
        }


        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }


        //Construtor
        public Produto()
        {
            this.tipo = "Normal";
            this.qtdEstoque = 0;
        }

        //Métodos


        /// <summary>
        /// Calcula o valor do item e quantidade comprada
        /// </summary>
        /// <param name="qtdPProduto"></param>
        /// <param name="valorUnitario"></param>
        /// <returns>Valor total do item</returns>
        public Decimal CalculaValorDoItem(decimal qtdPProduto, decimal valorUnitario)
        {
            decimal valorTotal;
            valorTotal = qtdPProduto * valorUnitario;

            return valorTotal;
        }


        /// <summary>
        /// Calcula baixa do estoque
        /// </summary>
        /// <param name="quantidade">qtd a ser baixada</param>
        /// <returns>Estoque atualizado</returns>
        public Decimal BaixarEstoque(decimal quantidade)
        {

            this.qtdEstoque -= quantidade;

            if (this.qtdEstoque < 0)
            {
                this.qtdEstoque = 0;
            }

            return this.qtdEstoque;
        }


        /// <summary>
        /// Calcula o estorno do estoque
        /// </summary>
        /// <param name="quantidade">qtd a ser estornada</param>
        /// <returns>Estoque atualizado</returns>
        public Decimal EstornaEstoque(decimal quantidade)
        {

            this.qtdEstoque += quantidade;

            if (this.qtdEstoque < 0)
            {
                this.qtdEstoque = 0;
            }

            return this.qtdEstoque;
        }


        /// <summary>
        /// Calcula o valor do produto para venda.
        /// </summary>
        /// <param name="porcentagem">Porcentagem margem de lucro</param>
        public void CalculaValorProdutoVendaPorcentagem(decimal porcentagem)
        {            
             this.valorUnitario = valorCompra + (valorCompra * (porcentagem / 100));       
        }

        /// <summary>
        /// Calcula a porcentagem margem de lucro.
        /// </summary>
        /// <param name="valorVenda">Valor Venda</param>
        public void CalculaValorProdutoVendaValor(decimal valorVenda)
        {
            this.porcentagem = (valorVenda - this.valorCompra) / this.valorCompra * 100;
        }

    }
}
