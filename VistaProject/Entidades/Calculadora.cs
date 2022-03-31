using System;

namespace Entidades
{
    public static class Calculadora
    {
        //Sobrecarga de metodos
        public static int Sumar(int value1, int value2)
        {
            return Sumar(value1 , value2,0);
        }
        public static int Sumar(int value1, int value2, int value3)
        {
            return value1 + value2+ value3;
        }

    }
    class Validadora
    {
        public static bool ValidarRango(int value,int max)
        {
            return value <= 0;
        }
        public static bool ValidarRango(int value,int min,int max)
        {
            return value >= min && value <= max;
        }
    }
}
