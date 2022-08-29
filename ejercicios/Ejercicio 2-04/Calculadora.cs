using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_04
{
    public class Calculadora
    {

        public static float Calcular (int numeroUno, int numeroDos, string operacion)
        {
            float retorno=0;
            switch (operacion)
            {
                case "+":
                    retorno=numeroDos+numeroUno;
                    break;
                case "*":
                    retorno=numeroDos*numeroUno;
                    break;
                case "-":
                    retorno = numeroUno - numeroDos;
                    break;
                case "/":
                    if(Validar(numeroDos))
                    {
                        retorno= (float) numeroUno /numeroDos;
                    }
                    else
                    {
                        Console.WriteLine("Error, no se puede dividir en 0, ingrese nuevamente el numero dos:");
                        numeroDos = int.Parse(Console.ReadLine());
                        retorno =(float) numeroUno / numeroDos;
                    }
                    break;
                default:
                    Console.WriteLine("Ingrese una de las operaciones dadas");
                    break;
            }

            return retorno;
        }

        static bool Validar(int numeroDos)
        {
            bool retorno = false;

            if (numeroDos != 0) { 
                retorno = true;
            }

            return retorno;
        }

        public static bool ValidarRespuesta()
        {
            bool retorno = false;
            string caracterIngresado;
            Console.WriteLine("¿Desea Continuar? S/N");
            caracterIngresado = Console.ReadLine();
            if (caracterIngresado == "s" || caracterIngresado == "S")
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
