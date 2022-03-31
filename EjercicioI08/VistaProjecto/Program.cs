using System;

namespace VistaProjecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anioNacimiento;
            int mesNacimiento;
            int diaNacimiento;
            Console.WriteLine("Ingrese anio de nacimiento");
            int.TryParse(Console.ReadLine(), out anioNacimiento);
            Console.WriteLine("Ingrese mes de nacimiento");
            int.TryParse(Console.ReadLine(),out mesNacimiento);
            Console.WriteLine("Ingrese dia de naciemiento");
            int.TryParse(Console.ReadLine(),out diaNacimiento);
            Fecha(anioNacimiento, mesNacimiento,diaNacimiento);
        }
        static void Fecha (int anio,int mes,int dia)
        {
            DateTime fechaParametro = new DateTime(anio,mes,dia);
            DateTime fechaActual = new DateTime(2022,03,27);
            Console.WriteLine("La fecha ingresada es " + fechaParametro.ToString("dd - MM- yyyy"));
            Console.WriteLine("La fecha actual es " + fechaActual.ToString("dd - MM - yyyy"));
            Console.WriteLine("Los dias vividos desde su nacimiento hasta la actualidad son: "+ fechaActual.Subtract(fechaParametro).Days);
        }
    }
}
