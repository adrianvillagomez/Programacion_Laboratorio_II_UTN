using System;
using Entidades;
namespace SobrecargaC02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto producto = new Producto("000", "Fizbuz", 20.5f);
            Producto.MostrarPorducto(producto);
        }
    }
}
