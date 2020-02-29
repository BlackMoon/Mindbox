namespace Task1
{
    using System;
    using System.Linq;
    using Microsoft.Extensions.DependencyInjection;
    using Task1.Input;
    using Task1.Inputs;
    using Task1.Processors;
    using Task1.Processors.CircleArea;
    using Task1.Processors.PolygonArea;
    using Task1.Processors.RightTriangle;
    using Task1.Processors.TriangleArea;

    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection()
                .AddTransient<IContainer, CircleAreaContainer>()
                .AddTransient<IContainer, PolygonAreaContainer>()
                .AddTransient<IContainer, RightTriangleContainer>()
                .AddTransient<IContainer, TriangleAreaContainer>()
                .AddTransient<ICircleAreaProcessor, CircleAreaProcessor>()
                .AddTransient<ITriangleAreaProcessor, TriangleAreaProcessor>()
                .AddTransient<IPolygonAreaProcessor, PolygonAreaProcessor>()
                .AddTransient<IRightTriangleProcessor, RightTriangleProcessor>()
                .BuildServiceProvider();
            
            var containers = services.GetServices<IContainer>().ToArray();
            var n = containers.Length;

            string answer = "y";
            while (answer.ToLower() == "y")
            {
                Console.Clear();
                Console.WriteLine($"Choose operation: 1 - {n}");
                for (var i = 0; i < n; i++)
                {
                    Console.WriteLine($"{i + 1}: {containers[i].Title}");
                }

                var ix = 0;
                var validArgument = false;
                while (!validArgument)
                {
                    if (int.TryParse(Console.ReadLine(), out ix))
                    {
                        if (ix > 0 && ix <= n)
                        {
                            validArgument = true;
                            
                        }
                        else
                        {
                            Console.WriteLine($"Index should be more or equal than 1 and less or equal than {n}");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Cannot parse input value");
                    }
                    
                }

                Console.WriteLine();
                var container = containers[ix - 1];
                container.Prepare();

                Console.WriteLine("Result:");
                container.Execute();

                Console.WriteLine();
                Console.WriteLine("Continue? [y/n]");
                answer = Console.ReadLine();
            }
        }
    }
}
