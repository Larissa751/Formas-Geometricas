using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class clsCalculo
         
    {
        public float media(float valorA, float valorB)
        {
            float valorMedia = (valorA + valorB) / 2;
            return valorMedia;
        }
        public float media (float valorA, float valorB, float valorC)
        {
            float valorMedia = (valorA + valorB + valorC) / 3;
                return valorMedia;
        }
        public string media(float valorA, float valorB, float valorC, string Pessoa)
        {
            string TextoMedia = Pessoa + "a média é";
            float valorMedia = (valorA + valorB + valorC) / 3;
                TextoMedia = TextoMedia + valorMedia.ToString();
            return TextoMedia;
        }
    }
}
