using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int capacidadEstacionamiento;
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listaVehiculos;
        private string nombre;
        
        private Estacionamiento(string nombre , int capacidad)
        {
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;
            listaVehiculos = new List<Vehiculo>();
        }   
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public List<Vehiculo> ListadoVehiculos
        {
            get
            {
                return this.listaVehiculos;
            }
        }
        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if (Estacionamiento.estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
            }
            else
            {
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;
            }
            return Estacionamiento.estacionamiento;
        }
        public string InformarSalida(Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre Estacionamiento {this.nombre}");
            sb.AppendLine($"Datos del vehiculo  : {vehiculo.ToString()}");
            sb.AppendLine($"Hora Egreso : {vehiculo.HoraEgreso}");
            sb.AppendLine($"Cargo Estacionamiento : {vehiculo.CostoEstadia}");//M
            return sb.ToString();
        }
        public static bool operator ==(Estacionamiento estacionamiento,Vehiculo vehiculo)
        {
            bool retorno = false;
            foreach(Vehiculo item in estacionamiento.ListadoVehiculos)
            {
                if(item is Vehiculo)
                {
                    retorno = true;
                    return retorno;
                }
                //if (item is Moto||item is Automovil)
                //{
                //    return true;
                //}
            }
            return retorno;
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }
        public static bool operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)//MM
        {
            bool resultado = false;
            if(estacionamiento.listaVehiculos.Count < estacionamiento.capacidadEstacionamiento && estacionamiento != vehiculo )
            {
                Estacionamiento.estacionamiento.listaVehiculos.Add(vehiculo);
                resultado = true;
            }
            return resultado;
        }
        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool resultado = false;
            if (estacionamiento==vehiculo)
            {
                vehiculo.HoraEgreso = DateTime.Now;
                Estacionamiento.estacionamiento.listaVehiculos.Remove(vehiculo);
                resultado = true;
            }
            return resultado;
        }
    }
}
