using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLibreria
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;
        private Vendedor()
        {
            ventas = new List<Publicacion>();
        }
        public Vendedor(string nombre):this()
        {
            this.nombre = nombre;
        }
        public static bool operator +(Vendedor vendedor,Publicacion publicacion)
        {
            bool returnoAux=false;
            if(publicacion.HayStock)
            {
                vendedor.ventas.Add(publicacion);
                publicacion.Stock--;
                returnoAux=true;
            }
            return returnoAux;
        }
        public static string ObtenerInforems(Vendedor vendedor)
        {
            float acum = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE ");
            sb.AppendLine(vendedor.nombre.ToUpper());
            sb.AppendLine("PUBLICACION");
            foreach (Publicacion c in vendedor.ventas)
            {
                sb.AppendLine(c.ObtenerInformacion());
                acum += c.Importe;
            }          
            sb.AppendLine($"Ganancia Total : {acum}");
            return sb.ToString();
        }
    }
}
