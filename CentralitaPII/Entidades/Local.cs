using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local : Llamada
    {
        protected float costo;
        public Local(string Origen, string destino, float duracion, float costo) : base(duracion, destino, Origen)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public override float CostoLlamada
        {
            get
            {
               return  this.CalcularCosto();
            }
        }
        private float CalcularCosto()
        {
            float CostoLlamada = this.costo * base.Duracion;
            return CostoLlamada;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"---------------Llamada Local------------------------");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo Llamada :{this.CostoLlamada}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public override bool Equals(object obj)
        {
            //return obj.GetType() == this.GetType();
            return (obj is Local);
        }
    }
}
