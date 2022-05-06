using System;
using System.Collections.Generic;
namespace Libro
{
    public class Librito
    {
        List<string> lista;
        public Librito()
        {
            lista = new List<string>();
        }
        public string this [int index]
        {
            get
            {
                if(index < lista.Count && index >=0)
                {
                    return lista[index];
                }else
                {
                    return string.Empty;
                }               
            }
            set
            {
                if (index > lista.Count)
                {
                    lista.Add(value);
                }else if(index>=0)
                {
                    lista.Insert(index, value);
                }
            }
        }
    }
}
