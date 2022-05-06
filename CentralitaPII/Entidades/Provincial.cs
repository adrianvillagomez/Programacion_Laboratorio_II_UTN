using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Franja
    {
        Franja_1, Franja_2, Franja_3
    }
    public class Provincial : Llamada
    {     
        protected Franja franjaHoraria;
        public Provincial(string Origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, Origen)//modificado
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja,llamada.Duracion, llamada.NroDestino)
        {

        }     
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        private float CalcularCosto()
        {
            float CostoLLamada;
            if (franjaHoraria is Franja.Franja_1)
            {
                CostoLLamada = Duracion * 0.99f;
            }
            else if (franjaHoraria is Franja.Franja_2)
            {
                CostoLLamada = Duracion * 1.25f;
            }
            else
            {
                CostoLLamada = Duracion * 0.66f;
            }
            return CostoLLamada;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"---------------Llamada Provincial-------------------");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Franja Horaria: {this.franjaHoraria}");
            sb.AppendLine($"Costo Llamada : {this.CostoLlamada}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }
    }
}
