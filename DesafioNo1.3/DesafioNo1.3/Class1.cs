using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafios
{
    public class AlturasRectangulos
    {
        private double altorectangulo;
        private double largorectangulo;

        public AlturasRectangulos(double alto, double largo)
        {
            altorectangulo = alto;
            largorectangulo = largo;
        }

        public double Alto
        {
            get { return altorectangulo; }
            set { altorectangulo = value; }
        }

        public double Largo
        {
            get { return largorectangulo; }
            set { largorectangulo = value; }
        }

        public double SuperficieFrontal
        {
            get { return altorectangulo * largorectangulo; }
        }
    }
}