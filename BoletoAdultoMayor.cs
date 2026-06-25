using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTaquilla
{
    public class BoletoAdultoMayor : Boleto
    {
        public string NumCredencialInapam { get; set; }

        public BoletoAdultoMayor(string numCredencialInapam)
        {
            NumCredencialInapam = numCredencialInapam;
        }

        public override double CalcularPrecioFinal()
        {
            return PrecioBase * 0.50;
        }
    }
}
