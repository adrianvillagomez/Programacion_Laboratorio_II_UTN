using System;
using Entidades;
namespace POOA02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clientes cliente = new Clientes("Suarez101", "Jose", "fernandez", 01220,(new Mascota("Canino","Pipo",2018)));
            cliente.mascota.SetVacuna("Sin vacuna");
            cliente.Mostrar();

            Clientes clienteDos = new Clientes("Corrientes202", "Juan", "Rodriguez",02223,(new Mascota("Felino", "Pepe", 2010)));
            clienteDos.mascota.SetVacuna("Triple Felina");
            clienteDos.Mostrar();

            Clientes clienteTres = new Clientes("Suipacha534", "Hernan", "Fizro", 15236, (new Mascota("Felino","pichichen",2015)));
            clienteTres.mascota.SetVacuna("Sin vacuna");
            clienteTres.Mostrar();
            clienteTres.SetMascota(new Mascota("Canino", "Firulais", 2014));
            clienteTres.mascota.SetVacuna("Antirabica");
            clienteTres.Mostrar();

        }
    }
}
