using System;
using System.Text;
namespace Entidad
{
    public class Persona
    {
        private string nombre;
        private int fechaDeNacimiento;
        private int dni;
        public Persona(string nombre,int fechaDeNacimiento,int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetNombre(string value)
        {
            this.nombre=value;
        }
        public int GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }
        public void SetFechaDeNacimiento(int value)
        {
            this.fechaDeNacimiento = value;
        }
        public int GetDni()
        {
            return this.dni;
        }
        public void SetDni(int value)
        {
            this.dni = value;
        }
        private int CalcularEdad()
        {
            return 2022-this.fechaDeNacimiento;
        }
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"nombre {this.nombre}");
            stringBuilder.AppendLine($"Fecha de nacimiento: {this.fechaDeNacimiento}");
            stringBuilder.AppendLine($"DNI: {this.dni}");
            stringBuilder.AppendLine($"Edad actual {CalcularEdad()}");
            Console.WriteLine(stringBuilder.ToString());
            return stringBuilder.ToString();
        }
        public string EsMayorDeEdad()
        {
            if(CalcularEdad()>18)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Es mayor de edad");
                Console.WriteLine(sb.ToString());
                return sb.ToString();                             
            }else
            {
                StringBuilder menor = new StringBuilder();
                menor.AppendLine("Es menor de edad");
                Console.WriteLine(menor.ToString());
                return menor.ToString();
            }
        }
    }
}
