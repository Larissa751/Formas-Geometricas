using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Quadrado: Classes_Abstratas
    {
        private double lado;
        public double Lado
        {
            get
            { return lado; }
            set
            { lado = value; }
        }

        public override double CalcularArea()
        {
            this.Area = lado * lado;
            return Area;
        }

        public override double CalcularPerimetro()
        {
            this.Perimetro = 4 * lado;
            return Perimetro;
        }
    }
}
