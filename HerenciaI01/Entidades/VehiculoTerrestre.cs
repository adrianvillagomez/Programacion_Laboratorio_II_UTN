using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoTerrestre
    {
        public short cantidadRuedas;
        public short cantidadPuertas;
        public Colores color;
        public enum Colores
        {
            Rojo, Blanco, Azul, Gris, Negro
        }
        public VehiculoTerrestre(short cantidadRueadas,short cantidadPuertas,Colores color)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
            this.cantidadRuedas = cantidadRueadas;
        }
        public string Mostrar ()
        {
           return $"{cantidadRuedas} {cantidadPuertas} {color}";
        }
    }
}
