using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaParaPizzaria
{
    class Categoria
    {
        private int idCategoria;
        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }


        private string nomeCategoria;
        public string NomeCategoria
        {
            get { return nomeCategoria; }
            set { nomeCategoria = value; }
        }
    }
}
