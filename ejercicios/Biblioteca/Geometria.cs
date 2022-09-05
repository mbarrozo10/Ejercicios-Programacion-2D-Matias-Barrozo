using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X {
            get { return this.x; }
        }

        public int Y
        {
            get { return this.y; }  
        }
    }

    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public float Area
        {
            get { return this.area; }
        }

        public float Perimetro
        {
            get { return this.perimetro; }
        }

    }
}
