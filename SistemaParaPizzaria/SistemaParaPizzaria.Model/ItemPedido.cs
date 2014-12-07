using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SistemaParaPizzaria
{
    class ItemPedido
    {
        //Atributo e Propriedades
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int idProduto;

        public int IdProduto
        {
            get { return idProduto; }
            set { idProduto = value; }
        }
        private decimal qtdProduto;

        public decimal QtdProduto
        {
            get { return qtdProduto; }
            set { qtdProduto = value; }
        }

        private int idPedido;

        public int IdPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }



    }
}
