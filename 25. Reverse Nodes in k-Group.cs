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
	public ListNode ReverseKGroup(ListNode head, int k)
	{
		if (head == null || head.next == null || k == 1) return head;
		ListNode begin;
		ListNode dummyHead = new ListNode();
		dummyHead.next = head;
		begin = dummyHead;
		int i = 0;
		// Move head forward until we have moved k times
		while (head != null)
		{
			i++;
			if (i % k == 0)
			{
				// reverse elements between begin and end
				begin = reverse(begin, head.next);
				head = begin.next;
			}
			else
			{
				head = head.next;
			}
		}
		return dummyHead.next;
	}

	private ListNode reverse(ListNode begin, ListNode end)
	{
		ListNode curr = begin.next;
		ListNode next, first;
		ListNode prev = begin;
		first = curr;
		while (curr != end)
		{
			next = curr.next;
			curr.next = prev;
			prev = curr;
			curr = next;
		}
		begin.next = prev;
		first.next = curr;
		return first;
	}
}