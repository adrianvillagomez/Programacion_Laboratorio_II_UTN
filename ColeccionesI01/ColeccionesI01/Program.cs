using System;

namespace ColeccionesI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[5];
            Random random = new Random();
            random.Next();
            for(int i = 0; i < arrayNumeros.Length; i++)
            {
                arrayNumeros[i] = random.Next(-100,100);
            }
            //Mostrar el vector tal como fue ingresado.
            Console.WriteLine("Mostrar el vector tal como fue ingresado.");
            foreach (int i in arrayNumeros)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Mostrar los positivos ordenados en forma decreciente.");
            Array.Sort(arrayNumeros,OrdenDescendente);
            foreach (int i in arrayNumeros)
            {
                if(i>0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Mostrar los negativos ordenados en forma creciente.");
            Array.Sort(arrayNumeros);
            foreach (int i in arrayNumeros)
            {
                if(i<0)
                {
                    Console.WriteLine(i);
                }
            }            
        }
        public static int OrdenDescendente(int n1, int n2)
        {
            return n2 - n1;
        }
    }
}
