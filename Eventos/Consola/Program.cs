using System;
using Biblioteca;
namespace Consola
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Reloj reloj = new Reloj();
            reloj.OnNotificarCambio += ImprimirHora;
            reloj.Iniciar();

            
            Console.ReadKey();
        }

        public static void ImprimirHora(Reloj reloj)
        {
            Console.Clear();
            Console.WriteLine($"{reloj.Hora} : {reloj.Minutos} : {reloj.Segundos}");
        }
        public static void Metodo(Prueba e)
        {
            e.Nombre = "juan";
        }
    }
    public class Prueba
    {
        
        public Prueba()
        {
        }

        public string Nombre { get; set; }
    }
}
