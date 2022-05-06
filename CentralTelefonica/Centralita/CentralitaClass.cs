using System;
using System.Collections.Generic;
using System.Text;
namespace Centralita
{
    public class CentralitaClass
    {
        public List<Llamada> listaDeLlamadas;
        protected string razonSocial;  
        public CentralitaClass()
        {
            this.listaDeLlamadas = new List<Llamada>();          
        }
        public CentralitaClass(string nombreEmpresa) : this()// sujeto a modificacion
        {
            this.razonSocial = nombreEmpresa;
        }
        public float GananciasPorProvincias
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLLamada.Provincial);
            }
        }
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLLamada.Local);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLLamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        private float CalcularGanancia(Llamada.TipoLLamada tipo)
        {
            float acumulador = 0;

            foreach (Llamada item in this.listaDeLlamadas)
            {
                if (tipo == Llamada.TipoLLamada.Local || tipo == Llamada.TipoLLamada.Todas)
                {
                    if (item is Local)
                        acumulador += ((Local)item).CostoLLamada;
                }
                if (tipo == Llamada.TipoLLamada.Provincial || tipo == Llamada.TipoLLamada.Todas)
                {
                    if (item is Provincial)
                        acumulador += ((Provincial)item).CostoLLamada;
                }
            }

            return acumulador;           
        }
        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);

        }
        public string Mostrar()
        {
            StringBuilder centralitaSb = new StringBuilder();
            centralitaSb.AppendLine($"Razon social : {this.razonSocial}");
            centralitaSb.AppendLine($"Ganancia Total : {GananciasPorTotal}");
            centralitaSb.AppendLine($"Ganancia por llamadas locales: {GananciasPorLocal}");
            centralitaSb.AppendLine($"Ganancia por llamadas provinciales : {GananciasPorProvincias}");
            centralitaSb.AppendLine($"Llamadas realizadas : {listaDeLlamadas.Count}");
            foreach(Llamada c in listaDeLlamadas)
            {
                centralitaSb.AppendLine($"Duraciones de llamadas : {c.Duracion} min");
            }
            return centralitaSb.ToString();
        }

    }
}
