using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaParaPizzaria.SistemaParaPizzaria.Model
{
   public static class BusinessModel
    {
       public static void AloowNumbers(KeyPressEventArgs e)
       {
           if (char.IsLetter(e.KeyChar) || //Letras
               char.IsSymbol(e.KeyChar) || //Símbolos
               char.IsWhiteSpace(e.KeyChar) || //Espaço
               char.IsPunctuation(e.KeyChar)) //Pontuação
               e.Handled = true;  // Não Permitir


           //Abaixo só é permitido de 0 a 9
           if ((e.KeyChar < '0') || (e.KeyChar > '9'))
           {
               e.Handled = true;
           }
       }
    }
}
