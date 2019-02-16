using NLog;
using System;
using LeetCode.Config;
using LeetCode.TreesAndGraphs;
using Microsoft.Extensions.DependencyInjection;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var preorder = new int[] {3, 9, 20, 15, 7};
            var inorder = new int[] {9, 3, 15, 20, 7};

            var target = DependencyServicesProvider.Get().GetService<IBinaryTreeConstructor>();
            target.BuildTree(preorder, inorder);
            
            Console.WriteLine("Hello World!");
        }

        private static ILogger Logger = LogManager.GetCurrentClassLogger();
    }
}