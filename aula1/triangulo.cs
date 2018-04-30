using System;

namespace curso
{
    class triangulo
    {
        public double a, b, c, p;

        public double Area()
        {
            p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        }
    }
}