using System;
using System.Text;
using System.Collections.Generic;
namespace ParcialDispositivos
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMB;

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMB)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMB = tamanioMB;
        }

        protected abstract int Tamanio { get; }
        public SistemaOperativo SistemaOperativo
        {
            get { return sistemaOperativo; }
        }
        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre : {this.nombre}");
            sb.AppendLine($"Sistema Operativo {this.SistemaOperativo}");
            sb.AppendLine($"tamaño {this.tamanioMB}");
            return sb.ToString();
        }
        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {

            int maximoTamanio = int.MinValue;
            Aplicacion aplicacionMasPesada = null;

            foreach (Aplicacion app in listaApp)
            {
                if (app.Tamanio > maximoTamanio)
                {
                    maximoTamanio = app.Tamanio;
                    aplicacionMasPesada = app;
                }
            }

            return aplicacionMasPesada;
        }
        public override string ToString()
        {
            return $"Nombre : {this.nombre}";
        }
        public static bool operator ==(List<Aplicacion>listaApp,Aplicacion app)
        {
            foreach(Aplicacion c in listaApp)
            {
                if(c.nombre == app.nombre)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }
        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if(listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }
            return false;
        }
    }
}
