using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractasDemo
{
    class Circulo : FiguraBase, IFigura, IRenderizador
    {
        int radio;

        public int Calcular(int x, int y)
        {
            throw new NotImplementedException();
        }

        public double CalcularArea()
        {
            throw new NotImplementedException();
        }
        void IRenderizador.Dibujar()
        {

        }
        void IFigura.Dibujar()
        {
            throw new NotImplementedException();
        }

        public void Renderizar()
        {
            throw new NotImplementedException();
        }

        internal override void ObtenerTop()
        {
            throw new NotImplementedException();
        }
    }
}
