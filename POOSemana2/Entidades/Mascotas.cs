using System;

namespace Entidades
{
    public class Mascotas
    {
        //Atributos
        public string nombre;
        public string raza;
        public int edad;
        public string especie;
        public bool hambre;
        //Constructor explicito de estancia
        public Mascotas (string nombre,string especie,int edad)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.edad = edad;
        }
        //metodo de instancia.de la clase
        public string Saludar()
        {
            return $"Hola mi nombre es {this.nombre} soy un {this.especie}";
        }
        //metodo estatico metodo de la clase/uso de ellos mediante la clase ejem "Console.[]"
        public  static void Alimentar (Mascotas mascota)
        {
            if(!mascota.hambre)
            {
                mascota.hambre = false;
            }
        }
    }
}
