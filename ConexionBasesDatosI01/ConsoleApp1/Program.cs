using System;
using System.Collections.Generic;
using ConexionBasesDatosI01;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Probar guardar un dato a la  base de datos
            //Persona p1 = new Persona("adrian", "villagomez");
            //PersonaDAO.Guardar(p1);
            //Console.WriteLine("ya guarde");

            //Leer mi lista de personas desde mi base de datos
            List<Persona> listaPersonas = PersonaDAO.Leer();
            foreach (Persona item in listaPersonas)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("----------------------------");
            //Leer una Persona de mi base de datos filtrando por id
            Persona personaLeida = PersonaDAO.LeerPorId(2);
            Console.WriteLine(personaLeida.ToString());
            Console.WriteLine("----------------------------");
            //Modificar una persona de mi base de datos
            Persona personaNueva = new Persona(2,"Lucas", "Portela");
            PersonaDAO.Actualizar(personaNueva,2);
            Console.WriteLine(personaNueva.ToString());
            Console.WriteLine("----------------------------");
            //Borra una Persona de mi base de datos
            PersonaDAO.Borrar(3);
            Console.WriteLine("Persona Eliminada");

        }
    }
}
