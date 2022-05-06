﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLibreria
{
    public class Biografia : Publicacion
    {
        //public Biografia(string nombre, int stock, float importe) : base(nombre, stock, importe)//A Modificar
        //{
        //}
        //public Biografia(string nombre, int stock) : this(nombre, stock,0)
        //{
        //}
        //public Biografia(string nombre) : this(nombre,0)
        //{
        //}   
        public Biografia(string nombre)
            : base(nombre)
        {
        }

        public Biografia(string nombre, int stock)
            : base(nombre, stock)
        {
        }

        public Biografia(string nombre, int stock, float valor)
            : base(nombre, stock, valor)
        {
        }

        public override bool EsColor
        {
            get
            {
                return false;
            }
        }
        public override bool HayStock
        {
            get
            {
                return stock > 0;
            }
        }
        public static explicit operator Biografia(string nombre)
        {
            return new Biografia(nombre);
        }
    }
}
