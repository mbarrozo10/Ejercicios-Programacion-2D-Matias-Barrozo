using System;
using System.Text;

namespace Ejercicio_2_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string retorno;
            bool check;
            int numeroIngresado;

            Console.WriteLine("Ingrese un numero");
            check = int.TryParse(Console.ReadLine(), out numeroIngresado);
            while (!check)
            {
                Console.WriteLine("Ingrese un numero");
                check = int.TryParse(Console.ReadLine(), out numeroIngresado);
            }
            retorno = Multiplicador(numeroIngresado);

            Console.WriteLine(retorno);
        }


        static string Multiplicador (int numeroIngresado)
        {
            StringBuilder sb = new StringBuilder();
            int resultado;
            for(int i=1;i<10;i++)
            {
                resultado = numeroIngresado * i;
                sb.Insert(sb.Length, numeroIngresado.ToString()+" X "+i + " = " + resultado+ "\n");
            }


            return sb.ToString();
        }
    }
}
