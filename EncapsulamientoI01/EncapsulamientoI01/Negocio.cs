using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamientoI01
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> queue;
        private string nombre;
        private Negocio()
        {
            queue = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.caja1);
            
        }
        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }
        public Cliente Cliente
        {
            get
            {
                return queue.Dequeue();
            }
            set
            {
                bool resultado = value + this;
            }
        }
        public static bool operator ==(Cliente c, Negocio n)
        {
            foreach (Cliente cliente in n.queue)
            {
                if (cliente == c)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Cliente c, Negocio n)
        {
            return !(c == n);
        }
        public static bool operator +(Cliente c, Negocio n)
        {
            if (c != n)
            {
                n.queue.Enqueue(c);
                return true;
            }

            return false;
        }
        public int ClientesPendientes 
        { 
            get 
            { 
                return this.queue.Count; 
            } 
        }
        public static bool operator ~(Negocio n)
        {
            if (n.ClientesPendientes > 0)
            {
                return n.caja.Atender(n.Cliente);
            }

            return false;
        }
    }
}
