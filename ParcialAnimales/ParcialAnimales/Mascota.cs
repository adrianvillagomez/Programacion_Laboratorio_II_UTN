using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialAnimales
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;
        public Mascota(string nombre,string raza)
        {
            this.nombre = nombre;
            this.raza = raza;  
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public string Raza
        {
            get { return raza; }
        }
        protected abstract string Ficha();
        
        protected string DatosCompletos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre {this.Nombre}");
            stringBuilder.AppendLine($"Raza {this.Raza}");
            return stringBuilder.ToString();
        }

    }
}
