namespace LeetCode.Models
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;

        public Node(int v, Node l = null, Node r = null)
        {
            val = v;
            left = l;
            right = r;
        }

        public Node()
        {
        }
    }
}