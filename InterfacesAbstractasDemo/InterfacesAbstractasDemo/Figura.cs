namespace InterfacesAbstractasDemo
{
    interface IFigura : ICalculador
    {
        int Calcular(int x, int y);
        void Dibujar();
    }
}
