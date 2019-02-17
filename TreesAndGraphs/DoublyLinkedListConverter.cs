using LeetCode.Models;

namespace LeetCode.TreesAndGraphs
{
    public class DoublyLinkedListConverter : IDoublyLinkedListConverter
    {
        public Node TreeToDoublyList(Node root)
        {
            DoublyLinkedListBuilder(root);
            return _head;
        }

        private void DoublyLinkedListBuilder(Node root)
        {
            if (root == null)
                return;
            
            DoublyLinkedListBuilder(root.left);

            if (_prev == null)
                _head = root;
            else
            {
                root.left = _prev;
                _prev.right = root;
            }

            _prev = root;
            
            DoublyLinkedListBuilder(root.right);
        }
        
        private Node _head;
        private Node _prev = null;
    }
}