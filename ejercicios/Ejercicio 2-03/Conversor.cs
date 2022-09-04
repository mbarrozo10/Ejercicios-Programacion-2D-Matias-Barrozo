using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_03
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string retorno= "";
            bool check=false;
            StringBuilder stringInvertido = new StringBuilder();
            while (check == false) {
                retorno += numeroEntero % 2;
                numeroEntero /= 2;
                if (numeroEntero == 0)
                {
                    check = true;
                }
            }
            for (int i = retorno.Length - 1; i >= 0; i--)
            {
                stringInvertido.Append(retorno[i]);
            }
            return stringInvertido.ToString();
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int auxiliar=0;
            int numero=0;
            int i =numeroEntero;
            for (int j=0; i>0 ; i /= 10 ,j++)
            {
                auxiliar = i % 10;
                if (auxiliar != 0 && auxiliar != 1)
                {
                    return -1;
                }
                numero += auxiliar * (int)Math.Pow(2, j);
              
            }

            return numero ;
        }

    }
}
