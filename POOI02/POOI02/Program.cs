using System;
using Entidad;
namespace POOI02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("Juan", 1992, 123);
            Persona personaDos = new Persona("Jorge", 2010, 126);
            Persona personaTres = new Persona("Fede", 1999, 547);
            personaUno.Mostrar();
            personaUno.EsMayorDeEdad();
            personaDos.Mostrar();
            personaDos.EsMayorDeEdad();
            personaTres.Mostrar();
            personaTres.EsMayorDeEdad();
        }
    }
}
