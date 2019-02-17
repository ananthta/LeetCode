using LeetCode.Models;
using System.Collections.Generic;

namespace LeetCode.TreesAndGraphs
{
    public class GraphCloner : IGraphCloner
    {
        public UndirectedGraphNode CloneGraph(UndirectedGraphNode node)
        {
            var graphQueue = new Queue<UndirectedGraphNode>();
            var oldNodeToNewNodeMap = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();
            
            graphQueue.Enqueue(node);
            oldNodeToNewNodeMap.Add(node, new UndirectedGraphNode(node.label));

            while (graphQueue.Count != 0)
            {
                var graphNode = graphQueue.Dequeue();

                foreach (var neighbour in graphNode.neighbours)
                {
                    if (!oldNodeToNewNodeMap.ContainsKey(node))
                    {
                        oldNodeToNewNodeMap.Add(neighbour, new UndirectedGraphNode(neighbour.label));
                        graphQueue.Enqueue(neighbour);
                    }
                    oldNodeToNewNodeMap[node].neighbours.Add(neighbour);
                }
            }

            return oldNodeToNewNodeMap[node];
        }
    }
}