using System;
using Biblioteca;

namespace Ejercicio_3_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Matias",41236275,new DateTime(1998,11,10));
            Persona persona2 = new Persona("Morena", 12345678, new DateTime(2001, 6, 15));
            Persona persona3 = new Persona("Lupin", 123564789, new DateTime(2022, 1, 15));

            Persona [] gente = {persona, persona2, persona3};

            foreach (Persona gente2 in gente)
            {
                Console.WriteLine(gente2.Mostrar() + gente2.EsMayorDeEdad());
            }
        }
    }
}
