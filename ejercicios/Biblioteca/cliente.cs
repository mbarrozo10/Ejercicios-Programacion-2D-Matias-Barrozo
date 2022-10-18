using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_bd
{
    public class cliente
    {

        private string nombre;
        private int id;

        public cliente(string nombre, int id)
        {
            this.Nombre = nombre;
            this.Id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
