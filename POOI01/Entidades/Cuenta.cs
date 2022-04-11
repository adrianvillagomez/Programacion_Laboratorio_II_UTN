using System;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;
        public Cuenta (string titular,decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string GetTitular()
        {
            return this.titular;
        }
        public decimal GetCantidad()
        {
            return this.cantidad;
        }
        public string Mostrar()
        {
            return $"Titular {this.titular} Cantidad {this.cantidad}";
        }
        public decimal Ingresar(decimal monto)
        {
            decimal retorno = 0;
            if(monto < 0)
            {               
                Console.WriteLine("Error el monto no puede ser negativo");
                return retorno;

            }else
            {
                return this.cantidad += monto;
            }
        }
        public decimal Retirar(decimal monto)
        {
           return this.cantidad -= monto;
        }
    }
}
