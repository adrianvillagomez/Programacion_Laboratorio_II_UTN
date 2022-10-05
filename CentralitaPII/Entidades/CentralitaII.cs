using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CentralitaII :IGuardar<String>
    {
        public List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        public CentralitaII()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public CentralitaII(string nombreEmpresa) : this()
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

        public string RutaDeArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="FallaLogException"></exception>
        public bool Guardar()
        {
            string mensaje = $"{DateTime.Now.DayOfWeek} {DateTime.Now.Day} de {DateTime.Now.Month} de {DateTime.Now.Year} - {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond} - Se realizo una llamada.";
            try
            {
                using(StreamWriter guardar = new StreamWriter("bitacora.txt"))
                {
                    guardar.WriteLine(mensaje);
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new FallaLogException("error en guardar",ex);
            }
        }

        public string leer()
        {
            try
            {
                using(StreamReader leer = new StreamReader("bitacora.txt"))
                {
                    return leer.ReadToEnd();
                }
            }
            catch (Exception ex)
            {

                throw new FallaLogException("error en Leer", ex);
            }          
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
        /// <summary>
        /// Agrega una llamada existente a mi lista central
        /// </summary>
        /// <param name="c"></param>
        /// <param name="nuevaLlamada"></param>
        /// <returns></returns>
        /// <exception cref="CentralitaException"></exception>
        public static CentralitaII operator +(CentralitaII c,Llamada nuevaLlamada)
        {        
            if (!(c is null) && !(nuevaLlamada is null))
            {
                if (c != nuevaLlamada)
                {
                    if ((nuevaLlamada is Local) || (nuevaLlamada is Provincial))
                    {
                        c.AgregarLlamada(nuevaLlamada);
                        try
                        {
                            c.Guardar();
                        }
                        catch (FallaLogException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                else
                {
                    throw new CentralitaException("Llamada existente", "Centralita", "Agregar llamada a Centralita");
                }
            }
            return c;
        }
    }
}
