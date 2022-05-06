using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialDispositivos
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;

        public AppMusical(string nombre,SistemaOperativo sitemaOperativo,int tamanioInicial, List<string> listaCanciones):base(nombre,sitemaOperativo,tamanioInicial)
        {
            this.listaCanciones = listaCanciones;
        }
        public AppMusical(string nombre, SistemaOperativo sitemaOperativo, int tamanioInicial):this(nombre,sitemaOperativo,tamanioInicial,new List<string>())
        {
        }

        protected override int Tamanio
        {
            get
            {
                return tamanioMB+=listaCanciones.Count * 2;              
            }
        }
        public override string ObtenerInformacionApp()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.ObtenerInformacionApp());
            stringBuilder.AppendLine("Lista de Canciones");
            foreach (string item in listaCanciones)
            {
               stringBuilder.AppendLine(item);
            }
            return stringBuilder.ToString();
        }
    }
}
