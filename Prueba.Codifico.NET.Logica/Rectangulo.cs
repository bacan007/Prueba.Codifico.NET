
using System;

namespace Prueba.Codifico.NET.Logica
{
    public class Rectangulo : Figura
    {

        public override double GetArea()
        {
            return Math.Abs((this.P2.X - this.P1.X)) * this.P1.Y;
        }

    }
}
