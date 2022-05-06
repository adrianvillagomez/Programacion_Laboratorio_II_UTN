using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local:Llamada
    {
        protected float costo;
        public Local(string Origen,string destino,float duracion,float costo) : base(duracion,destino,Origen)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada,float costo):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo=costo;
        }
        public float CostoLLamada
        {
            get
            {
                //return costo = CalcularCosto();
                return CalcularCosto();
            }               
        }
        private float CalcularCosto()
        {
            float CostoLlamada = this.costo * base.Duracion;
            return CostoLlamada;
        }
        override public string Mostrar()
        {
            StringBuilder localSb = new StringBuilder();          
            localSb.AppendLine($"Costo por minuto : {this.costo}");
            localSb.AppendLine($"Costo Llamada : ${CostoLLamada}");
            return base.Mostrar()+localSb.ToString();
        }
    }
}
