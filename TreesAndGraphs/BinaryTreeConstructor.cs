using NLog;
using System;
using LeetCode.Models;
using System.Collections.Generic;

namespace LeetCode.TreesAndGraphs
{
    public class BinaryTreeConstructor : IBinaryTreeConstructor
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return TreeBuildHelper(0, inorder.Length - 1, preorder, inorder);
        }

        private TreeNode TreeBuildHelper(int inStart, int inEnd, IReadOnlyList<int> preOrder, IReadOnlyList<int> inOrder)
        {
            if (inStart > inEnd || _currentPreIndex >= preOrder.Count)
                return null;
                        
            var node = new TreeNode(preOrder[_currentPreIndex++]);

            if (inStart == inEnd)
                return node;

            int currentInIndex;

            try
            {
                currentInIndex = GetCurrentInOrderIndex(inStart, inEnd, inOrder, node);
            }
            catch (Exception e)
            {
                Logger.Error(e.ToString());
                throw;
            }

            if (currentInIndex == -1)
                return null;

            node.left = TreeBuildHelper(inStart, currentInIndex - 1, preOrder, inOrder);
            node.right = TreeBuildHelper(currentInIndex + 1, inEnd, preOrder, inOrder);

            return node;
        }

        private static int GetCurrentInOrderIndex(int inStart, int inEnd, IReadOnlyList<int> inOrder, TreeNode node)
        {
            for (var i = inStart; i <= inEnd; i++)
            {
                if (inOrder[i] == node.val)
                {
                    return i;
                }
            }

            return -1;
        }
        private int _currentPreIndex = 0;
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
    }
}