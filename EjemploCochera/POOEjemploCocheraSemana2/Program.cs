using System;
using Entidades;
namespace POOEjemploCocheraSemana2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto("00001", "Ford","Falcon");
            Auto a2 = new Auto("00002", "Fiat","Duna");
            a1.SetCantidadHora(5);
            a2.SetCantidadHora(2);
            Console.WriteLine($"El precio de la hora es {Auto.GetPrecioHora()}");

            Console.WriteLine($"El importe a pagar de a1 es {a1.CalcularCostoEstadia()}");
            Console.WriteLine($"El importe a pagar de a2 es {a2.CalcularCostoEstadia()}");

            int[]numeros=new int[5];
        }
    }
}
