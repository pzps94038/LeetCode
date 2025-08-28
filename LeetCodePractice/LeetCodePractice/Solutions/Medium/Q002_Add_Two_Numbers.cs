using LeetCodePractice.Core.Interface.Shared;

namespace LeetCodePractice.Solutions.Medium
{
    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    /// <summary>
    /// Add Two Numbers
    /// 學進位
    /// https://leetcode.com/problems/add-two-numbers/description/
    /// </summary>
    public class Q002_Add_Two_Numbers : ISolution<(ListNode l1, ListNode l2), ListNode>
    {
        public ListNode Solve((ListNode l1, ListNode l2) input)
        {
            var curl1 = input.l1;
            var curl2 = input.l2;
            // 進位數
            var carry = 0;
            var result = new ListNode(0);
            var current = result;
            while (curl1 != null || curl2 != null || carry != 0)
            {
                if (curl1 != null)
                {
                    carry += curl1.val;
                    curl1 = curl1.next;
                }
                if (curl2 != null)
                {
                    carry += curl2.val;
                    curl2 = curl2.next;
                }
                // 取非進位值 ex: 12 = 2
                current.next = new ListNode(carry % 10);
                // 取進位值 ex: 12 = 1
                carry = carry / 10;
                current = current.next;
            }

            return result.next!;
        }
    }
}