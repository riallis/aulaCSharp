using System;

namespace curso
{   
    class calculaArea
    {
        double p, area;

        public double Area(double x1, double x2, double x3)
        {
            p = (x1 + x2 + x3) / 2;
            area = Math.Sqrt(p * (p - x1) * (p - x2) * (p - x3));
            return area;
        }
    }
    
}