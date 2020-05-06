using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int val=0, ListNode next=null) {
     *         this.val = val;
     *         this.next = next;
     *     }
     * }
     */
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode prev = null;
            ListNode start = result;
            int reminder = 0;

            while (l1 != null || l2 != null || reminder != 0)
            {
                int resultOfAdd = (l1?.val ?? 0) + (l2?.val ?? 0);

                if (reminder != 0)
                {
                    resultOfAdd++;
                    reminder--;
                }

                if (resultOfAdd > 9)
                {
                    resultOfAdd %= 10;
                    reminder++;
                }

                result.val = resultOfAdd;

                if (prev != null)
                {
                    prev.next = result;
                }

                prev = result;
                l1 = l1?.next;
                l2 = l2?.next;
                result = new ListNode();
            }

            return start;
        }
    }
}
