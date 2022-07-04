using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public static class Checker
    {
        public static bool CheckTriangleIsRight(double a, double b, double c)
        {
            // По теореме Пифагора, стороны можно перечислить в любом порядке (погрешность 0.01).
            double aa, bb, cc;
            aa = Math.Round(a * a,3);
            bb = Math.Round(b * b,3);
            cc = Math.Round(c * c,3);
            double e = 0.01;
            return Math.Abs(aa - (bb + cc)) < e || Math.Abs(bb - (aa + cc)) < e || Math.Abs(cc - (bb + aa)) < e;
        }
    }
}
