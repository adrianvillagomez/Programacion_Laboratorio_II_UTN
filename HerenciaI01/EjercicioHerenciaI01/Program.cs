using System;
using Entidades;
namespace EjercicioHerenciaI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camion camion = new Camion(4, 2, VehiculoTerrestre.Colores.Gris, 20, 1000);
            Moto moto = new Moto(2, 0, VehiculoTerrestre.Colores.Negro, 4);
            Automovil automovil = new Automovil(4, 4, VehiculoTerrestre.Colores.Rojo, 200);
            Console.WriteLine($"{camion.Mostrar()} {camion.cantidadMarchas} {camion.pesoCarga}");
            Console.WriteLine($"{moto.Mostrar()} {moto.cilindrada}");
            Console.WriteLine($"{automovil.Mostrar()} {automovil.cantidadPasajeros}");
        }
    }
}
