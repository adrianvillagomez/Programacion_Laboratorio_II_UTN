using System;
using LogicaDeNegocio;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroLeido;
            bool flagMax = true;
            bool flagMin = true;
            int maximo=0;
            int minimo=0;
            float acumulador=0;
            float promedio = 0;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero");
                string numeroIngresado = Console.ReadLine();           
                if (int.TryParse(numeroIngresado, out numeroLeido) && Validador.Validar(numeroLeido,-100,100))
                {
                    if (flagMax == true || numeroLeido> maximo)
                    {
                        maximo = numeroLeido;
                        flagMax = false;
                    }

                    if (flagMin == true || numeroLeido < minimo)
                    {
                        minimo = numeroLeido;
                        flagMin = false;
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
                acumulador+=numeroLeido;
            }
            promedio=acumulador/10;
            Console.WriteLine("El numero mayor de los numeros Ingresados es {0}", maximo);
            Console.WriteLine("El numero Menor de los numeros Ingresados es {0}", minimo);
            Console.WriteLine("El promedio de los numeros Ingresados es {0}",promedio);           
        }

    }
}
