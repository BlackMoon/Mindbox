namespace mindBox2
{
    using System;
    using System.Linq;

    class Program
    {
        private static RootTree rootTree = new RootTree();

        static void Main(string[] args)
        {

            var nodes = rootTree.GetAllNodes(rootTree.RootNodes.First());                        
            foreach (var node in nodes)
            {
                Console.WriteLine(node.Name);
            }

            Console.ReadKey();
        }       
    }
}

