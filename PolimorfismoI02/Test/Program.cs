using System;
using PolimorfismoI02;
using System.Collections.Generic;
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura>listaFigura=new List<Figura>();
            Rectangulo rectangulo1=new Rectangulo(5,5);
            Circulo circulo1 = new Circulo(2);
            Cuadrado cuadrado1 = new Cuadrado(2,2);
            listaFigura.Add(rectangulo1);
            listaFigura.Add(circulo1);
            listaFigura.Add(cuadrado1);
            foreach(Figura c in listaFigura)
            {              
               if (c is Cuadrado)
                {
                    Console.WriteLine(c.Dibujar());
                }else if (c is Circulo)
                {
                    Console.WriteLine(c.Dibujar());
                }else
                {
                    //Console.WriteLine(c.Dibujar());
                }
                
               
            }
        }
    }
}
