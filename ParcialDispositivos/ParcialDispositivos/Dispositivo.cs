using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialDispositivos
{
    public enum SistemaOperativo
    {
        ANDROID, IOS
    }
    public static class  Dispositivo
    {
        private static List<Aplicacion> appInstaladas;
        private static SistemaOperativo sistemaOperativo;
        static Dispositivo()
        {
            Dispositivo.appInstaladas = new List<Aplicacion>();
            Dispositivo.sistemaOperativo = SistemaOperativo.ANDROID;
        }
        public static bool InstalarApp(Aplicacion app)
        {
            if (app.SistemaOperativo == Dispositivo.sistemaOperativo)
            {
                return appInstaladas + app;             
            }
            return false;
        }
        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Sistemas Operativo {Dispositivo.sistemaOperativo}");
            foreach(Aplicacion aplicacion in appInstaladas)
            {
                sb.AppendLine($"Aplicaciones {aplicacion.ObtenerInformacionApp()}");
            }
            return sb.ToString();
        }
    }
}
