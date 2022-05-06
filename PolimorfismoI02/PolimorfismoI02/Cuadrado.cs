using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoI02
{
    public class Cuadrado : Rectangulo
    {
        public Cuadrado(double xBase,double yAltura):base(xBase,yAltura)
        {

        }
        public override string Dibujar()
        {
            return $"Dibujando Cuadrado..";
        }
        public override double CalcularSuperficie()
        {
            double area = base.yAltura * 2;
            return area;
        }
        public override double CalcularPerimetro()
        {
            return base.CalcularPerimetro();
        }
    }
}
