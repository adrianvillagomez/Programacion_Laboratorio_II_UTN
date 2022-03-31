using System;
//Proyecto de biblioteca de clase - agrupa funcionalidades
//contiene metodos y atributos
//funcionens == metodos
namespace LogicaNegocio
{
    public class ConversorDeTemperatura// si la clase lleva static todo lo que contenga tiene que ser static
    {
        /// <summary>
        /// convierte temperatura celsius a kelvin
        /// </summary>
        /// 
        private const float ceroAbsoluto = 273.15f;//las constantes son tratadas como static- los provates solo dentro de la misma clase
        public static string texto = "hola mundo";
        public static float ConvertirCelsiusAKelvin(float temperaturaEnCelsius)// esta funcion es un metodo
        {
            return temperaturaEnCelsius + ConversorDeTemperatura.ceroAbsoluto;
        }
        public static float ConvertirKelvinACelsius(float temperaturaEnKelvin)
        {
            return temperaturaEnKelvin - ConversorDeTemperatura.ceroAbsoluto;
        }
    }
}
