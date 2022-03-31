using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // dinero usamos decimal
            // console.Readline(); para ingresar una linea de caracteres por consolo
            //int.TryParse(variable a leer,out variable donde se convierte)retorna true si se pudo false si no
            string[]nombres=new string[10];
            nombres[0] = "pepe \n";
            nombres[1] = "jose";
            foreach (string item in nombres)
            {
                Console.Write(item);
            }
                
        }
    }
}
