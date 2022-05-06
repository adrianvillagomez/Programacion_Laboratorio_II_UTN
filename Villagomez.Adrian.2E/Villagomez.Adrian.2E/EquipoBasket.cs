using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villagomez.Adrian._2E
{
    public class EquipoBasket : Equipo
    {
        private Eliga liga;

        public EquipoBasket(string nombre) : this(nombre,Eliga.NBA)
        {
        }
        public EquipoBasket(string nombre,Eliga liga) : base(nombre)
        {
            this.liga = liga;
        }

        public override int GetDificultad()
        {
            Random rand = new Random();
            if(this.liga is Eliga.NBA)
            {
                return rand.Next(8, 10);
            }else if (this.liga is Eliga.Euroleague)
            {
                return rand.Next(5,10);
            }
            else
            {
                return rand.Next(1,7);
            }
        }
        protected override string MostrarDatos()//Duda
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Basquet - ");
            sb.AppendLine(base.MostrarDatos());
            return sb.ToString();
        }
        public override string ToString()
        {
            return MostrarDatos();
        }
        public enum Eliga
        {
            NBA,Euroleague,ACB
        }
        
                
    }
}
