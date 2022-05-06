using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamientoI01
{
    public class Cliente
    {
        private string nombre;
        private int numero;
        public Cliente (int numero)
        {
            this.numero = numero;
        }
        public Cliente(int numero,string nombre):this(numero)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get 
            { 
                return nombre; 
            }
            set
            {
                nombre = value;
            }
        }
        public int Numero
        {
            get
            {
                return numero;
            }
        }
        public static bool operator ==(Cliente c1,Cliente c2)
        {
            return c1.nombre == c2.nombre;
        }
        public static bool operator !=(Cliente c1,Cliente c2)
        {
            return !(c1==c2);
        }
    }
}
