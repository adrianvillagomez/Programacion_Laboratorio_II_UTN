using System;
using System.Text;
namespace Entidades
{
    public enum TipoLLamada
    {
        Local, Provincial, Todas
    }
    public abstract class Llamada
    {     
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public abstract float CostoLlamada { get; }
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion : {Duracion} minutos");
            sb.AppendLine($"NroDestino : {NroDestino}");
            sb.AppendLine($"NroOrigen : {NroOrigen}");
            return sb.ToString();
        }
        public static bool operator ==(Llamada llamada1, Llamada llamada2)//a modificar
        {
            return llamada1.GetType() == llamada2.GetType() && llamada1.nroDestino == llamada2.nroDestino && llamada1.nroOrigen == llamada2.nroOrigen;
        }
        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.Duracion)
            {
                return 1;

            }
            else if (llamada1.Duracion == llamada2.Duracion)
            {
                return 0;

            }
            else
            {
                return -1;
            }         
        }

    }
}
