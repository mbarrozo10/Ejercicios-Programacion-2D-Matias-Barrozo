using System;
using Biblioteca;

namespace Ejercicio_3_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int interaccion;
            int montoTemporal;
            char salida;
            Cuenta cuenta1 = new Cuenta("Empresa1", 200000);
            Cuenta cuenta2 = new Cuenta("Empresa2", 300000);
            Cuenta cuenta3 = new Cuenta("Empresa3", 400000);

            Cuenta[] cuentas = { cuenta1, cuenta2, cuenta3 };

            
            do
            {
                Console.WriteLine("Ingrese el numero de cuenta con el que quiere interaccioanr: 1-empresa1, 2-empresa2, 3-empresa3");
                opcion = IngresoVariables.PedirNumeroEnteroEnRango("Su opcion", "Error, ingrese nuevamente.", 4, 0);
                interaccion = IngresoVariables.PedirNumeroEnteroEnRango("1-Mostrar estado de la cuenta\n2-Ingresar efectivo\n3-Retirar cash", "Error ingrese nuevamente", 4, 0);
                switch (interaccion)
                {
                    case 1:
                        Console.WriteLine( cuentas[opcion - 1].Mostrar());
                        break;
                    case 2:
                        montoTemporal = IngresoVariables.PedirNumeroEnteroEnRango("Ingrese la cantidad a depositar: ", "Error", int.MaxValue, 0);
                        cuentas[opcion - 1].Ingresar(montoTemporal);
                        break;
                    case 3:
                        montoTemporal = IngresoVariables.PedirNumeroEnteroEnRango("Ingrese la cantidad a retirar: ", "Error", int.MaxValue, 0);
                        cuentas[opcion - 1].Retirar(montoTemporal);
                        break;
                }

                salida = IngresoVariables.PedirIngresoChar("Quiere salir? Si-S/No-Cualquier otro caracter");

            }while(salida!='S');
            
        }
    }
}
