using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDemo1
{
    class Circulo
    {
        int radio;
        public static int numeroDeCirculos;
        public const double PI = 3.14;


        public Circulo(int radioInicial)
        {
            radio = radioInicial;
            numeroDeCirculos++;
        }

        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }
    }
}
