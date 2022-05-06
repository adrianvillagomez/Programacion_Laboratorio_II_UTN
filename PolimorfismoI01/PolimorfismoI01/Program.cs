using System;
using Entidades;
namespace PolimorfismoI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Sobre-Sobrescrito";
            SobreSobreescrito objetoSobrescrito = new SobreSobreescrito();
            SobreSobreescrito sobreescrito = new SobreSobreescrito();
            Console.WriteLine(objetoSobrescrito.ToString());
            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(sobreescrito));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());

            Console.WriteLine(objetoSobrescrito.MiMetodo());
        }
    }
}
