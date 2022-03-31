using System;
using LogicaNegocio;
namespace VistaAplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area de un cuadrado de lado 5 es "+CalculadoraDeArea.CalcularAreaCuadrado(5));
            Console.WriteLine("Area de un triangulo de base 5 y altura 4 es " + CalculadoraDeArea.CalcularAreaTriangulo(5, 4));
            Console.WriteLine("Area de im circulo de radio 7 es "+CalculadoraDeArea.CalcularAreaCirculo(7));
        }
    }
}
