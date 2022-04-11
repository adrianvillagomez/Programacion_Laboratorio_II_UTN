using System;
using System.Collections.Generic;
namespace ColeccionesI02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numeros = new Random();
            List<int>listaNumeros = new List<int>();
            Console.WriteLine("Coleccion Original de Lista");
            for(int i = 0; i < 20; i++)
            {
                listaNumeros.Add(numeros.Next(-100,100));
            }
            foreach(int numero in listaNumeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine($"Numero de elementos : {listaNumeros.Count}");
            Console.WriteLine("Numeros de Lista Positivos Ordenados Ascendentes");
            listaNumeros.Sort();
            foreach (int numero in listaNumeros)
            {
                if(numero > 0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.WriteLine("Numeros de Lista Positivos Ordenados Descendentes");
            listaNumeros.Sort(OrdenDescendente);
            foreach (int numero in listaNumeros)
            {
                if (numero > 0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.WriteLine("Numeros de Lista Negativos Ordenados Ascendentes");
            listaNumeros.Sort();
            foreach (int numero in listaNumeros)
            {
                if (numero < 0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.WriteLine("Numeros de Lista Negativos Ordenados Descendentes");
            listaNumeros.Sort(OrdenDescendente);
            foreach (int numero in listaNumeros)
            {
                if (numero < 0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Coleccion de Pila Original");
            Stack<int> stack = new Stack<int>();
            for(int i = 0; i < 20; i++)
            {
                stack.Push(numeros.Next(-100,100));
            }
            foreach(int numero in listaNumeros)
            {
                Console.WriteLine(numero);  
            }
            Console.WriteLine("Coleccion de Pila Positivos Ordenados");
            Array.Sort(stack.ToArray());
            foreach (int numero in listaNumeros)
            {
                if(numero>0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.WriteLine("Coleccion de Pila Negativos Ordenados");
            Array.Sort(stack.ToArray());
            foreach (int numero in listaNumeros)
            {
                if (numero < 0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Coleccion de Cola Original");
            Queue<int> colaNumeros = new Queue<int>();
            for(int i = 0; i < 20; i++)
            {
                colaNumeros.Enqueue(numeros.Next(-100,100));
            }
            foreach(int numero in colaNumeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("Coleccion de Cola Positivos Ordenados");
            Array.Sort(colaNumeros.ToArray());           
            foreach (int numero in colaNumeros)
            {
                if(numero > 0)
                {
                    Console.WriteLine(numero);
                }               
            }
            Console.WriteLine("Coleccion de Cola Negativos Ordenados");
            Array.Sort(colaNumeros.ToArray());
            foreach (int numero in colaNumeros)
            {
                if (numero < 0)
                {
                    Console.WriteLine(numero);
                }
            }           
        }
        public static int OrdenDescendente(int n1, int n2)
        {
            return n2 - n1;
        }
    }
}
