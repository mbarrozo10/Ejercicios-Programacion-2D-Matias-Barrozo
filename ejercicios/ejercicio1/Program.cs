using System;
using System.Runtime.InteropServices;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, minimo =0 , maximo=0;
            int total=0;
            float promedio;
            bool flag =true;
            bool flagNumero;
          
            for(int i=0; i < 5; i++)
            {
                flagNumero = int.TryParse(Console.ReadLine(),out numero);
                while (!flagNumero)
                {
                    Console.WriteLine("Error");
                    flagNumero = int.TryParse(Console.ReadLine(), out numero);
                }
                total += numero;

                if(flag==true || numero>maximo)
                {
                 //   Math.Max(numero, maximo); se puede usar  mas facil
                    maximo = numero;
                }
                if (flag==true || numero<minimo)
                {
                 //  Math.Min(numero, minimo); Se puede usar mas facil
                    minimo = numero;
                }
                flag = false;
            }
            promedio = (float) total / 5;

            Console.WriteLine("El minimo es " + minimo + "\nEl maximo es " + maximo + "\nEl promedio es " + promedio);
        }
    }
}
