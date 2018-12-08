using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Cliente
{
    class Utilidades
    {        
        public static bool cuilValido(string unCuil)
        {
            string cuil = unCuil.Replace("[^\\d]", "");

            switch (cuil.Substring(0,2))
            {
                case "30":
                case "33":
                case "34":
                    MessageBox.Show(cuil.Substring(0, 2));
                    return false;
            }

            if (cuil.Length != 11)
            {
                return false;
            }

            char[] arrayCuil = cuil.ToCharArray();
            int[] multiplicadores = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int aux = 0;

            for (int i = 0; i < 10; i++)
            {
                aux += Convert.ToInt32(arrayCuil[i]) * multiplicadores[i];
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
