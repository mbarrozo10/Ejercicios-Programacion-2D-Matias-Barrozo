using System;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double cuadrado;
            double cubo;
            numero= int.Parse(Console.ReadLine());
            while (numero < 1)
            {
                Console.WriteLine("Error");
                numero = int.Parse(Console.ReadLine());
            }

            cubo = Math.Pow(numero, 3);
            cuadrado= Math.Pow(numero, 2);

            Console.WriteLine("El cuadrado es: " + cuadrado + "Y el cubo es: "+ cubo);

        }
    }
}
