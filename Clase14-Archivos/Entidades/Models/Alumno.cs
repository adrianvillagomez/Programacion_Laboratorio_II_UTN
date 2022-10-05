using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Alumno : Persona
    {

        private List<string> materias;
        private float nota;

        public Alumno() : base()
        {
            materias = new List<string>();
        }
        public Alumno(string nombre, int edad, float nota) : base(nombre, edad)
        {
            this.materias = new List<string>();
            this.nota = nota;
        }


        public List<string> Materias { get => this.materias; set => this.materias = value; }
        public float Nota { get => this.nota; set => this.nota = value; }

        public override string ToString()
        {
            string materias = string.Empty;

            this.materias.ForEach(m => materias += " " + m);
            return $"Nombre:{nombre}, Edad:{edad}\nMaterias:{materias}";
        }
    }
}
