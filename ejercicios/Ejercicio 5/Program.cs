using System;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            bool checkIngreso = false;
            bool retorno = false;
            Console.WriteLine("Ingrese el limite: ");
            checkIngreso = int.TryParse(Console.ReadLine(),out numeroIngresado);
            while (!checkIngreso)
            {
                Console.WriteLine("Error, Ingrese un numero: ");
                checkIngreso = int.TryParse(Console.ReadLine(), out numeroIngresado);
            }

            for(int i = 1; i <= numeroIngresado; i++)
            {
               retorno= buscarCentro(i, numeroIngresado);
                if (retorno == true)
                {
                    Console.WriteLine("El centro es :" + i);
                    break;
                }
            }
            if (retorno == false)
            {
                Console.WriteLine("No hay centro numerico"); 
            }
        }
        static bool buscarCentro(int numero, int limite)
        {
            bool retorno = false;
            int grupoUno = 0;
            int grupoDos = 0;
            for (int i = 1; i < numero; i++)
            {
                if (i != numero)
                {
                    grupoUno += i;
                }
            }
            if (numero != limite)
            {
                for (int i = numero+1; i <= limite; i++)
                {
                    grupoDos += i;
                }    
            }

            retorno = grupoDos == grupoUno;
            return retorno;
        }
    }
}
