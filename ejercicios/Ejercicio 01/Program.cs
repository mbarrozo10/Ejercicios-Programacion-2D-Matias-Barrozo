using System;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, minimo = 0, maximo = 0;
            int total = 0;
            float promedio;
            bool flag = true;
            bool flagNumero;
            bool flagRango=false;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresa un numero owo: ");
                flagNumero = int.TryParse(Console.ReadLine(), out numero);
                flagRango = Validador.Validar (numero, -100, 100);
                while (!flagNumero || flagRango==false)
                {
                    Console.WriteLine("Error");
                    flagNumero = int.TryParse(Console.ReadLine(), out numero);
                    flagRango = Validador.Validar(numero, -100, 100);
                }
                total += numero;

                if (flag == true || numero > maximo)
                {
                    //   Math.Max(numero, maximo); se puede usar  mas facil
                    maximo = numero;
                }
                if (flag == true || numero < minimo)
                {
                    //  Math.Min(numero, minimo); Se puede usar mas facil
                    minimo = numero;
                }
                flag = false;
            }
            promedio = (float)total / 5;

            Console.WriteLine("El minimo es " + minimo + "\nEl maximo es " + maximo + "\nEl promedio es " + promedio);
        }
    }
}
