using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_02
{
    public class Validador
    {
        public static bool ValidarRespuesta()
        {
            bool retorno = false;
            string caracterIngresado;
            Console.WriteLine("¿Desea Continuar? S/N");
            caracterIngresado= Console.ReadLine();
            if (caracterIngresado== "s" || caracterIngresado == "S")
            {
                retorno= true;
            }

            return retorno;
        }

    }
}
