using System;
using System.Text;
namespace VistaAplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero;
            int numeroUno;
            Console.WriteLine("Ingrese un numero para mostrar su tabla");
            numero =Console.ReadLine();
            int.TryParse(numero, out numeroUno);
            TablaMultiplicar(numeroUno);
        }
        static string TablaMultiplicar(int numeroUno)
        {
            Console.WriteLine("Tabla de multiplicar del numero {0}", numeroUno);
            StringBuilder tabla = new StringBuilder();
            tabla.AppendLine($"{numeroUno} x 1 = {numeroUno*1}");
            tabla.AppendLine($"{numeroUno} x 2 = {numeroUno*2}");
            tabla.AppendLine($"{numeroUno} x 3 = {numeroUno*3}");
            tabla.AppendLine($"{numeroUno} x 4 = {numeroUno*4}");
            tabla.AppendLine($"{numeroUno} x 5 = {numeroUno*5}");
            tabla.AppendLine($"{numeroUno} x 6 = {numeroUno*6}");
            tabla.AppendLine($"{numeroUno} x 7 = {numeroUno*7}");
            tabla.AppendLine($"{numeroUno} x 8 = {numeroUno*8}");
            tabla.AppendLine($"{numeroUno} x 9 = {numeroUno*9}");
            Console.WriteLine(tabla.ToString());
            return tabla.ToString();
        }
    }
}
