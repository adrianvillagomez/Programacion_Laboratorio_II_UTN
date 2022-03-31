using System;

namespace LogicaDeNegocio
{
    public class Validador
    {
        /// <summary>
        /// Valida un numero ingresado entre un parametro minimo y uno maximo
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns> true si esta dentro de los parametros establecidos, false si no lo esta</returns>
        public static bool Validar(int valor, int min, int max)//metodo estatico
        {          
            return valor>=min && valor<=max;
        }
    }   
}
