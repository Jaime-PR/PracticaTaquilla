using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTaquilla
{
    public class BoletoGeneral : Boleto
    {
        public BoletoGeneral()
        {
        }

        public override double CalcularPrecioFinal()
        {
            return PrecioBase;
        }
    }
}
