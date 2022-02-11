using Prueba.Codifico.NET.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Codifico.NET.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            bool continuar = false;
            double area = 0.0;
            string figura = null;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Menú");
                Console.WriteLine("1. Calcular area del circulo");
                Console.WriteLine("2. Calcular area del rectángulo");
                Console.WriteLine("Digite la opción");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Circulo circulo = new Circulo();

                        Console.WriteLine("Digite los valores del Punto 1 (Y por defecto es 0)");
                        Console.WriteLine("Digite X");
                        string x1c = Console.ReadLine();

                        Console.WriteLine("Digite los valores del Punto 2 (Y por defecto es 0)");
                        Console.WriteLine("Digite X");
                        string x2c = Console.ReadLine();

                        circulo.P1 = new System.Windows.Point(Convert.ToDouble(x1c), 0.0);
                        circulo.P2 = new System.Windows.Point(Convert.ToDouble(x2c), 0.0);

                        area = circulo.GetArea();
                        figura = "Circulo";
                        break;
                    case "2":
                        Rectangulo rectangulo = new Rectangulo();

                        Console.WriteLine("Digite los valores del Punto 1");
                        Console.WriteLine("Digite X");
                        string x1r = Console.ReadLine();
                        Console.WriteLine("Digite Y");
                        string y1r = Console.ReadLine();

                        Console.WriteLine("Digite los valores del Punto 2 (Y asume el valor anterio)");
                        Console.WriteLine("Digite X");
                        string x2r = Console.ReadLine();

                        rectangulo.P1 = new System.Windows.Point(Convert.ToDouble(x1r), Convert.ToDouble(y1r));
                        rectangulo.P2 = new System.Windows.Point(Convert.ToDouble(x2r), Convert.ToDouble(y1r));

                        area = rectangulo.GetArea();
                        figura = "Rectángulo";
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(string.Format("El area del {0} es: {1:n2}", figura, area));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Si desea continuar digite S, de lo contrario digite cualquier tecla");

                string tecla = Console.ReadLine();

                continuar = (tecla.ToUpper() == "S");

            } while (continuar);

        }
    }
}
