using System;
using Entidades;
namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumadorB = new Sumador(2);
            Sumador sumadorC = new Sumador(10);
            Console.WriteLine($"La suma de dos long es {sumador.Sumar(45,2)}");
            Console.WriteLine($"La suma de dos string es {sumador.Sumar("hola","mundo")}");
            //conversion explicita
            int cantidadSumas = (int)sumador;
            Console.WriteLine(cantidadSumas);
            //Sobrecarga de operador
            Console.WriteLine(sumador + sumadorB);
            Console.WriteLine(sumador | sumadorB);
            Console.WriteLine(sumador | sumadorC);
        }
    }   
}
