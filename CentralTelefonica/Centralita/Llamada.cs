using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        public enum TipoLLamada
        {
            Local,Provincial,Todas
        }
        public Llamada(float duracion,string nroDestino,string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
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
            /*int retorno=0;
            List<int> llamadaList = new List<int>();
            llamadaList.Add((int)llamada1.Duracion);
            llamadaList.Add((int)llamada2.Duracion);
            llamadaList.Sort();
            foreach (int c in llamadaList)
            {
                Console.WriteLine($"Duracion : {c}");
            }
            return retorno;*/
        }
        virtual public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion : {Duracion} minutos");
            sb.AppendLine($"NroDestino : {NroDestino}");
            sb.AppendLine($"NroOrigen : {NroOrigen}");
            return sb.ToString();
        }

    }
}
