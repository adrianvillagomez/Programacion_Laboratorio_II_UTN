using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Moto : Vehiculo
    {
        private ETipo tipo;
        private static double valorHora;

        public override double CostoEstadia
        {
            get
            {
                return this.CargoEstacionamiento();
            }
        }

        public override string Descripcion
        {
            get
            {
                return this.tipo.ToString();
            }
        }

        static double ValorHora
        {
            set
            {
                if(value > 0)
                {
                    Moto.valorHora = value;
                }
            }
        }

        static Moto()
        {
            Moto.valorHora = 100;
        }

        public Moto(string patente,DateTime horaIngreso,ETipo tipo) :base(patente,horaIngreso)
        {
            this.tipo = tipo;
        }

        public enum ETipo
        {
            Ciclomotor, Scooter,Sport
        }
        protected override double CargoEstacionamiento()
        {
            return base.CargoEstacionamiento()*Moto.valorHora;
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****MOTO*****");
            sb.AppendLine($"{base.MostrarDatos()}");
            sb.AppendLine($"Tipo : {this.Descripcion}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
