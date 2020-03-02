namespace Task1.Processors
{
    using System;
    using Task1.Processors.PolygonArea;

    public class PolygonAreaProcessor : IPolygonAreaProcessor
    {
        /// <summary>
        /// Polygon Area. Gauss's formula implementation
        /// </summary>
        /// <param name="x">Array of x coordinates</param>
        /// <param name="y">Array of y coordinates</param>
        /// <returns></returns>
        public double Execute(double[] x, double [] y)
        {
            var n = x.Length;
            double s = 0;

            // polygon should have 3 or more points
            if (n < 3)
            {
                return s;
            }

            int i;
            for (i = 0; i < n - 1; i++)
            {
                s += x[i] * y[i + 1] - y[i] * x[i + 1];
            }
            s += x[i] * y[0] - y[i] * x[0];

            return Math.Abs(s / 2);
        }
    }
}
