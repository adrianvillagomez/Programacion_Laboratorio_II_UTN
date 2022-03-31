using System;
using Entidades;
namespace Semana2Sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Tiempo tiempo = new Tiempo(21, 20, 20);
            Tiempo tiempo1 = tiempo;
            Tiempo tiempo4 = new Tiempo(21, 20, 20);
            Tiempo tiempo2 = new Tiempo(25, 30);
            Tiempo tiempo3 = new Tiempo(21);
            Console.WriteLine(tiempo.Mostrar());
            Console.WriteLine(tiempo2.Mostrar());
            Console.WriteLine(tiempo3.Mostrar());
            
            //sobrecarga de operadores
            Console.WriteLine(tiempo==tiempo1);
            Console.WriteLine(tiempo==tiempo4);
            //compara 2 obejctos por la posicion de memoria
            Console.WriteLine(Object.ReferenceEquals(tiempo,tiempo1));
            Console.WriteLine(Object.ReferenceEquals(tiempo,tiempo4));

            //ejemplo casteo
            int entero;
            float flotante = 5.5f;
            //conversion Explicita- se nesecita poner (int)porque puede haber perdida de informacion.
            entero = (int)flotante;
            //conversion Implicita - Dato chico a un operador mas grande no se especifica nada.
            int numero = 0;
            float flotante2 = numero;

            //Conversion implicita
            int segundo = tiempo;
            Console.WriteLine(tiempo.Mostrar());
            Console.WriteLine(segundo);
            //Conversion Explicita
            Tiempo t =(Tiempo)"21:35:55";
            Console.WriteLine(t.Mostrar());

        }   
    }
}
