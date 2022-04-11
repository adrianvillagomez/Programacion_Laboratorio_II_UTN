using System;

namespace Entidades
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;
        public Boligrafo(short tinta,ConsoleColor color )
        {
            this.tinta = tinta;
            this.color = color;
            Console.ForegroundColor =color;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta(short tinta)
        {
            //short tintaDisponible = GetTinta();
            if (this.tinta>= 0 && this.tinta<= cantidadTintaMaxima)
            {               
                    this.tinta = tinta;
                /*else
                {
                    this.tinta -= tinta;
                }*/
            }else
            {
                Console.WriteLine("No se realiza ninguna accion");
            }
        }
        public  void Recargar()
        {
            this.tinta = Boligrafo.cantidadTintaMaxima;
        }
        public bool Pintar(short gasto,out string dibujo)
        {
            //short tintaDisponible = GetTinta();
            dibujo = "";
            if (this.tinta == 0)
            {               
                return false;                
            }
            for (int i = 0; i < gasto; i++)
            {
                if (this.tinta == 0)
                {
                    break;
                }
                dibujo += "*";
                this.tinta--;
            }
            SetTinta(this.tinta);
            return true;
        }
    }
}
