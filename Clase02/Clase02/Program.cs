using System;
using LogicaNegocio;
namespace Clase02
{
    internal class Program
    {     
        static float temperaturaCelsius;
        static float temperaturaKelvin;
        static void Main(string[] args)
        {
            temperaturaCelsius = 30;
            
            temperaturaKelvin = ConversorDeTemperatura.ConvertirCelsiusAKelvin(temperaturaCelsius);
            MostrarTemperaturas();
        }
        static void MostrarTemperaturas()
        {
            Console.WriteLine($"La temperatura {temperaturaCelsius}");//string interpolado
            Console.WriteLine($"La temperatura {temperaturaKelvin}");
        }
    }
}
