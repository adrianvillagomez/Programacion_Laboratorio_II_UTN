using System;
using System.Text;
namespace Entidades
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;
        public Producto(string codigoDeBarra,string marca,float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public static string MostrarPorducto(Producto p)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Codigo de barra : {p.codigoDeBarra}");
            Console.WriteLine(stringBuilder.ToString());
            return stringBuilder.ToString();

        }
    }
}
