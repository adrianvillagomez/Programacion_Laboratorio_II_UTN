using System;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            string numeroUno = Console.ReadLine();
            string numeroDos = Console.ReadLine();
            string numeroTres = Console.ReadLine();
            string numeroCuatro = Console.ReadLine();
            string numeroCinco = Console.ReadLine();
            int primerNumero;
            int segundoNumero;
            int tercerNumero;
            int cuartoNumero;
            int quintoNumero;
            int.TryParse(numeroUno, out primerNumero);
            int.TryParse(numeroDos, out segundoNumero);
            int.TryParse(numeroTres, out tercerNumero);
            int.TryParse(numeroCuatro, out cuartoNumero);
            int.TryParse(numeroCinco, out quintoNumero);

            /*for(int i =0;i<5;i++)
            {
                string numeroUno = Console.ReadLine();
                int primerNumero;
                int.TryParse(numeroUno, out primerNumero);
                Console.WriteLine("El numero es {0}", primerNumero);
            }*/
            
        }
    }
}
