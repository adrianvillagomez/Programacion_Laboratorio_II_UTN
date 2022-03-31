using System;

namespace LogicaNegocio
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
           return Math.Pow(longitudLado, 2);
        }
        public static double CalcularAreaTriangulo(double baseFigura, double altura)
        {
            return baseFigura * altura/2;
        }
        public static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2) ;
        }
    }
}
