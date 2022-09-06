using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Biblioteca;

namespace MaquinaExpendedora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // solo dictionary
            /* int eleccion;
             Dictionary<int, Producto> maquina = new Dictionary<int, Producto>() ;
             char salir;
             maquina.Add(1, new Producto("Coca", 150));
             maquina.Add(2, new Producto("Pepsi", 170));
             maquina.Add(3, new Producto("Manaos", 120));
             maquina.Add(4, new Producto("Sprite", 170));
             maquina.Add(5, new Producto("Vinito", 140));
             maquina.Add(6, new Producto("Agua", 101));
             maquina.Add(7, new Producto("7UP", 110));
             maquina.Add(8, new Producto("Coca1", 160));
             maquina.Add(9, new Producto("Coca2", 140));
             maquina.Add(10, new Producto("Coca3", 130));


             do
             {
                 foreach (KeyValuePair<int, Producto> i in maquina)
                 {
                     Console.WriteLine(i.Key+ " " + i.Value.Nombre + " "+ i.Value.Precio);
                 }
                 eleccion = IngresoVariables.PedirNumeroEnteroEnRango("Su opcion", "Error", 10, 0);
                 Console.WriteLine(maquina[eleccion].Nombre);
                 maquina.Remove(eleccion);

                 salir = IngresoVariables.PedirIngresoChar("Quiere salir? S/N");
             } while (salir != 'S'); int eleccion;*/


            // dictinary + stack
            /*
            int eleccion;
            Dictionary<int, Stack<Producto>> maquina = new Dictionary<int, Stack<Producto>>();
            char salir;

            Stack<Producto> coca = new Stack<Producto>();
            coca.Push(new Producto("Coca", 150));
            coca.Push(new Producto("Coca", 150));
            coca.Push(new Producto("Coca", 150));
            coca.Push(new Producto("Coca", 150)); 
            Stack<Producto> papas = new Stack<Producto>();
            papas.Push(new Producto("papas", 150));
            papas.Push(new Producto("papas", 150));
            papas.Push(new Producto("papas", 150));
            papas.Push(new Producto("papas", 150)); 
            Stack<Producto> agua = new Stack<Producto>();
            agua.Push(new Producto("agua", 150));
            agua.Push(new Producto("agua", 150));
            agua.Push(new Producto("agua", 150));
            agua.Push(new Producto("agua", 150));

            maquina.Add(1, coca);
            maquina.Add(2, papas);
            maquina.Add(3, agua);
 

            do
            {
                foreach (KeyValuePair<int, Stack<Producto>> i in maquina)
                {
                 
                        Console.WriteLine(i.Key + " " + i.Value.Peek().Nombre + " " + i.Value.Peek().Precio + " " + i.Value.Count);
                    
                }
                eleccion = IngresoVariables.PedirNumeroEnteroEnRango("Su opcion", "Error", 10, 0);
                Console.WriteLine(maquina[eleccion].Pop().Nombre);
                if (maquina[eleccion].Count == 0)
                {
                    maquina.Remove(eleccion);
                }

                salir = IngresoVariables.PedirIngresoChar("Quiere salir? S/N");
            } while (salir != 'S');
            
            */
            // stack+cola+dictionary

            int eleccion;
            Dictionary<int, Stack<Producto>> maquina = new Dictionary<int, Stack<Producto>>();
            Queue<String> Cola = new Queue<String>();  
            char salir= ' ';

            Stack<Producto> coca = new Stack<Producto>();
            coca.Push(new Producto("Coca", 150));
            coca.Push(new Producto("Coca", 150));
            coca.Push(new Producto("Coca", 150));
            coca.Push(new Producto("Coca", 150));
            Stack<Producto> papas = new Stack<Producto>();
            papas.Push(new Producto("papas", 150));
            papas.Push(new Producto("papas", 150));
            papas.Push(new Producto("papas", 150));
            papas.Push(new Producto("papas", 150));
            Stack<Producto> agua = new Stack<Producto>();
            agua.Push(new Producto("agua", 150));
            agua.Push(new Producto("agua", 150));
            agua.Push(new Producto("agua", 150));
            agua.Push(new Producto("agua", 150));

            maquina.Add(1, coca);
            maquina.Add(2, papas);
            maquina.Add(3, agua);


            do
            {
                if (Cola.Count == 0)
                {
                    for (int i=0; i<5; i++)
                    {
                        Cola.Enqueue(IngresoVariables.PedirIngresoString("Ingrese el nombre"));
                    }
                }
                foreach (KeyValuePair<int, Stack<Producto>> i in maquina)
                {

                    Console.WriteLine(i.Key + " " + i.Value.Peek().Nombre + " " + i.Value.Peek().Precio + " " + i.Value.Count);

                }

                Console.WriteLine(Cola.Peek());
                eleccion = IngresoVariables.PedirNumeroEnteroEnRango("Su opcion", "Error", 10, 0);
                Console.WriteLine(maquina[eleccion].Pop().Nombre);
                if (maquina[eleccion].Count == 0)
                {
                    maquina.Remove(eleccion);
                }
                Cola.Dequeue();
                if (Cola.Count == 0)
                {
                salir = IngresoVariables.PedirIngresoChar("Quiere salir? S/N");
                }
            } while (salir != 'S');

        }


    }

    public class Producto
    {
        private string nombre;
        private int precio;

        public Producto(string nombre, int precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
        }

        public string Nombre { get { return nombre; } set { this.nombre = value; } }
        public int Precio { get { return precio; } set { this.precio = value; } }
    }
}
