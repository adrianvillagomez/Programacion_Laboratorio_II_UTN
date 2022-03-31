using System;

namespace Ejercicio102ErrorAlCubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool respuesta = false;
            do
            {
                int primerNumero;
                double resultadoCuadrado;
                double resultadoCubo;
                Console.WriteLine("Ingrese un numero");
                string numeroUno = Console.ReadLine();
                int.TryParse(numeroUno, out primerNumero);
                if (primerNumero > 0)
                {
                  resultadoCuadrado = Math.Pow(primerNumero, 2);
                  resultadoCubo = Math.Pow(primerNumero, 3);
                  Console.WriteLine("El cuadrado del numero ingresado es {0},y el cubo {1}",resultadoCuadrado,resultadoCubo);
                  respuesta = true;
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            } while (respuesta==false);
        }
    }
}
