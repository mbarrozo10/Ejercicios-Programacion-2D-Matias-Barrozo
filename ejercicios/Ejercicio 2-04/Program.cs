using System;

namespace Ejercicio_2_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = true;
            bool check;
            int numeroUno;
            int numeroDos;
            string operacion;
            float resultado;
            while (salir == true)
            {
                Console.WriteLine("Ingrese el primer numero: ");
                check = int.TryParse(Console.ReadLine(), out numeroUno);
                while(check == false)
                {
                    Console.WriteLine("Ingrese el primer numero: ");
                    check = int.TryParse(Console.ReadLine(), out numeroUno);
                }

                Console.WriteLine("Ingrese la operacion: (+,*,-,/)");
                operacion=Console.ReadLine();

                Console.WriteLine("Ingrese el segundo numero: ");
                check = int.TryParse(Console.ReadLine(), out numeroDos);
                while (check == false)
                {
                    Console.WriteLine("Ingrese el segundo numero: ");
                    check = int.TryParse(Console.ReadLine(), out numeroDos);
                }

                resultado= Calculadora.Calcular(numeroUno, numeroDos, operacion);
                Console.WriteLine("El resultado es: " + resultado);
                salir =  Calculadora.ValidarRespuesta();
            }
            Console.WriteLine();
        }
    }
}
