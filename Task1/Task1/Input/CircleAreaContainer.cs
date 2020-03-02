namespace Task1.Inputs
{
    using System;
    using System.Collections.Generic;
    using Task1.Processors.CircleArea;

    public class CircleAreaContainer : IContainer<double>
    {
        private readonly ICircleAreaProcessor processor;

        public string Title => "Circle Area Calculation";

        public string[] Arguments { get; }

        public IDictionary<string, double> ArgumentValues { get; }

        public CircleAreaContainer(ICircleAreaProcessor processor)
        {
            this.processor = processor;
            this.Arguments = new[] { "Radius" };
            this.ArgumentValues = new Dictionary<string, double>();
        }

        
        public void Execute()
        {
            var radius = this.ArgumentValues["Radius"];
            var result = this.processor.Execute(radius);
            Console.WriteLine(result);

            this.ArgumentValues.Clear();
        }

        public void Prepare()
        {
            foreach (var key in this.Arguments)
            {
                Console.WriteLine($"Enter {key}:");

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
                            Console.WriteLine($"Radius should be more than 0");
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
