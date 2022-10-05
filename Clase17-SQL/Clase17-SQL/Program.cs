using System;
using System.Collections.Generic;
using Entidades;

namespace Clase17_SQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //List<Persona> personas = GestorSQL.LeerDatos();

                //foreach (Persona item in personas)
                //{
                //    Console.WriteLine(item.ToString());
                //    Console.ReadKey();
                //}

                Persona nuevaP = new Persona("Franco", "email@mail.com.ar", "Messina", "Male", 40);

                GestorSQL.Alta(nuevaP);

                //Persona p = GestorSQL.LeerDatosPorId(1);
                //Console.WriteLine(p.ToString());

                //Persona p = new Persona("Franco", "email@mail.com.ar", "Messina", "Male", 40);
                //GestorSQL.Actualizar(p, 2);
                //Console.WriteLine("Ya Actualice");

                //GestorSQL.Borrar(1);
                //Console.WriteLine("Ya borre");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
