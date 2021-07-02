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
	public ListNode RemoveNthFromEnd(ListNode head, int n)
	{
		ListNode dummy = new ListNode(-1, head);
		ListNode first = dummy;
		ListNode second = dummy;

		// move forward n times in first
		for (int i = 0; i <= n; i++)
		{
			first = first.next;
		}

		// once first reaches the end, second will be n from the end of the linked list
		while (first != null)
		{
			first = first.next;
			second = second.next;
		}
		second.next = second.next.next;
		return dummy.next;
	}
}