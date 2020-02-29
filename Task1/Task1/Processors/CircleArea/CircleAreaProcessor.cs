namespace Task1.Processors
{
    using System;
    using Task1.Processors.CircleArea;

    public class CircleAreaProcessor : ICircleAreaProcessor
    {
        /// <summary>
        /// Area of circle
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public double Execute(double radius)
        {
            return radius > 0 ? Math.PI * radius * radius : 0;
        }
    }
}
