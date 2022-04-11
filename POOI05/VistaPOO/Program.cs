using System;
using Geometria;
namespace VistaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo(new Punto(5, 2), new Punto(8, 4));

            Console.WriteLine($"Area del rectangulo : {rectangulo.area}");
            Console.WriteLine($"Perimetro del rectangulo : {rectangulo.perimetro}");
        }
    }
}
