using System;
using System.Text;
namespace Entidades
{
    public class Ingresantes
    {
        public string[] cursos= new string[3];
        public string direccion;
        public decimal edad;
        public string genero;
        public string nombre;
        public string pais;
        public Ingresantes(string nombre,string direccion,string genero,string pais,string[]cursos,decimal edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.edad = edad;
            this.cursos= cursos;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre : {this.nombre}");
            sb.AppendLine($"Direccion : {this.direccion}");
            sb.AppendLine($"Edad : {this.edad}");
            sb.AppendLine($"Genero : {this.genero}");
            sb.AppendLine($"Pais : {this.pais}");           
            foreach (string i in this.cursos)
            {
                sb.AppendLine(i);
            }
            return sb.ToString();           
        }
    }
}
