using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaParaPizzaria
{
   static class Login 
    {
        static string nome;
        public static string Nome
        {
            get { return Login.nome; }
            set { Login.nome = value; }
        }

        static string user;
        public static string User
        {
            get { return Login.user; }
            set { Login.user = value; }
        }

        static string senha;
        public static string Senha
        {
            get { return Login.senha; }
            set { Login.senha = value; }
        }

        static string tipo;
        public static string Tipo
        {
            get { return Login.tipo; }
            set { Login.tipo = value; }
        }

        static bool existe;
        public static bool Existe
        {
            get { return Login.existe; }
            set { Login.existe = value; }
        }      
              

        //Método para validar usuário e senha
        public static Boolean Logar(string usuario, string senha)
        {
            //Com acesso a dados
            LoginDao loginDao = new LoginDao();
           
            Usuario user = new Usuario();

            User = usuario;
            Senha = user.GetCriptografiaMD5(senha);

            loginDao.BuscaUsuario(User,Senha);

            if (Existe == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Logout() 
        {
            Nome = null;
            User = null;
            Senha = null;
            Tipo = null;
            Existe = false;
        }
    }
}
