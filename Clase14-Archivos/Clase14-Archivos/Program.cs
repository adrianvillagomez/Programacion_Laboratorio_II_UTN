using System;
using System.IO;
using Entidades.GDA;
using Entidades.Models;

namespace Clase14_Archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArchivoTexto archivoTexto = new ArchivoTexto();

            //archivoTexto.Escribir("ejemplo.txt", "Hola");

            //Alumno alumno = new Alumno("Pepe perez", 34, 7.8f);
            //alumno.Materias.Add("Programacion");
            //alumno.Materias.Add("laboratorio");
            //Persona profesor = new Profesor("Ramon", 76, "l0001111");

            //Serializadora.Serializar_XmlTextWriter("profesorSerializadoHerencia.xml",profesor);


            //Console.WriteLine("Ya serialize");




            //Alumno alumno = Serializadora.Deserializar_XmlTextReader("alumnoSerializado2.xml");


            //Console.WriteLine("Ya DesSerialize");

            //Console.WriteLine(alumno.ToString());



            //Empleado emp = new Empleado();
            //emp.Nombre = "Jorge";
            //emp.Apellido = "Lopez";
            //emp.Tareas.Add("Limpiar");
            //emp.Tareas.Add("Cocinar");
            //emp.Tareas.Add("Enseñar");
            //Serializadora.Serializar_JSON("persona.json", emp);

            //Console.WriteLine("Ya Serialize");



            //Empleado empleadoLeido = Serializadora.DesSerializar_JSON("persona.json");

            //Console.WriteLine(empleadoLeido.ToString());


            /*Serializando con GDA*/


            Empleado emp = new Empleado();
            emp.Nombre = "Jorge";
            emp.Apellido = "Lopez";
            emp.Tareas.Add("Limpiar");
            emp.Tareas.Add("Cocinar");
            emp.Tareas.Add("Enseñar");

            Serializer<Empleado> serializer = new Serializer<Empleado>(GestorDeArchivo.ETipo.JSON);
            serializer.Escribir("empleado.json", emp);
            Console.WriteLine("Ya Serialize JSON");




            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Leyendo JSON");
            Empleado empleadoLeido = serializer.Leer("empleado.json");
            Console.WriteLine(empleadoLeido.ToString());

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Leyendo JSON archivo erroneo");
            try
            {
                Empleado empleadoLeido2 = serializer.Leer("empleado.xml");
                Console.WriteLine(empleadoLeido2.ToString());

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);   
                Exception inner = ex.InnerException;
                while(inner != null)
                {
                    Console.WriteLine(inner.Message);
                    inner = inner.InnerException;
                }
            }


        }
    }
}
