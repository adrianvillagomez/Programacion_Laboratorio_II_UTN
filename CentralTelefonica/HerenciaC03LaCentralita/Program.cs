using System;
using Centralita;
namespace HerenciaC03LaCentralita
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            CentralitaClass c = new CentralitaClass("Fede Center");

            Local l1 = new Local("Bernal", "Rosario",5, 5);
            //Console.WriteLine(l1.Mostrar());
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", "San Rafael",3, 2);
            Provincial l4 = new Provincial("Boedo", Provincial.Franja.Franja_1, 10, "Caseros");
            //Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            c.Llamadas.Add(l1);
           // Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l2);
            //Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l3);
            //Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l4);

            c.OrdenarLlamadas();
            Console.WriteLine(c.Mostrar());
                      


        }
    }
}
