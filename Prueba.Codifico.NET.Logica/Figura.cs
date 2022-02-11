using System.Windows;

namespace Prueba.Codifico.NET.Logica
{
    public abstract class Figura
    {

        public Point P1 { get; set; }

        public Point P2 { get; set; }

        public virtual double GetArea()
        {
            return 0;
        }

    }
}
