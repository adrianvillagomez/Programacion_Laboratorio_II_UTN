using System;

namespace PolimorfismoI02
{
    public abstract class Figura
    {
        public double xBase;
        public double yAltura;
        public double radio;
        public Figura(double Base,double altura)
        {
            this.xBase = Base;
            this.yAltura = altura;
        }
        public Figura(double radio):this(0,0)
        {
            this.radio = radio;
        }
        public abstract string Dibujar();
        public abstract double CalcularSuperficie();
        public abstract double CalcularPerimetro();

    }
}
