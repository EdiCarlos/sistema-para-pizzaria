using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaParaPizzaria
{
    class Mesa
    {
        private int idMesa;

        public int IdMesa
        {
            get { return idMesa; }
            set { idMesa = value; }
        }
        private int numeroMesa;

        public int NumeroMesa
        {
            get { return numeroMesa; }
            set { numeroMesa = value; }
        }
        private int statusMesa;

        public int StatusMesa
        {
            get { return statusMesa; }
            set { statusMesa = value; }
        }



        public Mesa() { }

        /// <summary>
        /// Verifica o status das mesas 
        /// </summary>
        /// <returns>Retorna um array com os status das mesas</returns>
        public int[] VerificaStatusMesa()
        {
            int[] status = new int[18];
            int j = 1;
            int x;
            MesaDao mesaDao = new MesaDao();

            for (x = 0; x <= 17; x++)
            {
                status[x] = mesaDao.GetStatusMesa(Convert.ToInt32(j));
                j++;
            }
            return status;        }
    }
}
