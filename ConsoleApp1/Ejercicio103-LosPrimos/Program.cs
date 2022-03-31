using System;

namespace Ejercicio103_LosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool condicion = false;
            do
            {
                int primerNumero;
                int divisible = 0;
                bool respuesta;
                Console.WriteLine("Ingrese un numero");
                string numeroUno = Console.ReadLine();
                respuesta = int.TryParse(numeroUno, out primerNumero);
                if (respuesta == true)
                    {
                    for (int i = 1; i <=primerNumero;i++)
                    {
                        if (primerNumero % i == 0)
                        {
                            divisible++;
                        }                       
                    }
                                
                    Console.WriteLine("Desea salir?");
                    string salida=Console.ReadLine();
                    if (salida == "si")
                    {
                        condicion = true;
                    }
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es un numero");
                }
            } while (condicion == false);   
        }
    }
}
