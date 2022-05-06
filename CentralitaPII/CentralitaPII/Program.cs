using System;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPII
{
    public class Program
    {
        static void Main(string[] args)
        {
            CentralitaII c = new CentralitaII("Fede Center");

            Local l1 = new Local("Bernal", "Rosario", 5, 5);
            //Console.WriteLine(l1.Mostrar());
            Provincial l2 = new Provincial("Morón",Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", "San Rafael", 3, 2);
            Provincial l4 = new Provincial("Boedo",Franja.Franja_1, 10, "Caseros");
            //Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            //c += l1;
            c.Llamadas.Add(l1);
            //Console.WriteLine(c.ToString());
            c +=l2;
            //Console.WriteLine(c.Mostrar());
            c += l3;
            //Console.WriteLine(c.Mostrar());
            c += l4;

           c.OrdenarLlamadas();
           Console.WriteLine(c.ToString());
        }
    }
}
