using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Automovil : Vehiculo
    {
        private string marca;
        private static double valorHora;

        static Automovil() 
        {
            Automovil.valorHora = 120;
        }

        public Automovil(string patente,DateTime horaIngreso,string marca):base(patente,horaIngreso)
        {
            this.marca = marca;
        }
        static double ValorHora
        {
            set 
            {
                if(value > 0)
                {
                    Automovil.valorHora = value;
                }
            }
        }
        public override string Descripcion
        {
            get { return this.marca; }
        }
        public override double CostoEstadia
        {
            get { return this.CargoEstacionamiento(); }
        }
        protected override double CargoEstacionamiento()
        {
            double retorno;
            retorno = base.CargoEstacionamiento() * Automovil.valorHora;
            return retorno;
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****AUTOMOVIL*****");
            sb.AppendLine($"{base.MostrarDatos()}");
            sb.AppendLine($"Marca : {this.Descripcion}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
