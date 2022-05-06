using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CentralitaII
    {
        public List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        public CentralitaII()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public CentralitaII(string nombreEmpresa) : this()// sujeto a modificacion
        {
            this.razonSocial = nombreEmpresa;
        }
        public float GananciasPorProvincias
        {
            get
            {
                return this.CalcularGanancia(TipoLLamada.Provincial);
            }
        }
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLLamada.Local);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLLamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        private float CalcularGanancia(TipoLLamada tipo)
        {
            float acumulador = 0;

            foreach (Llamada item in this.listaDeLlamadas)
            {
                if (tipo == TipoLLamada.Local || tipo == TipoLLamada.Todas)
                {
                    if (item is Local)
                        acumulador += ((Local)item).CostoLlamada;
                }
                if (tipo == TipoLLamada.Provincial || tipo == TipoLLamada.Todas)
                {
                    if (item is Provincial)
                        acumulador += ((Provincial)item).CostoLlamada;
                }
            }

            return acumulador;
        }
        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);

        }
        private string Mostrar()
        {
            StringBuilder centralitaSb = new StringBuilder();
            centralitaSb.AppendLine($"Razon social : {this.razonSocial}");
            centralitaSb.AppendLine($"Ganancia Total : {GananciasPorTotal}");
            centralitaSb.AppendLine($"Ganancia por llamadas locales: {GananciasPorLocal}");
            centralitaSb.AppendLine($"Ganancia por llamadas provinciales : {GananciasPorProvincias}");
            centralitaSb.AppendLine($"Llamadas realizadas : {listaDeLlamadas.Count}");
            foreach (Llamada c in listaDeLlamadas)
            {
                centralitaSb.AppendLine($"Duraciones de llamadas : {c.Duracion} min");
            }
            return centralitaSb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        private  void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }
        public static bool operator ==(CentralitaII c ,Llamada llamada)
        {
            foreach(Llamada item in c.listaDeLlamadas)
            {
                if(llamada==item)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(CentralitaII c, Llamada llamada)
        {
            return !(c == llamada);
        }
        public static CentralitaII operator +(CentralitaII c,Llamada nuevaLlamada)
        {
            foreach (Llamada item in c.listaDeLlamadas)
            {
                if (nuevaLlamada != item)
                {
                    c.AgregarLlamada(nuevaLlamada);
                    return c;
                }
            }
            return c;
        }
    }
}
