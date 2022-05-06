using System;

namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        public int cantidadPasajeros;

        public Automovil(short cantidadRueadas, short cantidadPuertas, Colores color,int cantidadPasajeros):base(cantidadRueadas,cantidadPuertas,color)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
