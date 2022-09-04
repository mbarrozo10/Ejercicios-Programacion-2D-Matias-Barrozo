using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class IngresoVariables
    {
        public static int PedirNumeroEntero(string mensaje)
        {
            string ingreso;
            int numeroIngresado = 0;
            bool validacionSalida = false;
            do
            {
                Console.WriteLine(mensaje);
                ingreso = Console.ReadLine();
                if (ValidarNumero(ingreso))
                {
                    numeroIngresado = int.Parse(ingreso);
                    validacionSalida = true;
                }
            } while (validacionSalida == false);

            return numeroIngresado;
        }

        public static int PedirNumeroEnteroEnRango(string mensaje, string mensajeError, int maximo, int minimo)
        {
            int numero;
            bool validacionSalida = false;
            do
            {
                numero = PedirNumeroEntero(mensaje);

                if (ValidarRango(numero, maximo, minimo))
                {
                    validacionSalida = true;
                }
                else
                {
                    Console.WriteLine("\n" + mensajeError + "\n");
                }

            } while (validacionSalida == false);
            return numero;
        }


        public static bool ValidarRango(float numero, int maximoPermitido, int minimoPermitido)
        {
            if (numero < minimoPermitido || numero > maximoPermitido)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static float PedirNumeroFlotante(string mensaje)
        {
            string ingreso;
            float numeroIngresado = 0;
            bool validacionSalida = false;

            do
            {
                Console.WriteLine(mensaje);
                ingreso = Console.ReadLine();
                if (ValidarNumero(ingreso))
                {
                    numeroIngresado = float.Parse(ingreso);
                    validacionSalida = true;
                }
            } while (validacionSalida == false);

            return numeroIngresado;

        }

        public static float PedirNumeroFlotanteEnRango(string mensaje, string mensajeError, int maximo, int minimo)
        {
            float numero;
            bool validacionSalida = false;
            do
            {
                numero = PedirNumeroFlotante(mensaje);
                if (ValidarRango(numero, maximo, minimo))
                {
                    validacionSalida = true;
                }
                else
                {
                    Console.WriteLine("\n" + mensajeError + "\n");
                }
            } while (validacionSalida == false);

            return numero;
        }

        private static bool ValidarNumero(string ingresoAValidar)
        {
            bool validacion;
            float numero;

            if (float.TryParse(ingresoAValidar, out numero))
            {
                validacion = true;
            }
            else
            {
                validacion = false;
            }

            return validacion;
        }

        public static string PedirIngresoString(string mensaje)
        {
            string ingresoUsuario;
            bool validacionLetra;

            do
            {
                Console.WriteLine(mensaje);
                ingresoUsuario = Console.ReadLine();

                validacionLetra = ValidarLetra(ingresoUsuario);

                if (validacionLetra == false)
                {
                    Console.WriteLine("\nError, ingreso incorrecto.");
                }
            } while (validacionLetra == false);

            return ingresoUsuario;
        }

        public static string PedirIngresoStringConNumeros(string mensaje)
        {
            string ingresoUsuario;
            bool validacionLetra;

            do
            {
                Console.WriteLine(mensaje);
                ingresoUsuario = Console.ReadLine();

                validacionLetra = ValidarNumeroYLetra(ingresoUsuario);

                if (validacionLetra == false)
                {
                    Console.WriteLine("\nError, ingreso incorrecto.");
                }
            } while (validacionLetra == false);

            return ingresoUsuario;
        }

        public static char PedirIngresoChar(string mensaje)
        {
            string ingresoUsuarioStr;
            char ingresoUsuario = ' ';
            bool isValidacionLetra = false;

            do
            {
                Console.WriteLine(mensaje);
                ingresoUsuarioStr = Console.ReadLine();
                ingresoUsuarioStr = ingresoUsuarioStr.ToUpper();

                if (ValidarLetra(ingresoUsuarioStr))
                {
                    char.TryParse(ingresoUsuarioStr, out ingresoUsuario);
                    isValidacionLetra = true;
                }
                else
                {
                    Console.WriteLine("\n Error, ingreso inválido, solo se admiten letras.");
                }
            } while (isValidacionLetra == false);


            return ingresoUsuario;
        }

        private static bool ValidarLetra(string cadena)
        {
            bool validacionLetra = true;

            for (int i = 0; i < cadena.Length; i++)
            {
                if (!char.IsLetter(cadena[i]))
                {
                    validacionLetra = false;
                    break;
                }
            }

            return validacionLetra;
        }

        private static bool ValidarNumeroYLetra(string cadena)
        {
            bool validacionLetra = true;

            for (int i = 0; i < cadena.Length; i++)
            {
                if (!char.IsLetter(cadena[i]) || !char.IsDigit(cadena[i]))
                {
                    validacionLetra = false;
                    break;
                }
            }
            return validacionLetra;
        }


    }
}
