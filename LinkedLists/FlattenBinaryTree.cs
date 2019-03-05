using LeetCode.Models;

namespace LeetCode.LinkedLists
{
    public class FlattenBinaryTree : IFlattenBinaryTree
    {
        public void Flatten(TreeNode root)
        {
            if (root == null)
                return;
            
            Flatten(root.right);
            Flatten(root.left);
            root.right = _prev;
            root.left = null;
            _prev = root;
        }

        private TreeNode _prev = null;
    }
}