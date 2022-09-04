using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cuenta
    {
        private string razonSocial;
        private int dinero;

        public Cuenta(string razonSocial, int dinero)
        {
            this.RazonSocial = razonSocial;
            this.Dinero = dinero;
        }

        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }
        
        public int Dinero { 
        get { return dinero; }
        set { dinero = value; }
        }

        public string Mostrar()
        {
            string retorno;
            
            retorno="Razon social: "+ RazonSocial + "\nDinero: "+ Dinero;
            return retorno;
        }

        public void Ingresar (int monto)
        {
            if (monto > 0)
            {
                Dinero += monto;
            }
        }

        public void Retirar (int dineroARetirar)
        {
            Dinero-= dineroARetirar;
        }

    }
}
