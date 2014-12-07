using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaParaPizzaria
{
    class ProdutoComposto : Produto
    {
        private int idProdutoComposto;
        public int IdProdutoComposto
        {
            get { return idProdutoComposto; }
            set { idProdutoComposto = value; }
        }
        private decimal qtdIngrediente;
        public decimal QtdIngrediente
        {
            get { return qtdIngrediente; }
            set { qtdIngrediente = value; }
        }

       

        public decimal CalculaValorIngrediente(decimal qtd, decimal valorUnitario) 
        {
            decimal retorno = 0;
            retorno = qtd * valorUnitario;
            return retorno;
        }
    }
}
