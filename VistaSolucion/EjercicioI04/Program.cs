using System;
using LogicaNegocio;
namespace EjercicioI04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EjercicioI04";
            string respuesta;
            do
            {
                string numeroUno;
                float primerOperando;
                string numeroDos;
                float segundoOperando;
                string operando;
                char operacion;
                float resultado;
                Console.WriteLine("Ingrese el Primer Operando");
                numeroUno = Console.ReadLine();
                float.TryParse(numeroUno, out primerOperando);

                Console.WriteLine("Ingrese el Segundo Operando");
                numeroDos = Console.ReadLine();
                float.TryParse(numeroDos, out segundoOperando);

                Console.WriteLine("Ingrese el operando a realizar('+','-','*','/')");
                operando = Console.ReadLine();
                char.TryParse(operando, out operacion);

                resultado = Calculadora.Calcular(primerOperando, segundoOperando, operacion);
                Console.WriteLine("El resultado de la Operacion es : {0}", resultado);

                Console.WriteLine("Desea Continuar?");
                respuesta = Console.ReadLine();
            } while (respuesta == "si");
        }
    }
}
