using System;

namespace CircleAndTriangle
{
    public static class Areas
    {
        public static double Shape(double a, double b=0, double c=0)
        {
            if (c == 0 && b == 0) {
                return CircleArea(a);
            }
            return TriangleArea(a, b, c);
        }

        public static double CircleArea(double radius) {
            return Math.PI * radius * radius;
        }
        public static double TriangleArea(double a, double b, double c)
        {
            (double, double) tuple = RectangularTriangle(a, b, c);
            if (tuple.Item1 != 0)
                return tuple.Item1 * tuple.Item2 / 2;

            double perimetr = (a + b + c)/2;
            return Math.Sqrt(perimetr * (perimetr - a) * (perimetr - b) * (perimetr - c));
        }
        private static  (double, double) RectangularTriangle(double a, double b, double c) {
            // If triangle is rectangular, we return its cathets.
            if (a * a + b * b == c * c)
                return (a, b);
            else if (a * a + c * c == b * b)
                return (a, c);
            else if (b * b + c * c == a * a)
                return (b, c);
            return (0, 0);
        }
    }
}
