using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villagomez.Adrian._2E
{
    public class EquipoFutbol : Equipo
    {
        private bool jugadoresEstrellas;

        public EquipoFutbol(string nombre) : this(nombre,false)
        {
        }

        public EquipoFutbol(string nombre,bool jugadoresEstrellas):base(nombre)
        {
            this.jugadoresEstrellas = jugadoresEstrellas;
        }

        public override int GetDificultad()
        {
            Random rand = new Random();
            if(this.jugadoresEstrellas)
            {
                return rand.Next(7, 10)*2;
            }
            else
            {
                return rand.Next(7, 10);
            }
        }
        protected override string MostrarDatos()//Duda
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Futbol – ");
            sb.AppendLine(base.MostrarDatos());
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }
}
