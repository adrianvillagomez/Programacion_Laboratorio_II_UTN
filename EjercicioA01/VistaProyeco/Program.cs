using System;

namespace VistaProyeco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero;
            int numeroFactorial;
            int resultado=1;
            Console.WriteLine("Ingrese un numero");
            numero = Console.ReadLine();
            int.TryParse(numero, out numeroFactorial);
            for(int i = 2; i <= numeroFactorial; i++)
            {
                resultado = resultado * i;
            }
            Console.WriteLine("El factorial de {0} es {1}",numeroFactorial, resultado);
        }
    }
}
