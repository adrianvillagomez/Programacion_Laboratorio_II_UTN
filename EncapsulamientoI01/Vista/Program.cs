using System;
using EncapsulamientoI01;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente(1, "Lautaro");
            Cliente c2 = new Cliente(2, "Mauricio");
            Cliente c3 = new Cliente(3, "Esteban");
            Negocio n1 = new Negocio("Kiosco-24");

            if (c1+n1)
            {
                Console.WriteLine("Se agrego c1 a la cola");
            }

            if (!(c1 + n1))
            {
                Console.WriteLine("Cliente c1 ya esta en la cola");
            }

            if (c2+n1)
            {
                Console.WriteLine("Se agrego c2 a la cola");
            }

            if (c3+n1)
            {
                Console.WriteLine("Se agrego c3 a la cola");
            }

            Console.WriteLine("Clientes pendientes: {0}", n1.ClientesPendientes);

            while (~n1)
            {
                Console.WriteLine("Clientes pendientes: {0}", n1.ClientesPendientes);
            }


        }
    }
}
