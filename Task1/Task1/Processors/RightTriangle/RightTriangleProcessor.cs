namespace Task1.Processors
{
    using System;
    using Task1.Processors.RightTriangle;

    public class RightTriangleProcessor : IRightTriangleProcessor
    {
        private const double eps = 1e-5;

        /// <summary>
        /// Right triangle determination
        /// </summary>
        /// <param name="a">First side length</param>
        /// <param name="b">Second side length</param>
        /// <param name="c">Third side length</param>
        /// <returns></returns>
        public bool Execute(double a, double b, double c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                return false;
            }

            var hypotenuse = a;
            var cathet1 = b;
            var cathet2 = c;

            if (b > a && b > c)
            {
                hypotenuse = b;
                cathet1 = a;
            }
            else if (c > a && c > b)
            {
                hypotenuse = c;
                cathet2 = a;
            }

            return Math.Abs(hypotenuse * hypotenuse - (cathet1 * cathet1 + cathet2 * cathet2)) <= eps;
        }
    }
}
