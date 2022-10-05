using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Profesor : Persona
    {
        private string legajo;
        public Profesor()
        {

        }
        public Profesor(string nombre, int edad, string legajo) : base(nombre, edad)
        {
            this.legajo = legajo;
        }

        public string Legajo { get => legajo; set => legajo = value; }
    }
}
