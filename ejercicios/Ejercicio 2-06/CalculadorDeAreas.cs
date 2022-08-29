using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_06
{
    public class CalculadorDeAreas
    {
        public static double CalcularAreaCuadrado(double longitudLado) {
            double retorno;
            retorno= longitudLado*longitudLado;
            return retorno;
        }

        public static double CalcularAreaTriangulo(double baseTriangulo, double altura) {
            double retorno;

            retorno = (baseTriangulo * altura) / 2;

            return retorno;
        }

        public static double CalcularAreaCirculo(double radio) {
            double retorno;
            
            retorno = radio * radio * Math.PI;

            return retorno;
        }

    }
}
