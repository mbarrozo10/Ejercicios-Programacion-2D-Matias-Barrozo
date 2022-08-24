using System;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] numeroPerfecto = new int[4] ;
            int limite= 8128;
            int acumulador=0;
            int x=0;
            for(int i= 2; i <= limite; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        acumulador += j;
                    }
                   
                }
                if (acumulador == i)
                {
                    numeroPerfecto[x]=acumulador;
                    x++;
                }
                acumulador = 0;
            }

                foreach (int i in numeroPerfecto)
                {
                    Console.WriteLine(i);
                }
           }
    }
}
