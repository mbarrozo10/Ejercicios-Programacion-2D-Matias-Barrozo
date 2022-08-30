using System;

namespace Ejercicio_2_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int resultado = 1 ;

            Console.WriteLine("Ingrese un numero a factoriar");
            numeroIngresado = int.Parse(Console.ReadLine());
            resultado = numeroIngresado;
            for (int i= numeroIngresado-1;i>1;i--)
            {
                resultado *= i;
            }

            Console.WriteLine(resultado);
        }
    }
}
