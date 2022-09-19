using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractasDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circulo c = new Circulo();
            //IFigura f1 = c;
            //IRenderizador r = c;
            //Linea l = new Linea();

            //IFigura f = c;
            //f = l;

            //f.Dibujar();
            //f1.Dibujar();
            //r.Dibujar();
            //l.Dibujar();

            FiguraBase fbase = new Circulo();
            fbase.ObtenerUbicacion();
        }

        static void CalcularArea(IFigura figura)
        {
            if(figura is Circulo)
            {
                figura.Dibujar();
            }
            else if(figura is Linea)
            {
                figura.Dibujar();
            }
        }
    }
}
