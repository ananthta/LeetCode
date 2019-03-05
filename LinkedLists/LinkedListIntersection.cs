using LeetCode.Models;
using System.Collections.Generic;

namespace LeetCode.LinkedLists
{
    public class LinkedListIntersection : ILinkedListIntersection
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;

            return null;

        }

        private static int GetCount(ListNode head)
        {
            var counter = 0;
            if (head == null)
                return counter;
            while (head != null)
            {
                counter++;
                head = head.next;
            }

            return counter;
        }
    }
}