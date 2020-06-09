namespace mindBox2
{
    using System.Collections.Generic;
    using System.Linq;

    public class RootTree
    {
        public IEnumerable<TreeNode> RootNodes { get; set; }

        public RootTree()
        {
            this.RootNodes = new TreeNode[] { 
                new TreeNode() {  Name = "A", 
                    Children = new TreeNode[] { 
                        new TreeNode() { 
                            Name = "B", 
                            Children= new TreeNode[] { new TreeNode() { Name = "D" }, new TreeNode() { Name = "E" } } },
                        new TreeNode() {
                            Name = "C",
                            Children= new TreeNode[] { new TreeNode() { Name = "F" }, new TreeNode() { Name = "G" } } }
                    } 
                },
            };
            
        }       

        public IEnumerable<TreeNode> GetAllNodes(TreeNode node)
        {            
            if (node == null)
                yield break;

            if (node.Children != null && node.Children.Any())
            {
                yield return node;

                var children = node.Children;
                foreach (var child in children)
                {
                    var nested = GetAllNodes(child);
                    foreach (var n in nested)
                    {
                        yield return n;
                    }                    
                }
            }
            else
            {   
                yield return node;
            }
        }
    }
}
