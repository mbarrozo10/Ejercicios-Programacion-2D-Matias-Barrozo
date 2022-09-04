using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private int dni;
        private DateTime fechaDeNacimiento;

        public Persona(string nombre, int dni, DateTime fechaDeNacimiento)
        {
            this.Nombre = nombre;
            this.Dni = dni;
            this.FechaDeNacimiento = fechaDeNacimiento;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Dni {
            get { return dni; }
            set { dni = value; }
        }

        public DateTime FechaDeNacimiento
        {
            get { return fechaDeNacimiento; }
            set
            {
                fechaDeNacimiento = value;
            }
        }

        private int CalcularEdad()
        {
            DateTime d1 = DateTime.Now;
            int retorno = ((d1 - FechaDeNacimiento).Days) / 365;
            return retorno;
        }

        public string Mostrar()
        {
            string retorno;
            retorno = "Nombre: " + Nombre + "\nEdad: " + CalcularEdad() + "\nDni: " + Dni;
            return retorno;
        }

        public string EsMayorDeEdad()
        {
            string retorno;
            if(CalcularEdad() >= 18)
            {
                retorno = "\nEs mayor";
            }
            else
            {
                retorno = "\nEs menor";
            }

            return retorno;
        }
    }
}
