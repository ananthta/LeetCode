using LeetCode.Models;

namespace LeetCode.SortingAndSearching
{
    public class MergeSortedLists : IMergeSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 != null)
                return l2;

            if (l2 == null && l1 != null)
                return l1;
            
            if (l1 == null && l2 == null)
                return null;



            ListNode newHead;
            ListNode l1Next;
            ListNode l2Next;

            if (l1.val > l2.val)
            {
                newHead = new ListNode(l2.val);
                l1Next = l1;
                l2Next = l2.next;
            }
            else
            {
                newHead = new ListNode(l1.val);
                l1Next = l1.next;
                l2Next = l2;
            }

            var currHead = newHead;
            

            while (l1Next != null && l2Next != null)
            {
                if (l1Next.val < l2Next.val)
                {
                    currHead.next = l1Next;
                    currHead = l1Next;
                    l1Next = l1Next.next;
                }
                else
                {
                    currHead.next = l2Next;
                    currHead = l2Next;
                    l2Next = l2Next.next;
                }
            }

            if (l1Next != null)
            {
                while (l1Next != null)
                {
                    currHead.next = l1Next;
                    currHead = l1Next;
                    l1Next = l1Next.next;
                }
            }

            if (l2Next == null) return newHead;
            while (l2Next != null)
            {
                currHead.next = l2Next;
                currHead = l2Next;
                l2Next = l2Next.next;
            }

            return newHead;
        }
    }
}