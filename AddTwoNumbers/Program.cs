using System;
using System.Collections.Generic;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            ListNode l1 = new ListNode(9);
            ListNode l12 = new ListNode(9,l1);
            ListNode l13 = new ListNode(9,l12);

            ListNode l2 = new ListNode(1);
            ListNode l22 = new ListNode(0, l2);
            ListNode l23 = new ListNode(2, l22);

            solution.AddTwoNumbers(l13, l23);
        }
    }
}
