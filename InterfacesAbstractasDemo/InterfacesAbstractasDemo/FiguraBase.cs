using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractasDemo
{
    abstract class FiguraBase
    {
        protected string colorFigura;
        public void ObtenerUbicacion()
        {
            Console.WriteLine("X,Y");
        }
        internal abstract void ObtenerTop();
    }
}
