using System;
using System.Collections.Generic;
using System.Linq;
namespace EjemploPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array Bidimensionales
            string[,] personas = new string[3, 2];

            personas[0, 0] = "Ale";
            personas[0, 1] = "123456";
            personas[1, 0] = "diego";
            personas[1, 1] = "456789";

            int[,] numeros = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine($"Cantidad de dimensiones {personas.Rank}");

            Console.WriteLine($"Length {personas.Length}");

            for (int i = 0; i < personas.GetLength(0); i++)
            {
                Console.WriteLine($"Nombre {personas[i, 0]} DNI: {personas[i, 1]}");
            }
            #endregion
            #region List

            List<string> listaDeNombres = new List<string>();

            listaDeNombres.Add("Romeo");
            listaDeNombres.Add("Julieta");
            listaDeNombres.Add("Arturo");
            listaDeNombres.Add("Pepe");
            Console.WriteLine($"Tamaño de la lista { listaDeNombres.Count}");

            listaDeNombres.Insert(1, "Ale");

            listaDeNombres[3] = "Diego";

            foreach (string item in listaDeNombres)
            {
                Console.WriteLine(item);
            }

            listaDeNombres.Remove("Julieta");

            Console.WriteLine("Lista depues de borrar");

            int index = listaDeNombres.IndexOf("Ale");

            listaDeNombres.RemoveAt(index);

            foreach (string item in listaDeNombres)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Diccionario
            Dictionary<string, int> agenda = new Dictionary<string, int>();

            agenda.Add("Ale Bongio", 12345665);
            agenda.Add("Diego P", 456138);
            agenda.Add("Esteban P", 456138);          


            Console.WriteLine("Valor maximo");

            Console.WriteLine(agenda.Values.Max());


            Console.WriteLine("--------------------");
            Console.WriteLine("recorro solo la key");

            foreach (string nombre in agenda.Keys)
            {
                Console.WriteLine(nombre);
            }


            Console.WriteLine("recorro solo el value");

            foreach (int numero in agenda.Values)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Diccionario completo");

            foreach (KeyValuePair<string, int> contacto in agenda)
            {
                Console.WriteLine($"La clave es: {contacto.Key} y su valor es: {contacto.Value}");
            }

            if (agenda.ContainsKey("Ale Bongio"))
            {
                Console.WriteLine("Contiene Ale Bongio");
            }

            if (agenda.ContainsValue(1))
            {

            }
            else
            {
                Console.WriteLine("No contiene el valor");
            }

            Console.WriteLine(agenda["Ale Bongio"]);

            #endregion
            #region Cola

            Queue<string> colaDeAtencion = new Queue<string>();

            //Agregar elemento al final
            colaDeAtencion.Enqueue("Juan Perez");
            colaDeAtencion.Enqueue("Fede Davila");
            colaDeAtencion.Enqueue("Mauricio Davila");

            foreach (string cliente in colaDeAtencion)
            {
                Console.WriteLine(cliente);
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("Elimino un elemento");

            Console.WriteLine("Elimino a:");
            Console.WriteLine(colaDeAtencion.Dequeue());
            Console.WriteLine("-----------------------");
            foreach (string cliente in colaDeAtencion)
            {
                Console.WriteLine(cliente);
            }

            Console.WriteLine("-----------");

            Console.WriteLine("Proximo por ser atendido");

            Console.WriteLine(colaDeAtencion.Peek());

            Console.WriteLine("lista de espera");

            foreach (string cliente in colaDeAtencion)
            {
                Console.WriteLine(cliente);
            }

            Console.WriteLine($"Cantidad de clientes en espera {colaDeAtencion.Count}");
            #endregion
            #region Pila
            Stack<char> letras = new Stack<char>();

            letras.Push('H');
            letras.Push('O');
            letras.Push('L');
            letras.Push('A');

            foreach (char c in letras)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("----Devuelve el siguiente sin eliminar -----");

            Console.WriteLine(letras.Peek());

            Console.WriteLine("--------------");
            foreach (char c in letras)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("-------elimino el elemento LIFO----");

            Console.WriteLine(letras.Pop());

            Console.WriteLine("----------------------");

            foreach (char c in letras)
            {
                Console.WriteLine(c);
            }
            #endregion

            #region SortedList
            SortedList<string, string> profesores = new SortedList<string, string>();
            profesores.Add("Ale", "Programacion II");
            profesores.Add("Villegas", "Programacion I");
            profesores.Add("Baus", "Labo IV");

            foreach (KeyValuePair<string, string> prof in profesores)
            {
                Console.WriteLine($"Profesor: {prof.Key} Materia: {prof.Value}");
            }
            #endregion

        }
    }
}
