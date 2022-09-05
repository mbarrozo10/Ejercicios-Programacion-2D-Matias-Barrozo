using System;
using Biblioteca;

namespace Ejercicio_3_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dibujo;
            Boligrafo[] boligrafo = new Boligrafo[2];
            boligrafo[0] = new Boligrafo(ConsoleColor.Red, 50);
            boligrafo[1] = new Boligrafo(ConsoleColor.Blue, 100);


            if(boligrafo[0].Pintar(51, out dibujo))
            {
                Console.ForegroundColor = boligrafo[0].GetColor();
                Console.WriteLine(dibujo);
            }
            else
            {
                Console.WriteLine("No hay tinta roja owo");
            }

            if (boligrafo[1].Pintar(2, out dibujo))
            {
                Console.ForegroundColor = boligrafo[1].GetColor();
                Console.WriteLine(dibujo);
            }
            else
            {
                Console.WriteLine("No hay tinta azul owo");
            }

        }
    }
}
