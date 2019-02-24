using NLog;
using System;
using System.Collections.Generic;
using LeetCode.Backtracking;
using LeetCode.Config;
using LeetCode.Models;
using LeetCode.SortingAndSearching;
using LeetCode.TreesAndGraphs;
using Microsoft.Extensions.DependencyInjection;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //1->2->4, 1->3->4
            
            var n11 = new ListNode(1);
            var n12 = new ListNode(2);
            var n13 = new ListNode(4);

            n11.next = n12;
            n12.next = n13;
            
            var n21 = new ListNode(1);
            var n22 = new ListNode(3);
            var n23 = new ListNode(4);

            n21.next = n22;
            n22.next = n23;
            
            
            var target = DependencyServicesProvider.Get().GetService<IMergeSortedLists>();
            var node = target.MergeTwoLists(n11, n21);
            
            Console.WriteLine("Hello World!");
        }

        private static ILogger Logger = LogManager.GetCurrentClassLogger();
    }
}