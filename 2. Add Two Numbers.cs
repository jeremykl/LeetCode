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
		int carry = 0;
		ListNode first = null;
		ListNode current = null;
		while (l1 != null || l2 != null || carry > 0)
		{
			int n1 = l1 == null ? 0 : l1.val;
			int n2 = l2 == null ? 0 : l2.val;

			int sum = n1 + n2 + carry;

			ListNode temp = new ListNode(sum % 10);
			carry = sum / 10;
			if (first == null)
			{
				first = temp;
			}
			else
			{
				current.next = temp;
			}
			current = temp;
			if (l1 != null) l1 = l1.next;
			if (l2 != null) l2 = l2.next;
		}
		return first;
	}
}