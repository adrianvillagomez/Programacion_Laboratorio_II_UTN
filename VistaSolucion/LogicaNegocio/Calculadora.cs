using System;

namespace LogicaNegocio
{
    public class Calculadora
    {
        public static float Calcular(float operandoUno, float operandoDos, char operacion)
        {           
            if (operacion == '+')
            {
                return operandoUno + operandoDos;
            }
            if (operacion == '-')
            {
                return operandoUno - operandoDos;
            }
            if (operacion == '*')
            {
                return operandoUno * operandoDos;
            }
            if (operacion == '/')
            {
                bool respuesta;
                respuesta = Calculadora.Validar(operandoDos);
                if (respuesta == true)
                {
                    return operandoUno / operandoDos;
                }
                else
                {
                    Console.WriteLine("El divisor no puede ser Cero");
                }
            }
            float resultado = 0;
            return resultado;
        }
        private static bool Validar(float operandoDos)
        {
            return operandoDos != 0;
        }
    }
}
