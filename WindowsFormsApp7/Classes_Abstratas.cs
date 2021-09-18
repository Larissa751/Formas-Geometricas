using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public abstract class Classes_Abstratas
    {
       
            private double _area;
            private string _cor;
            private double _perimetro;

            public string Cor
            {
                get
                {
                    return _cor;
                }
                set
                {
                    _cor = value;
                }
            }

            public double Area
            {
                get
                { return _area; }
                set
                { _area = value; }

            }

            public double Perimetro
            {
                get
                { return _perimetro; }
                set
                { _perimetro = value; }
            }

            public abstract double CalcularArea();
            public abstract double CalcularPerimetro();
           
        }
    }

    
