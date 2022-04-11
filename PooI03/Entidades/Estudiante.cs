using System;
using System.Text;
namespace Entidades
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int nombreSegundoParcial;
        static Random random;
        static Estudiante()
        {
            random = new Random();
        }
        public Estudiante(string nombre,string apellido,string legajo)
        {
            this.nombre = nombre;
            this.legajo = legajo;
            this.apellido=apellido;
        }
        public void SetNotaPrimerParcial(int nota)
        {
            if (nota > 0)
            {
                this.notaPrimerParcial = nota;
            }
        }
        public void SetNotaSegundoParcial(int value)
        {
            if (value > 0)
            {
                this.nombreSegundoParcial = value;
            }
        }
        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.nombreSegundoParcial) / 2;
        }
        public double CalcularNotaFinal()
        {
            double retorno = 0;
           if(this.notaPrimerParcial>=4 && this.nombreSegundoParcial>=4)
            {
                return random.Next(6, 10);
            }else
            {
                retorno = -1;
                return retorno;
            }           
        }
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre : {this.nombre}");
            stringBuilder.AppendLine($"Apellido : { this.apellido}");
            stringBuilder.AppendLine($"Legajo: {this.legajo}");
            stringBuilder.AppendLine($"Nota primer parcial {this.notaPrimerParcial}");
            stringBuilder.AppendLine($"Nota segundo parcial {this.nombreSegundoParcial}");
            stringBuilder.AppendLine($"Promedio : {CalcularPromedio()}");
            if(CalcularNotaFinal()==-1)
            {
                stringBuilder.AppendLine("Alumno Desaprobado");
            }else
            {
                stringBuilder.AppendLine($"Nota Final : {CalcularNotaFinal()}");
            }
            Console.WriteLine(stringBuilder.ToString());
            return stringBuilder.ToString();
        }
    }
}
