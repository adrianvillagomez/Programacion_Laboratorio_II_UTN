using System;
using System.Text;
namespace Entidades
{
    public abstract class  Vehiculo
    {
        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;
        public enum EVehiculos
        {
            Automovil,Moto
        }
        public Vehiculo(string patente,DateTime horaIngreso)
        {
            this.patente = Patente;
            this.horaIngreso = horaIngreso;
        }
        public abstract double CostoEstadia
        {
            get;
        }
        public abstract string Descripcion
        {
            get;
        }   
        public DateTime HoraIngreso
        {
            get { return horaIngreso; }          
        }
        public DateTime HoraEgreso
        {
            get { return horaEgreso; }
            set 
            { 
                if(value > this.HoraIngreso ) //this.HoraIngreso < this.HoraEgreso
                {
                    this.horaEgreso = value;
                }
                    
             }
        }
        public string Patente
        {
            get { return this.patente; }

            set
            {
               if(ValidarPatente(value))
                {
                    this.patente = value;
                }
            }
        }
        private bool ValidarPatente (string patente)
        {
            if (patente.Length >= 6 && patente.Length < 8)  
            {
                return true;
            }
            return false;
        }
        protected virtual double CargoEstacionamiento() 
        {
            double retorno;
            retorno = (this.HoraEgreso - this.HoraIngreso).TotalHours;
            return retorno;
        }
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Patente : {this.Patente}");
            sb.AppendLine($"Hora Ingreso : {this.HoraIngreso}");
            return sb.ToString();
        }
        public static bool operator ==(Vehiculo v1,Vehiculo V2)
        {
            return v1.Patente == V2.Patente;
        }
        public static bool operator!=(Vehiculo v1, Vehiculo V2)
        {
            return !(v1 == V2);
        }
    }
}
