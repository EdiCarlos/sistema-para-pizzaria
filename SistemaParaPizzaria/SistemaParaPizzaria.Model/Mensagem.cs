using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaParaPizzaria
{
    /// <summary>
    /// Classe static para tratamento das mensagens.
    /// </summary>
   static class Mensagem
    {
       private static string applicationName = "Gourmet Management";

       /// <summary>
       /// Título da mensagem junto com o nome do sistema.
       /// </summary>
       /// <param name="tipoMensagem">Tipo de mensagem</param>
       /// <returns>Título da mensagem e nome do sistema</returns>
       public static String GetMensagemTitulo(string tipoMensagem)
       {
           return tipoMensagem + " - " + applicationName;
       }


       /// <summary>
       /// Mensagem de erro do sistema.
       /// </summary>
       /// <param name="erro">mensagem</param>
       /// <returns>Mensagem de erro</returns>
       public static String GetMensagemErro(string erro) 
       {
           return "Erro: " + erro + ".";
       }

       /// <summary>
       /// Mensagem de confirmação do sistema.
       /// </summary>
       /// <returns>Mensagem Confirmação</returns>
       public static String GetMensagemConfirmacao()
       {
           return "A operação foi concluída com sucesso.";
       }


       /// <summary>
       ///  Mensagem de confirmação do sistema com o número de registro afetado.
       /// </summary>
       /// <param name="qtdRegistros">Qtd. de registros.</param>
       /// <returns>Mensagem Confirmação</returns>
       public static String GetMensagemConfirmacao(int qtdRegistros)
       {
           return "A operação foi concluída com sucesso, " + qtdRegistros + " Registro(s) afetado(s).";
       }

    }
}
