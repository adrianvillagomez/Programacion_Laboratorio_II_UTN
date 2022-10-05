using System;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public delegate void NotificarCambioHandler(Reloj sender);

    public class Reloj
    {
        private int hora;
        private int minutos;
        private int segundos;

        public int Hora { get => hora; set => hora = value; }
        public int Minutos { get => minutos; set => minutos = value; }
        public int Segundos { get => segundos; set => segundos = value; }

        public event NotificarCambioHandler OnNotificarCambio;

        public void Iniciar()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    DateTime dt = DateTime.Now;
                    Thread.Sleep(100);

                    if (dt.Second != this.segundos)
                    {
                        if (OnNotificarCambio is not null)
                        {
                            this.OnNotificarCambio.Invoke(this);
                        }
                    }
                    hora = dt.Hour;
                    minutos = dt.Minute;
                    segundos = dt.Second;

                }
            });
        }
        public override string ToString()
        {
            return $"{Hora} : {Minutos} : {Segundos}";
        }
    }
}
