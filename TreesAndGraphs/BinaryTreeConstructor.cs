using LeetCode.Models;

namespace LeetCode.TreesAndGraphs
{
    public class BinaryTreeConstructor : IBinaryTreeConstructor
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return Helper(0, 0, inorder.Length - 1, preorder, inorder);
        }

        private TreeNode Helper(int preStart, int inStart, int inEnd, int[] preorder, int[] inorder) {
            if (preStart > preorder.Length - 1 || inStart > inEnd) {
                return null;
            }
            var root = new TreeNode(preorder[preStart]);
            var inIndex = 0; // Index of current root in inorder
            for (var i = inStart; i <= inEnd; i++) {
                if (inorder[i] == root.val) {
                    inIndex = i;
                }
            }

            var rightStart = preStart + inIndex - inStart + 1;
            
            
            root.left = Helper(preStart + 1, inStart, inIndex - 1, preorder, inorder);
            root.right = Helper(preStart + inIndex - inStart + 1, inIndex + 1, inEnd, preorder, inorder);
            return root;
        }
    }
}