using System;

namespace AreaCalculator
{
    public static class Calculator
    {
        public static double GetTriangleArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public static double GetCircleArea(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}
