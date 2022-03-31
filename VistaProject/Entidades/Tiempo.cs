using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tiempo
    {
        //Sobrecarga de Constructores
        public int hora;
        public int minutos;
        public int segundos;
        public Tiempo(int hora,int minutos,int segundos)
        {
            this.hora = hora;
            this.minutos = minutos; 
            this.segundos = segundos;
        }
        //Invoca a otro constuctor (:)
        public Tiempo(int hora,int minutos):this(hora,minutos,1)
        {

        }
        public Tiempo(int hora) : this(hora,1)
        {
            
        }
        public string Mostrar()
        {
            return $"{this.hora}:{this.minutos}:{this.segundos}";
        }

        //Sobrecarga de operadores 
        public static bool operator == (Tiempo t1,Tiempo t2)
        {
            return t1.hora == t2.hora && t1.minutos == t2.minutos && t1.segundos == t2.segundos;
        }
        public static bool operator !=(Tiempo t1, Tiempo t2)
        {
            return !(t1 == t2);
        }
        //Conversiones

        /// <summary>
        /// Devuelve el valor de los atributos expresados en segundos
        /// </summary>
        /// <param name="t"></param>
        public static implicit operator int(Tiempo t)
        {
            return (((t.hora * 60) + t.minutos) * 60) + t.segundos * 60;
        }
        //21:25:10
        public static explicit operator Tiempo(string t)
        {
            string[] tiempoString = t.Split(':');
            return new Tiempo(int.Parse(tiempoString[0]), int.Parse(tiempoString[1]), int.Parse(tiempoString[2]));
        }
    }
}
