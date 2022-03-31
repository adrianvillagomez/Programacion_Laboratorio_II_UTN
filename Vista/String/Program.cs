using System;
using System.Text;
namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Esteban";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hola");//Agrega informacion final del stringbuilder actual
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.AppendLine("Estamos en la clase de labo");//Agrega información al final del StringBuilder actual con un salto de línea
            stringBuilder.AppendLine("Curso  2 E");
            stringBuilder.AppendFormat($"Mi nombre es {nombre}");
            //Reemplaza de formato pasado en un string con texto formateado.
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
