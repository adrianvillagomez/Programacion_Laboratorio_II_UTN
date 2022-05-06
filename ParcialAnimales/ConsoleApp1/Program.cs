using System;
using ParcialAnimales;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro("pepito", "caniche",20,true);
            Console.WriteLine(perro.ToString());
        }
    }
}
