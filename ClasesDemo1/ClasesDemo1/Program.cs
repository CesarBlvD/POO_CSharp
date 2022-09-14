using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClasesDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo(23, 50);

            double resultadoArea = rectangulo.CalcularArea();
            double resultadoPerimetro = rectangulo.CalcularPerimetro();

            double resultadoPerimetro2 = Rectangulo.CalcularPerimetroRectangulo(24, 24);

            (var baseRect, var alturaRect) = rectangulo;

            Circulo circulo1 = new Circulo(20);
            Circulo circulo2 = new Circulo(50);
            Circulo circulo3 = new Circulo(10);

            WriteLine(Circulo.numeroDeCirculos);
            WriteLine(baseRect);
            WriteLine(alturaRect);

            //objeto anonimo
            var objetoAnonimo = new { area = 3, campo2 = 5 };
            _=objetoAnonimo.campo2;

            ReadLine();
        }
    }
}
