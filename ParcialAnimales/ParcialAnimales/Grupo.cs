using System;
using System.Collections.Generic;
using System.Text;
namespace ParcialAnimales
{
    public enum TipoManada
    {
        Unica,Mixta
    }
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private static TipoManada tipo;
        static Grupo() 
        {
            tipo = TipoManada.Unica;
        }  
        public Grupo(string nombre,TipoManada tipos):this()
        {
            this.nombre = nombre;
            tipo = tipos;
        }
        private Grupo()
        {
            this.manada = new List<Mascota>();
        }
        public Grupo(string nombre):this(nombre,TipoManada.Unica)
        {
        }
        public TipoManada Tipo
        {
            set
            {
                tipo = value;
            }
        }
        public static bool operator ==(Grupo e ,Mascota j)
        {
            foreach(Mascota m in e.manada)
            {
                if(m==j)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }
        public static bool operator +(Grupo e, Mascota j)
        {
            if(e!=j)
            {
                e.manada.Add(j);
                return true;
            }
            return false;
        }
        public static bool operator -(Grupo e, Mascota j)
        {
            if(e==j)
            {
                e.manada.Remove(j);
                return true;
            }
            return false;
        }
        public static implicit operator string(Grupo e)
        {
            //foreach(Mascota m in e.manada)
            //{
            //    if(m is Perro)
            //    {
            //        ((Perro)m).ToString();
            //    }
            //}
            //return e.manada.ToString();
            StringBuilder data = new StringBuilder();
            data.Append($"**{e.nombre} {Grupo.tipo}**\n");
            data.Append("Integrantes:\n");
            foreach (Mascota m in e.manada)
            {
                data.Append(m.ToString());
            }

            return data.ToString();
        }

    }
}
