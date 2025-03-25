namespace TheCodingScrolls.ConsoleApp.Problems;
/*

Title: 01. Two Sum

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.


Example 1:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:
Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:
Input: nums = [3,3], target = 6
Output: [0,1]

Constraints:
2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
*/

public class Problem002_AddTwoNumbers : IProblem
{
    public string Name => "Add Two Numbers (LeetCode 2)";

    public class ListNode(int val = 0, ListNode next = null)
    {
        public int val = val;
        public ListNode next = next;
    }

    public void Run()
    {
        static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode dummyHead = new(0, null);
            var listNodeResult = dummyHead;

            while (l1 != null || l2 != null || carry != 0)
            {
                var val1 = l1?.val ?? 0;
                var val2 = l2?.val ?? 0;

                var multiplyResult = val1 + val2 + carry;

                if (multiplyResult > 9)
                {
                    carry = multiplyResult / 10;
                    dummyHead.val = multiplyResult % 10;
                }
                else
                {
                    dummyHead.val = multiplyResult;
                    carry = 0;
                }

                l1 = l1?.next;
                l2 = l2?.next;

                if (l1 != null || l2 != null || carry != 0)
                {
                    dummyHead.next = new ListNode(0, null);
                    dummyHead = dummyHead.next;
                }
            }
            return listNodeResult;
        }

        var l1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));
        var result1 = AddTwoNumbers(l1, l2);

        // var l3 = new ListNode(0, null);
        // var l4 = new ListNode(0, null);
        // var result2 = AddTwoNumbers(l3, l4);

        // var l5 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, null)))))));
        // var l6 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, null))));
        // var result3 = AddTwoNumbers(l5, l6);
    }
}
