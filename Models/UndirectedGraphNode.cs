using System.Collections.Generic;

namespace LeetCode.Models
{
    public class UndirectedGraphNode
    {
        public int label;
        public IList<UndirectedGraphNode> neighbours;

        public UndirectedGraphNode(int x)
        {
            label = x;
            neighbours = new List<UndirectedGraphNode>();
        }
    }
}