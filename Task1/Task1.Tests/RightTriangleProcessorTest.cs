namespace Task1.Tests
{
    using System;
    using Task1.Processors;
    using Task1.Processors.TriangleArea;
    using Xunit;

    public class TriangleAreaProcessorTest
    {
        private readonly ITriangleAreaProcessor processor;

        public TriangleAreaProcessorTest()
        {
            this.processor = new TriangleAreaProcessor();
        }

        [Theory]
        [InlineData(3, 4, 5)]
        public void PassingTest(double a, double b, double c)
        {
            var p = (a + b + c) / 2;
            var expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            var result = this.processor.Execute(a, b, c);
            Assert.Equal(expected, result);
        }
    }
}
