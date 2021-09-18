using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Circulo: Classes_Abstratas
    {
        private double raio;
        public double Raio
        {
            get
            { return raio; }
            set
            { raio = value; }
        }

        public override double CalcularArea()
        {
            double PI = Math.PI;
            this.Area = PI * raio * raio;
            return Area;
        }

        public override double CalcularPerimetro()
        {
            double PI = Math.PI;
            this.Area = 2 * PI * raio;
            return Perimetro;
        }
    }
}
