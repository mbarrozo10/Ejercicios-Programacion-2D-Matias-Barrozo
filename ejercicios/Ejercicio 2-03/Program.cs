using System;

namespace Ejercicio_2_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            bool checkIngreso;
            string numeroBinario;
            int numeroDecimal;

            Console.WriteLine("Ingrese el tipo de numero: \n1-Decimal\n2-Binario");
            checkIngreso=int.TryParse(Console.ReadLine(), out numeroIngresado);
            while (!checkIngreso)
            {
                Console.WriteLine("Ingrese el tipo de numero: \n1-Decimal a binario\n2-Binario a decimal");
                checkIngreso = int.TryParse(Console.ReadLine(), out numeroIngresado);
            }
            if (numeroIngresado == 1)
            {
                Console.WriteLine("Ingrese el numero");
                numeroIngresado = int.Parse(Console.ReadLine());
                numeroBinario = Conversor.ConvertirDecimalABinario(numeroIngresado);
                Console.WriteLine("El numero convertido es: " + numeroBinario);
            }
            else
            {
                Console.WriteLine("Ingrese el numero");
                numeroIngresado = int.Parse(Console.ReadLine());
                numeroDecimal = Conversor.ConvertirBinarioADecimal(numeroIngresado);
                Console.WriteLine("El numero convertido es: " + numeroDecimal);
            }
        }
    }
}
