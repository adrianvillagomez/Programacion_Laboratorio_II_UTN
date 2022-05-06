using System;
using System.Text;
namespace Villagomez.Adrian._2E
{
    public abstract class Equipo
    {
        protected string nombre;
        protected int partidosEmpatados;
        protected int partidosGanados;
        protected int partidosJugados;
        protected int partidosPerdidos;
        protected int puntuacion;

        protected Equipo(string nombre)
        {
            this.nombre = nombre;
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        public string Tipo
        {
            get { return this.GetType().Name; }
        }
        public int PE
        {
            get { return this.partidosEmpatados; }
            set { this.partidosEmpatados = value; }
        }
        public int PG
        {
            get { return this.partidosGanados; }
            set { this.partidosGanados = value; }
        }
        public int PJ
        {
            get { return this.partidosJugados; }
            set { this.partidosJugados = value; }
        }
        public int PP
        {
            get { return this.partidosPerdidos; }
            set { this.partidosPerdidos = value; }
        }
        public int Puntuacion
        {
            get { return this.puntuacion; }
            set { this.puntuacion = value; }
        }
        public override bool Equals(object obj)
        {
            /*Equipo equipo = obj as Equipo;
            return equipo is not null && this.Tipo == equipo.Tipo;*/
            return this.GetType() == obj.GetType();
        }
        public static bool operator ==(Equipo equipoA,Equipo equipoB)
        {
            return equipoA.Nombre == equipoB.Nombre && equipoA.Equals(equipoB);
        }
        public static bool operator !=(Equipo equipoA,Equipo equipoB)
        {
            return !(equipoA == equipoB);
        }
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del Equipo : {this.Nombre}");
            return sb.ToString();
        }
        public abstract int GetDificultad();

        public static bool JugarPartido(Equipo equipoA,Equipo equipoB)
        {
            bool returnAux = false;
            if(equipoA.Equals(equipoB))
            {
                equipoA.PJ++;
                equipoB.PJ++;
                returnAux=true;
                if(equipoA.GetDificultad() > equipoB.GetDificultad())
                {
                    equipoA.Puntuacion += 3;
                    equipoA.PG++;
                    equipoB.PP++;
                }else if (equipoB.GetDificultad()>equipoB.GetDificultad())
                {
                    equipoB.Puntuacion+=3;
                    equipoB.PG++;
                    equipoA.PP++;
                }
                else
                {
                    equipoA.Puntuacion +=1;
                    equipoB.Puntuacion +=1;
                    equipoA.PE ++;
                    equipoB.PE ++;
                }                                           
            }
            return returnAux;
        }
    }
}
