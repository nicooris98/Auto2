using System;

namespace auto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.CargarNafta(500);
            auto.Arrancar();
        }
    }
}
