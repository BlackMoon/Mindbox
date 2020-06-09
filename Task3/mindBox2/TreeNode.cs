using System.Collections.Generic;

namespace mindBox2
{ 
    public class TreeNode
    {
        public string Name { get; set; }
       
        public IEnumerable<TreeNode> Children { get; set; }
    }
   
}
