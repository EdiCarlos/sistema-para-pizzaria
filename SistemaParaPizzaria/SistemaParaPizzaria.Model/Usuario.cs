using System.Text;
using System.Security.Cryptography;

namespace SistemaParaPizzaria
{
    class Usuario
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string funcao;
        public string Funcao
        {
            get { return funcao; }
            set { funcao = value; }
        }

        private string senha;
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private int ativo;
        public int Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }




        /// <summary>
        /// Compara as dua senhas digitadas para cadastro se são iguais.
        /// </summary>
        /// <param name="senha1"></param>
        /// <param name="senha2"></param>
        /// <returns>Verdadeiro ou Falso</returns>
        public bool ConfirmaSenha(string senha1, string senha2) 
        {
            bool retorno;
            if(senha1 != senha2)
            {
                retorno = false;
            }
            else
            {
                retorno = true;
            }

            return retorno;
        }


        /// <summary>
        /// Criptografia de sentido único, unilateral.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>String criptografada</returns>
        public string GetCriptografiaMD5(string valor)
        {         
            MD5 md5Hasher = MD5.Create();           
            byte[] valorCriptografado = md5Hasher.ComputeHash(Encoding.Default.GetBytes(valor));          
            StringBuilder retorno = new StringBuilder();           
            for (int i = 0; i < valorCriptografado.Length; i++)
            {
                retorno.Append(valorCriptografado[i].ToString("x2"));
            }         
            return retorno.ToString();
        }
    }
}
