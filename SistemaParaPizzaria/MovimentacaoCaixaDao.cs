using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace SistemaParaPizzaria
{
    class MovimentacaoCaixaDao
    {
        Conexao bd;

        public MovimentacaoCaixaDao()
        {
            bd = new Conexao();
        }


    }
}
