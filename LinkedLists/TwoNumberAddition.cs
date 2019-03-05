using LeetCode.Models;

namespace LeetCode.LinkedLists
{
    public class TwoNumberAddition : ITwoNumberAddition
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var res = Add(l1, l2, 0);
            return res;
        }

        private ListNode Add(ListNode l1, ListNode l2, int remainder)
        {
            if (l1 == null && l2 == null && remainder > 0)
                return new ListNode(remainder);

            if (l1 == null && l2 == null && remainder == 0)
                return null;

            if (l1 == null)
            {
                var sum = (l2.val + remainder) % 10;
                var carryOver = (l2.val + remainder) / 10;
                return new ListNode(sum) {next = Add(null, l2.next, carryOver)};
            }

            if (l2 == null)
            {
                var sum = (l1.val + remainder) % 10;
                var carryOver = (l1.val + remainder) / 10;
                return new ListNode(sum) {next = Add(l1.next, null, carryOver)};
            }

            var s = (l1.val + l2.val + remainder) % 10;
            var co = (l1.val + l2.val + remainder) / 10;
            return new ListNode(s){next = Add(l1.next, l2.next, co)};
        }
    }
}