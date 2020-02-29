namespace Task1.Inputs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Task1.Processors.PolygonArea;

    public class PolygonAreaContainer : IContainer<double>
    {
        private int pointsCount = 0;

        private readonly IPolygonAreaProcessor processor;

        public string Title => "Polygon Area Calculation";

        public string[] Arguments { get; }

        public IDictionary<string, double> ArgumentValues { get; }

        public PolygonAreaContainer(IPolygonAreaProcessor processor)
        {
            this.processor = processor;
            this.ArgumentValues = new Dictionary<string, double>();
        }
        
        public void Execute()
        {
            var values = this.ArgumentValues.Values.ToList();
            var x = values.Where((v, i) => i % 2 != 0).ToArray();
            var y = values.Where((v, i) => i % 2 == 0).ToArray();
            var result = this.processor.Execute(x, y);
            Console.WriteLine(result);

            this.ArgumentValues.Clear();
        }

        public void Prepare()
        {
            Console.WriteLine($"Enter points number:");

            var validArgument = false;
            while (!validArgument)
            {
                if (int.TryParse(Console.ReadLine(), out var input))
                {
                    if (input > 2)
                    {
                        this.pointsCount = input;
                        validArgument = true;
                    }
                    else
                    {
                        Console.WriteLine($"Number should be more than 2");
                    }
                }
                else
                {
                    Console.WriteLine("Cannot parse input value");
                }
            }

            for (var i = 0; i < this.pointsCount; i++)
            {
                Console.WriteLine($"Enter point {i + 1} X-coordinate:");

                validArgument = false;
                while (!validArgument)
                {
                    if (double.TryParse(Console.ReadLine(), out var input))
                    {  
                        this.ArgumentValues[$"X{i}"] = input;
                        validArgument = true;
                    }
                    else
                    {
                        Console.WriteLine("Cannot parse input value");
                    }
                }

                Console.WriteLine($"Enter point {i + 1} Y-coordinate:");

                validArgument = false;
                while (!validArgument)
                {
                    if (double.TryParse(Console.ReadLine(), out var input))
                    {
                        this.ArgumentValues[$"Y{i}"] = input;
                        validArgument = true;
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
