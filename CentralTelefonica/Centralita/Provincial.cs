using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;
        public float CostoLLamada
        {
            get
            {
                return  CalcularCosto();
            }
        }
        public enum Franja
        {
            Franja_1,Franja_2,Franja_3
        }
        public Provincial(string Origen,Franja miFranja,float duracion,string destino):base(duracion,destino,Origen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(Franja miFranja,Llamada llamada):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria=miFranja;
        }
        private float CalcularCosto()
        {
            float CostoLLamada;
            if (franjaHoraria is Franja.Franja_1)
            {
                CostoLLamada = Duracion * 0.99f;
            }else if(franjaHoraria is Franja.Franja_2)
            {
                CostoLLamada = Duracion * 1.25f;
            }else
            {
                CostoLLamada = Duracion * 0.66f;
            }
            return CostoLLamada;
        }
        public override string Mostrar()
        {
            StringBuilder provincialSb = new StringBuilder();
            provincialSb.AppendLine($"Franja Horaria : {this.franjaHoraria}");
            provincialSb.AppendLine($"Costo de la llamada : {CostoLLamada}");
            return base.Mostrar() + provincialSb.ToString();
        }
    }
}
