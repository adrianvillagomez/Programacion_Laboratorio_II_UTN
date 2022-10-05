using Entidades.Interfaces;
using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades.Exceptions;
using System.Text.Json;

namespace Entidades.GDA
{
    public class Serializer<T> : GestorDeArchivo, IArchivos<T> where T : class, new()
    {
        public Serializer(ETipo tipo) : base(tipo)
        {
        }

        public void Escribir(string nombreArchivo, T elemento)
        {
            try
            {
                if (tipo == ETipo.XML)
                {
                    if (Path.GetExtension(nombreArchivo) == ".xml")
                    {
                        using (XmlTextWriter xmlTextWriter = new XmlTextWriter($"{rutaBase}\\{nombreArchivo}", Encoding.UTF8))
                        {
                            xmlTextWriter.Formatting = Formatting.Indented;
                            XmlSerializer serializer = new XmlSerializer(typeof(T));
                            serializer.Serialize(xmlTextWriter, elemento);
                        }
                    }
                    else
                    {
                        throw new ArchivoException("Extension invalida, se esperaba XML");
                    }
                }
                else
                {
                    if (Path.GetExtension(nombreArchivo) == ".json")
                    {

                        string json = JsonSerializer.Serialize(elemento, typeof(T));
                        EscribirJSON($"{rutaBase}\\{nombreArchivo}", json);
                    }
                    else
                    {
                        throw new ArchivoException("Extension invalida, se esperaba JSON");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoException("Error al Serializar", ex);
            }
        }

        public T Leer(string nombreArchivo)
        {
            try
            {
                if (tipo == ETipo.XML)
                {
                    if (Path.GetExtension(nombreArchivo) == ".xml")
                    {
                        using (XmlTextReader xmlTextReader = new XmlTextReader($"{rutaBase}\\{nombreArchivo}"))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(T));
                            return serializer.Deserialize(xmlTextReader) as T;
                        }
                    }
                    else
                    {
                        throw new ArchivoException("Extension invalida, se esperaba XML");
                    }
                }
                else
                {
                    if (Path.GetExtension(nombreArchivo) == ".json")
                    {
                        string json = LeerJSON($"{rutaBase}\\{nombreArchivo}");
                        return JsonSerializer.Deserialize<T>(json);
                    }
                    else
                    {
                        throw new ArchivoException("Extension invalida, se esperaba JSON");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoException("Error al DesSerializar", ex);
            }
        }


        private void EscribirJSON(string ruta, string contenido)
        {

            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                streamWriter.WriteLine(contenido);
            }
        }
        private string LeerJSON(string ruta)
        {

            using (StreamReader streamReader = new StreamReader(ruta))
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}
