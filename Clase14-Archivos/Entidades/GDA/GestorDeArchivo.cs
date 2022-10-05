using Entidades.Exceptions;
using System;
using System.IO;

namespace Entidades.GDA
{
    public abstract class GestorDeArchivo
    {
        protected string rutaBase;
        protected ETipo tipo;
        public enum ETipo { XML, JSON, TXT };

        protected GestorDeArchivo(ETipo tipo)
        {
            DirectoryInfo path = Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{tipo}\\");
            rutaBase = path.FullName;
            this.tipo = tipo;
        }
    }
}
