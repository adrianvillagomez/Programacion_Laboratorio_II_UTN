using System;
using System.Text;
namespace ParcialLibreria
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;
        //protected Publicacion(string nombre, int stock, float importe)
        //{
        //    this.nombre = nombre;
        //    this.stock = stock;
        //    this.importe = importe;
        //}
        //protected Publicacion(string nombre, int stock) : this(nombre, stock, 0)
        //{
        //}
        //protected Publicacion(string nombre):this(nombre,0)                 //Pendiente Modificiacion
        //{
        //}      
        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        public Publicacion(string nombre, int stock)
            : this(nombre)
        {
            Stock = stock;
        }

        public Publicacion(string nombre, int stock, float importe)
            : this(nombre, stock)
        {
            this.importe = importe;
        }
        public abstract bool EsColor { get; }
        public virtual bool HayStock
        {
            get
            {
                return stock > 0 && importe > 0;//Modificado
            }
        }
        public int Stock
        {
            get { return stock; }
            set
            {
                if(value > 0)
                {
                    this.stock=value;
                }
            }
        }
        public float Importe
        {
            get { return importe; }
        }
        public override string ToString()
        {
            return this.nombre;
        }
        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre {ToString()}");// a modificar
            sb.AppendLine($"Stock : {this.Stock}");
            sb.AppendLine($"Es Color : {this.EsColor}");
            sb.AppendLine($"Valor : {this.Importe}");
            return sb.ToString();
        }
    }
}
