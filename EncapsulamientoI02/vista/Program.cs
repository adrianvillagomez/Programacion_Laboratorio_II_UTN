using System;
using Libro;
namespace vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Librito libro = new Librito();
            libro[0] = "El pregrino";
            libro[1] = "El quijote";           
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }
            libro[1] = "Tyrion III";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }
        }
    }
}
