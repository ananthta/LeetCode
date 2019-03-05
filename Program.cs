using NLog;
using System;
using LeetCode.ArraysAndStrings;
using LeetCode.Backtracking;
using LeetCode.Config;
using LeetCode.DynamicProgramming;
using LeetCode.LinkedLists;
using LeetCode.Models;
using LeetCode.TreesAndGraphs;
using Microsoft.Extensions.DependencyInjection;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var ln1 = new ListNode(0) {next = new ListNode(9){next = new ListNode(1) {next = new ListNode(2){next = new ListNode(4)}}}};
            var ln2 = new ListNode(3){next = new ListNode(2){next = new ListNode(4)}};

            var target = DependencyServicesProvider.Get().GetService<ILinkedListIntersection>();
            var node = target.GetIntersectionNode(ln1, ln2);
            
            Console.WriteLine("Hello World!");
        }

        private static ILogger Logger = LogManager.GetCurrentClassLogger();
    }
}