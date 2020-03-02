namespace Task1.Tests
{
    using System;
    using Task1.Processors;
    using Task1.Processors.CircleArea;
    using Xunit;

    public class CircleAreaProcessorTest
    {
        private readonly ICircleAreaProcessor processor;

        public CircleAreaProcessorTest()
        {
            this.processor = new CircleAreaProcessor();
        }

        [Theory]
        [InlineData(10)]
        public void PassingTest(double radius)
        {
            var expected = Math.PI * radius * radius;
            var result = this.processor.Execute(radius);
            Assert.Equal(expected, result);
        }
    }
}
