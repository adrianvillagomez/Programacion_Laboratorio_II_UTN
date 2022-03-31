using System;
using Entidades;
namespace POOSemana2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*CONSTRUCTO POR DEFECTO
             * 
            Mascotas perro = new Mascotas();
            perro.raza = "cooker";
            perro.edad = 4;
            perro.nombre = "perrito malvado";
            perro.especie = "perro";

            Mascotas gato = new Mascotas();
            gato.raza = "persa";
            gato.edad = 5;
            gato.nombre = "bola de nieve";
            gato.especie = "gato";
            Console.WriteLine(gato.Saludar());
            */

            //Constructor Implicito de estancia
            Mascotas gato = new Mascotas("bola de nieve", "persia", 4);
   
            Console.WriteLine($"{gato.Saludar()} y mi hambre es {gato.hambre}");
            Mascotas.Alimentar(gato);          
        }
    }
}
