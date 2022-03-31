using System;

namespace VistaAplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero;
            double numeroBase;
            string numeroDos;
            double numeroAltura;
            Console.WriteLine("Ingrese la base del triangulo a calcular");
            numero=Console.ReadLine();
            double.TryParse(numero, out numeroBase);
            Console.WriteLine("Ingrese la altura del triangulo a calcular");
            numeroDos=Console.ReadLine();
            double.TryParse(numeroDos, out numeroAltura);

            Console.WriteLine("la longitud de la hipotenusa es " + Math.Sqrt(Math.Pow(numeroBase, 2) + Math.Pow(numeroAltura,2)));

        }
    }
}
