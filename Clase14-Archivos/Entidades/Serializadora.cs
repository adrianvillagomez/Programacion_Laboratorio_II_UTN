using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Entidades.Models;
using System.Text.Json;

namespace Entidades
{
    //CLASE VISTA
    public class Serializadora
    {
        private static string rutaBase;

        static Serializadora()
        {
            DirectoryInfo path = Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Archivos_Serializados\\");
            Serializadora.rutaBase = path.FullName;
        }


        public static void Serializar_StreamWriter(string nombreArchivo,Persona persona)
        {
            using (StreamWriter streamWriter = new StreamWriter($"{Serializadora.rutaBase}{nombreArchivo}"))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Persona));

                xml.Serialize(streamWriter, persona);

            }
        }
        public static void Serializar_XmlTextWriter(string nombreArchivo, Persona persona)
        {

            using (XmlTextWriter xmlTextWriter = new XmlTextWriter($"{Serializadora.rutaBase}{nombreArchivo}", Encoding.UTF8))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                xmlTextWriter.Formatting = Formatting.Indented;
                xml.Serialize(xmlTextWriter, persona);

            }
        }

        public static Persona Deserializar_StreamReader(string nombreArchivo)
        {
            using(StreamReader streamReader = new StreamReader($"{Serializadora.rutaBase}{nombreArchivo}"))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                Persona persona = xml.Deserialize(streamReader) as Persona;
                return persona;
            }

        }
        public static Persona Deserializar_XmlTextReader(string nombreArchivo)
        {
            using (XmlTextReader xmlTextReader = new XmlTextReader($"{Serializadora.rutaBase}{nombreArchivo}"))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                Persona persona = xml.Deserialize(xmlTextReader) as Persona;
                return persona;
            }

        }

        public static void Serializar_JSON(string nombreArchivo, Empleado empleado)
        {
            using(StreamWriter streamWriter = new StreamWriter($"{Serializadora.rutaBase}{nombreArchivo}"))
            {
                
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;
                string ser = JsonSerializer.Serialize(empleado,options);
                streamWriter.WriteLine(ser);
            }
        }

        public static Empleado DesSerializar_JSON(string nombreArchivo)
        {
            using (StreamReader streamReader = new StreamReader($"{Serializadora.rutaBase}{nombreArchivo}"))
            {
                string json = streamReader.ReadToEnd();
                return JsonSerializer.Deserialize<Empleado>(json);
            }
        }
    }
}
