using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : VehiculoTerrestre
    {
        public short cilindrada;
        public Moto(short cantidadRueadas, short cantidadPuertas, Colores color,short cilindrada):base(cantidadRueadas,cantidadPuertas,color)
        {
            this.cilindrada = cilindrada;
        }
    }
}
