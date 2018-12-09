using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    class Utilidades
    {
        public static bool cuitValido(string unCuit)
        {
            string cuit = unCuit.Replace("[^\\d]", "");

            switch (cuit.Substring(0, 2))
            {
                case "20":
                case "23":
                case "24":
                case "27":
                    return false;
            }

            MessageBox.Show(cuit.ToString());

            if (cuit.Length != 11)
            {
                return false;
            }

            int[] arrayCuil = new int[11];
            for (int i = 0; i < cuit.Length; i++)
                arrayCuil[i] = cuit[i] - '0';
            int[] multiplicadores = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            decimal aux = 0;

            for (int i = 0; i < 10; i++)
            {
                aux += Convert.ToInt16(arrayCuil[i]) * multiplicadores[i];
            }

            aux = 11 - (aux % 11);

            if (aux == 11)
            {
                aux = 0;
            }

            return (Convert.ToInt32(arrayCuil[10]) == aux);

        }
    }
}
