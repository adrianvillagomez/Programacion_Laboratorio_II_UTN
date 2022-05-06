using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialAnimales
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre, string raza,int edad,bool esAlfa):this(nombre,raza)
        {
            this.edad=edad;
            this.esAlfa = esAlfa;
        }
        public Perro(string nombre, string raza):base(nombre,raza)
        {
        }
        public bool EsAlfa
        {
            get { return this.esAlfa; }
            set { this.esAlfa = value; }
        }
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            if (this.esAlfa==true)
            {
                //StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{this.Nombre} {this.Raza},alfa de la manada,edad {this.Edad}");
            }
            else
            {
                sb.AppendLine($"{this.Nombre} {this.Raza} edad {this.Edad}");
            }
            return sb.ToString();
        }
        public static bool operator ==(Perro j1,Perro j2)
        {
            return j1.Edad == j2.Edad && j1.Nombre == j2.Nombre && j1.Raza == j2.Raza;
        }
        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }
        public static explicit operator int(Perro perro)
        {
            return perro.Edad;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Edad {this.Edad}");
            sb.AppendLine($"EsAlfa {this.esAlfa}");
            return base.DatosCompletos()+sb.ToString();
        }
        public override bool Equals(object obj)
        {
            return this == (Perro)obj;
        }
    }
}
