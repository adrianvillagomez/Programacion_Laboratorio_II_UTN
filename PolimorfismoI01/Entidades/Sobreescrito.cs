using System;

namespace Entidades
{
    public abstract class Sobreescrito
    {
        public int i = 0;
        protected string miAtributo;
        public Sobreescrito()
        {
            this.miAtributo = "Probar Abstractos";
        }

        public override string ToString()
        {
            return $"¡Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(object obj)
        {
            //return this==obj;
            return obj is Sobreescrito;
        }
        public override int GetHashCode()
        {
            return i = 1142510181;
        }
        protected abstract string MiPropiedad
        {
            get;
        }
        public abstract string MiMetodo();
        
    }
}
