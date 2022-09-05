using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tinta)
        {
            if (tinta < 0)
            {
                if(GetTinta() != cantidadTintaMaxima && GetTinta()+tinta != cantidadTintaMaxima)
                {
                    this.tinta += tinta;
                }
            }
            else if(GetTinta()>0 && GetTinta()-tinta>0)
            {
                this.tinta -= tinta;
            }
            else
            {
                Console.WriteLine("No hay tinta");
            }
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar (short gasto, out string dibujo)
        {
            bool retorno=true;
            dibujo = "";
            if (GetTinta() == 0 || GetTinta()-gasto<=0)
            {
                return false;
            }
            else
            {
                SetTinta(gasto);
                for (int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }
            }
            return retorno;
        }
    }
}
