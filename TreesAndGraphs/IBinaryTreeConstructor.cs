using LeetCode.Models;

namespace LeetCode.TreesAndGraphs
{
    public interface IBinaryTreeConstructor
    {
        TreeNode BuildTree(int[] preorder, int[] inorder);
    }
}