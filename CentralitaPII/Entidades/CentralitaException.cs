using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CentralitaException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CentralitaException(string message,string clase,string metodo) :base(message)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public CentralitaException(string message, string clase, string metodo, Exception innerException): base(message,innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public string NombreClase
        {
            get { return this.nombreClase; }
        }
        public string NombreMetodo
        {
            get { return this.nombreMetodo; }  
        }

    }
}
