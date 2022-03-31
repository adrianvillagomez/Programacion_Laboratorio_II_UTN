using System;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular,decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;   
        }
        public string GetTitular ()
        {
            return this.titular;
        }
        public void SetTitular(string value)
        {
            this.titular=value;
        }
        public decimal GetCantidad()
        {
            return this.cantidad;
        }

    }
}
