using System;
using System.Runtime.InteropServices;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool flag;
            bool esPrimo;
            bool salir=false;
            int salida=0;

            while (salir == false)
            {
                Console.WriteLine("Ingrese el numero: ");
                flag = int.TryParse(Console.ReadLine(),out numero);

                while (!flag)
                {
                    Console.WriteLine("Error");
                    flag = int.TryParse(Console.ReadLine(),out numero);
                }

                for (int i = 1; i <= numero; i++)
                {
                    esPrimo = Primo(i);
                    if(esPrimo == true)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("Quiere salir? 1-si 0-no");
                salida=int.Parse(Console.ReadLine());
                if (salida == 1)
                {
                    salir = true;
                }

            }
        }
        static bool Primo (int numero)
        {
            int contadorDeDivisores=0;
            bool retorno=false;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contadorDeDivisores++;
                }
            }
            if (contadorDeDivisores == 2)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
