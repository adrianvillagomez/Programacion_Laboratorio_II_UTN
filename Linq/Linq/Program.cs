using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Entidades;
namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Linq con ejemplo simple 
            int[] valoresNumnericos = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Numeros Pares");
          
            IEnumerable<int>numerosPares = from numero in valoresNumnericos where numero % 2 == 0 select numero;
            foreach (int item in numerosPares)
            {
                Console.WriteLine(item);
            }
            //Linq con ejemplo de clases
            ControlEmpresasEmpleados main = new ControlEmpresasEmpleados();
            main.GetCeo();
            Console.WriteLine("-----------------------");
            main.GetCantidad();
            Console.WriteLine("-----------------------");
            main.GetEmpleadosOrdenados();
            Console.WriteLine("-----------------------");
            main.GetEmpleadosPildoras();
            Console.WriteLine("-----------------------");
            main.GetEmpledaosEmpresa(1);
        }
    }
}
