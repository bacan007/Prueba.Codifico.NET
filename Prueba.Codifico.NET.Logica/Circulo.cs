using System;


namespace Prueba.Codifico.NET.Logica
{
    public class Circulo : Figura
    {

        private double radio;

        public override double GetArea()
        {
            radio = GetRadio();

            return Math.PI * Math.Pow(radio, 2);
        }

        private double GetRadio()
        {
            return Math.Abs(this.P2.X - this.P1.X) / 2;
        }

    }
}
