using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoI02
{
    public class Rectangulo : Figura
    {
        public Rectangulo(double xBase,double yAltura):base(xBase,yAltura)
        {

        }
        public override string Dibujar()
        {
            return $"Dibujando rectangulo..";
        }
        public override double CalcularSuperficie()
        {
            double area = base.xBase * base.yAltura;
            return area;
        }
        public override double CalcularPerimetro()
        {
            double perimetro = base.xBase + base.yAltura+ base.xBase + base.yAltura;
            return perimetro;
        }
    }
}
