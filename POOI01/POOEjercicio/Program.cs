using System;
using Entidades;
namespace POOEjercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuentaUno = new Cuenta("CocaCola", 100);
            Console.WriteLine(cuentaUno.Mostrar());

            cuentaUno.Ingresar(100);
            Console.WriteLine(cuentaUno.Mostrar());

            cuentaUno.Retirar(100);
            Console.WriteLine(cuentaUno.Mostrar());
        }
    }
}
