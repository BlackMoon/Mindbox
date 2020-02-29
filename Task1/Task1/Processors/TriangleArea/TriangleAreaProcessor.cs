namespace Task1.Processors
{
    using System;
    using Task1.Processors.TriangleArea;

    public class TriangleAreaProcessor : ITriangleAreaProcessor
    {
        /// <summary>
        /// Heron's formula implementation
        /// </summary>
        /// <param name="a">First side length</param>
        /// <param name="b">Second side length</param>
        /// <param name="c">Third side length</param>
        /// <returns></returns>
        public double Execute(double a, double b, double c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                return 0;
            }

            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
