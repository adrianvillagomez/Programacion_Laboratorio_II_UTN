using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villagomez.Adrian._2E
{
    public class Competencia
    {
        private int cantidadCompetidores;
        private List<Equipo> equipos;
        private string nombre;
        private Competencia(string nombre):this(nombre,5)
        {
            this.nombre = nombre;         
        }
        public Competencia(string nombre,int cantidadCompetidores)
        {
            equipos = new List<Equipo>();
            this.nombre = nombre;
            this.cantidadCompetidores=cantidadCompetidores;
        }
        public List<Equipo> Equipos
        {
            get { return this.equipos; }
        }
        public int CantidadCompetidores
        {
            get { return cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }
        public string Nombre
        {
            get { return nombre;}
            set { nombre = value; }
        }
        public static implicit operator Competencia(string nombre)
        {
            return new Competencia(nombre);
            // llama al constructor privado
            //ejemplo main : Competencia c = "alejando";
            //alejandro es conversion explicita de new competencia en el main esto es igual a
            //Competencia c = new Competencia("alejandro")
        }
        public static bool operator ==(Competencia torneo , Equipo equipo)//duda
        {
            foreach(Equipo c in torneo.Equipos)
            {
                if(c==equipo)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }
        public static Competencia operator +(Competencia torneo, Equipo equipo)
        {
            if(torneo.CantidadCompetidores > torneo.Equipos.Count && torneo!=equipo)
            {
                torneo.equipos.Add(equipo);
            }
            return torneo;
        }
        public static string MostrarTorneo(Competencia torneo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de competidores {torneo.CantidadCompetidores}");
            sb.AppendLine($"Nombre : {torneo.Nombre}");
            foreach(Equipo c in torneo.Equipos)
            {
                //sb.AppendLine($"Lista equipos : {c}");
                sb.AppendLine(c.ToString());
            }
            return sb.ToString();
        }
    }
}
