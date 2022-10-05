using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private string sexo;
        private int edad;
        private string email;

        public Persona(string nombre, string email, string apellido, string sexo, int edad)
        {

            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.edad = edad;
            this.email = email;
        }
        public Persona(int id, string nombre, string email, string apellido, string sexo, int edad):
            this(nombre,email,apellido,sexo,edad)
        {
            this.id = id;

        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            return $"id:{this.id}\n" +
                $"nombre:{this.nombre}\n" +
                $"apellido:{this.apellido}\n" +
                $"sexo:{this.sexo}\n" +
                $"edad:{this.edad}\n" +
                $"email:{this.email}\n";
        }
    }
}
