using System;
using System.Collections;

namespace Entidades
{ 
    public class Empresa 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
       public void getDatosEMpresa()
        {
            Console.WriteLine("Empresa {0} con id {1}", Nombre, Id);
        }
    }

}
