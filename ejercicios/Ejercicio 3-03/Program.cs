using System;
using Biblioteca;

namespace Ejercicio_3_03
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            string legajo;
            int primerNota;
            int segundaNota;

            Estudiante[] alumnos = new Estudiante[3];
            for (int i = 0; i < alumnos.Length; i++)
            {

                nombre = IngresoVariables.PedirIngresoString("Ingrese el nombre");
                apellido = IngresoVariables.PedirIngresoString("Ingrese el apellido");
                legajo = IngresoVariables.PedirIngresoStringConNumeros("Ingrese el Legajo");
                primerNota = IngresoVariables.PedirNumeroEnteroEnRango("Ingrese la nota del primer parcial", "Error", 10, 0);
                segundaNota = IngresoVariables.PedirNumeroEnteroEnRango("Ingrese la nota del segundo parcial", "Error", 10, 0);
                alumnos[i] = new Estudiante(apellido, nombre, legajo, primerNota, segundaNota);
            }
            foreach(Estudiante arg in alumnos)
            {
               Console.WriteLine( arg.Mostrar());
            }

           
        }
    }
}
