using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    public class Validador
    {

       public static bool Validar (int valor, int min, int max)
        {
            bool retorno=false;
            if(valor>min && valor < max)
            {
                retorno = true;
            }
            return retorno;
        }

    }
}
