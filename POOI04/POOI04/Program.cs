using System;
using Entidades;
namespace POOI04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dibujo;
            Boligrafo boligrafo = new Boligrafo(100, ConsoleColor.White);
            //Boligrafo boligrafoDos = new Boligrafo(50, ConsoleColor.Red);
            Console.WriteLine($"Boligrafo Color: {boligrafo.GetColor()} || NivelTinta: {boligrafo.GetTinta()} ");        
            //Console.WriteLine($"BoligrafoDos Color: {boligrafoDos.GetColor()} || NivelTinta: {boligrafoDos.GetTinta()}");
            if( boligrafo.Pintar(20,out dibujo))
            {
                Console.WriteLine(dibujo);
                Console.WriteLine($"Nivel de tinta : {boligrafo.GetTinta()}");
            }
            else
            {
                Console.WriteLine("Sin tinta");
                Console.WriteLine($"Nivel de tinta : {boligrafo.GetTinta()}");
            }  
        }
    }
}
