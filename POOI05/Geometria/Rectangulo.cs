using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        Punto vertice1;
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;
        public float area;
        public float perimetro;
        public float lado;
        
        public Rectangulo(Punto vertice1,Punto vertice3)
        {
            float h;
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.lado = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
            h=Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
            this.perimetro = lado * 2 + h * 2;
            this.area = lado * h;
        }
        public float GetArea()
        {
            return this.area;
        }
        public float GetPerimetro()
        {
            return this.perimetro;
        }
    }
}
