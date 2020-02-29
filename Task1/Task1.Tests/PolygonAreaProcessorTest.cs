namespace Task1.Tests
{
    using Task1.Processors;
    using Task1.Processors.PolygonArea;
    using Xunit;

    public class PolygonAreaProcessorTest
    {
        private readonly IPolygonAreaProcessor processor;

        public PolygonAreaProcessorTest()
        {
            this.processor = new PolygonAreaProcessor();
        }

        [Fact]
        public void PassingTest1()
        {
            var x = new double[] { 0, 0, 1 };
            var y = new double[] { 0, 1, 1 };

            var result = this.processor.Execute(x, y);
            Assert.Equal(0.5f, result);
        }

        [Fact]
        public void PassingTest2()
        {
            var x = new double[] { 0, 0, 1, 1 };
            var y = new double[] { 0, 1, 1, 0 };

            var result = this.processor.Execute(x, y);
            Assert.Equal(1f, result);
        }
    }
}
