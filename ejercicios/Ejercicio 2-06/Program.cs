using System;

namespace Ejercicio_2_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seleccion;
            bool salir= false;
            double baseGenerica;
            double altura;
            double resultado;

            do
            {
                Console.WriteLine("Ingrese el tipo de figura a calcular: 1-cuadrado 2- triangulo 3-circulo-4 salir");
                seleccion = int.Parse(Console.ReadLine());
                switch (seleccion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el lado del cuadrado: ");
                        baseGenerica = double.Parse(Console.ReadLine());
                        resultado = CalculadorDeAreas.CalcularAreaCuadrado(baseGenerica);
                        Console.WriteLine("El area es: " + resultado);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el lado del triangulo: ");
                        baseGenerica = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el altura del triangulo: ");
                        altura = double.Parse(Console.ReadLine());
                        resultado = CalculadorDeAreas.CalcularAreaTriangulo(baseGenerica,altura);
                        Console.WriteLine("El area es: " + resultado);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el radio del circulo: ");
                        baseGenerica = double.Parse(Console.ReadLine());
                        resultado = CalculadorDeAreas.CalcularAreaCirculo(baseGenerica);
                        Console.WriteLine("El area es: " + resultado);
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        break;
                }
            } while (!salir);
        }
    }
}
