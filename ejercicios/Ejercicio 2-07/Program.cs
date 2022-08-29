using System;

namespace Ejercicio_2_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura;
            double baseGenerica;
            double resultado;

            Console.Write("Ingrese la base: ");
            baseGenerica= double.Parse(Console.ReadLine());
            Console.Write("\nIngrese la altura: ");
            altura= double.Parse(Console.ReadLine());

            resultado= Math.Pow(altura,2) + Math.Pow(baseGenerica,2);

            resultado= Math.Sqrt(resultado);

            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
