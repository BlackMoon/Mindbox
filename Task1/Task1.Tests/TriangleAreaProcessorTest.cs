namespace Task1.Tests
{
    using Task1.Processors;
    using Task1.Processors.RightTriangle;
    using Xunit;

    public class RightTriangleProcessorTest
    {

        private readonly IRightTriangleProcessor processor;

        public RightTriangleProcessorTest()
        {
            this.processor = new RightTriangleProcessor();
        }

        [Theory]
        [InlineData(3, 4, 5)]
        public void PassingTest(double a, double b, double c)
        {  
            var result = this.processor.Execute(a, b, c);
            Assert.True(result);
        }

        [Theory]
        [InlineData(3, 4, 6)]
        public void FailingTest(double a, double b, double c)
        {
            var result = this.processor.Execute(a, b, c);
            Assert.False(result);
        }
    }
}
