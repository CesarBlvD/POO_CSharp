using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDemo1
{
    class Rectangulo
    {
        double baseRectangulo;
        double alturaRectangulo;
        string color;

        public Rectangulo()
        {
            baseRectangulo = 15;
            alturaRectangulo = 3;
            color = "Negro";
        }
        public Rectangulo(double baseRectanguloInicial, double alturaRectanguloInicial)
        {
            baseRectangulo = baseRectanguloInicial;
            alturaRectangulo = alturaRectanguloInicial;
        }

        public double CalcularArea()
        {
            //BasexAltura
            return (alturaRectangulo * baseRectangulo);
        }
        public double CalcularPerimetro()
        {
            //2Altura + 2Base
            return ((2 * alturaRectangulo) + (2 * baseRectangulo));
        }

        public static double CalcularPerimetroRectangulo(double alturaRectangulo, double baseRectangulo)
        {
            return ((2 * alturaRectangulo) + (2 * baseRectangulo));
        }

        

        public void Deconstruct(out double baseRect, out double alturaRect)
        {
            baseRect = baseRectangulo;
            alturaRect = alturaRectangulo;
        }
    }
}
