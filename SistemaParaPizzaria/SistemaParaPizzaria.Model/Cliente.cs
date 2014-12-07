using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesenvolveNet;
using System.ComponentModel;
using ValidacoesLibrary;
using System.Windows.Forms;

namespace SistemaParaPizzaria
{
    class Cliente : PessoaFisica
    {
        public Cliente() { }

        public string FormatarCpfCnpj(string strCpfCnpj)
        {
            bool validado;
            Validacoes_DesenvolveNet validar = new Validacoes_DesenvolveNet();
            if (strCpfCnpj.Length <= 11)
            {
                MaskedTextProvider mtpCpf = new MaskedTextProvider(@"000\.000\.000-00");
                mtpCpf.Set(ZerosEsquerda(strCpfCnpj, 11));
                validado = validar.ValidaCpf(Convert.ToString(mtpCpf));
                if (validado == true)
                {
                    return mtpCpf.ToString();
                }
                else
                {
                    return "Entrada Inválida";
                }
            }
            else
            {
                MaskedTextProvider mtpCnpj = new MaskedTextProvider(@"00\.000\.000/0000-00");
                mtpCnpj.Set(ZerosEsquerda(strCpfCnpj, 11));
                validado = validar.ValidaCNPJ(Convert.ToString(mtpCnpj));
                if (validado == true)
                {
                    return mtpCnpj.ToString();
                }
                else
                {
                    return "Entrada Inválida";
                }

            }
        }

        public string FormataTelefone(string telefone)
        {
            if (telefone.Length >= 10)
            {
                MaskedTextProvider mtpTelefone = new MaskedTextProvider(@"00-000000000");
                mtpTelefone.Set(telefone);
                return mtpTelefone.ToString();
            }
            else if(telefone =="")
            {
                return "";
            }
            else  
            {
                return "Entrada Inválida";
            }
        }


        public static string ZerosEsquerda(string strString, int intTamanho)
        {
            string strResult = "";
            for (int intCont = 1; intCont <= (intTamanho - strString.Length); intCont++)
            {
                strResult += "0";
            }
            return strResult + strString;
        }
    }
}
