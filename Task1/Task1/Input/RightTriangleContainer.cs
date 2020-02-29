namespace Task1.Input
{
    using System;
    using System.Collections.Generic;
    using Task1.Inputs;
    using Task1.Processors.RightTriangle;

    public class RightTriangleContainer : IContainer<double>
    {
        private readonly IRightTriangleProcessor processor;

        public string Title => "Definition of a Right Triangle";

        public string[] Arguments { get; }

        public IDictionary<string, double> ArgumentValues { get; }

        public RightTriangleContainer(IRightTriangleProcessor processor)
        {
            this.processor = processor;
            this.Arguments = new[] { "A", "B", "C" };
            this.ArgumentValues = new Dictionary<string, double>();
        }

        public void Execute()
        {
            var a = this.ArgumentValues["A"];
            var b = this.ArgumentValues["B"];
            var c = this.ArgumentValues["C"];
            var result = this.processor.Execute(a, b, c);
            Console.WriteLine(result);

            this.ArgumentValues.Clear();
        }

        public void Prepare()
        {
            foreach (var key in this.Arguments)
            {
                Console.WriteLine($"Enter side {key} length:");

                var validArgument = false;
                while (!validArgument)
                {
                    if (double.TryParse(Console.ReadLine(), out var input))
                    {
                        if (input > 0)
                        {
                            this.ArgumentValues[key] = input;
                            validArgument = true;
                        }
                        else
                        {
                            Console.WriteLine($"Length should be more than 0");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Cannot parse input value");
                    }
                }
            }
        }
    }
}
