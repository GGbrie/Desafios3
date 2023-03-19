using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajaDesafios
{
    public class VolumenCaja
    {
        public double AltoV { get; set; }
        public double AnchoV { get; set; }
        public double LargoV { get; set; }

        public double CalcularVolumen()
        {
            return AltoV * AnchoV * LargoV;
        }
    }
}