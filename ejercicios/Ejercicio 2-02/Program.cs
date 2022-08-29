using System;

namespace Ejercicio_2_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = true;
            int numeroIngresado;
            bool checkSalida;
            int sumador = 0 ;

            while (salir == true)
            {
                Console.WriteLine("Ingrese numeros para sumar");
                checkSalida = int.TryParse(Console.ReadLine(), out numeroIngresado);
                while(checkSalida == false)
                {
                    Console.WriteLine("error, Ingrese numeros para sumar");
                    checkSalida = int.TryParse(Console.ReadLine(), out numeroIngresado);
                }
                sumador += numeroIngresado;
                salir= Validador.ValidarRespuesta();
            }
            Console.WriteLine("Total de la suma: " + sumador);    

        }
    }
}
