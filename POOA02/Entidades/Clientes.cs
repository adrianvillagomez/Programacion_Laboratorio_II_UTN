using System;
using System.Text;
namespace Entidades
{
    public class Clientes
    {
        private string domicilio;
        private string nombre;
        private string apellido;
        private int telefono;
        public Mascota mascota;
        public Clientes(string domicilio,string nombre,string apellido,int telefono,Mascota mascota)
        {
            this.domicilio = domicilio;
            this.apellido = apellido;
            this.nombre = nombre;
            this.telefono = telefono;
            this.mascota = mascota;
        }    
        public void SetMascota(Mascota value)
        {
            this.mascota=value;
        }
        public string Mostrar()
        {
            StringBuilder cliente = new StringBuilder();
            cliente.AppendLine($"Domicilio : {this.domicilio}");
            cliente.AppendLine($"Nombre : {this.nombre}");
            cliente.AppendLine($"Apellido : {this.apellido}");
            cliente.AppendLine($"Telefono : {this.telefono}");
            cliente.AppendLine($"Mascota Del Cliente  \n{mascota.MostrarMascota()}");
            Console.WriteLine(cliente.ToString());
            return cliente.ToString();
        }
    }
}
