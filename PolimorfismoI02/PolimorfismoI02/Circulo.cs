using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoI02
{
    public class Circulo : Figura
    {
        public Circulo(double radio):base(radio)
        {

        }
        public override string Dibujar()
        {
            return $"Dibujando circulo..";
        }
        public override double CalcularSuperficie()
        {
            double area = Math.PI * base.radio;
            return area;
        }
        public override double CalcularPerimetro()
        {
            double areaCirculo = 2 * Math.PI * base.radio;
            return areaCirculo;
        }
    }
}
