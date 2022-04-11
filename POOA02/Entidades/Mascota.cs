using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private int fechaNacimiento;
        private string historialVacunacion;
        public Mascota(string especie,string nombre,int fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }
        
        public void SetVacuna(string value)
        {
            this.historialVacunacion= value;
        }
        public string MostrarMascota()
        {
            StringBuilder mascota = new StringBuilder();
            mascota.AppendLine($"Especie : {this.especie}");
            mascota.AppendLine($"Nombre : {this.nombre}");
            mascota.AppendLine($"Fecha de Nacimiento : {this.fechaNacimiento}");
            mascota.AppendLine($"Historial De Vacunacion : {this.historialVacunacion}");
            //Console.WriteLine(mascota.ToString());
            return mascota.ToString();
        }
    }
}
