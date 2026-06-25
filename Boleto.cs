using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTaquilla
{
    public abstract class Boleto
    {
        public double precioBase;

        protected double PrecioBase
        {
            get { return precioBase; }
            set { precioBase = value; }
        }

        public Boleto()
        {
            this.PrecioBase = 80.00;
        }

        public abstract double CalcularPrecioFinal();
    }
}
