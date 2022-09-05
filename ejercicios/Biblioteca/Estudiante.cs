using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string nombre;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string nombre, string legajo, int notaPrimerParcial, int notaSegundoParcial)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Legajo = legajo;
            SetNotaPrimerParcial(notaPrimerParcial);
            SetNotaSegundoParcial(notaSegundoParcial);
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }   
        }

        public string Nombre { 
            get { return nombre; }
            set { nombre = value; }
        }

        public string Legajo { 
           get { return legajo; }
            set
            {
                legajo = value;
            } 
        }
        public int NotaPrimerParcial { get
            {
                return notaPrimerParcial;
            }
             }
        public int NotaSegundoParcial { get
            {
                return notaSegundoParcial;
            }
           
        }

        public void SetNotaPrimerParcial (int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            return (NotaPrimerParcial + NotaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            double retorno=-1;
            if((NotaPrimerParcial >=4 && NotaSegundoParcial >= 4) && (NotaPrimerParcial < 6 && NotaSegundoParcial < 6))
            {
                retorno =(double) random.Next(6, 10);
            }

            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre: " + Nombre + "\nApellido: " + Apellido + "\nLegajo: " + Legajo + "\nPrimer parcial: " + NotaPrimerParcial
                + "\nSegundo parcial: " + NotaSegundoParcial + "\nPromedio: " + CalcularPromedio());
            if (CalcularNotaFinal() != -1)
            {
                sb.Insert(sb.Length,"\nNota de final: " + CalcularNotaFinal());
            }

            return sb.ToString();
        }


    }
}
