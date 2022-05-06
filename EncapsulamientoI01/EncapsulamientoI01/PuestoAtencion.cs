using System;
using System.Threading;
namespace EncapsulamientoI01
{
    public class PuestoAtencion
    {
        private Puesto puesto;
        private static int numeroActual;
        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public enum Puesto
        {
            caja1, caja2
        }
        public bool Atender(Cliente cli)
        {
            bool tiempo = false;
            if (cli is not null)
            {
                Thread.Sleep(3000);
                return true;
            }
            return tiempo;
        }
        public static int NumeroActual
        {
            get
            {
                return numeroActual++;
            }
        }
                
    }
}
