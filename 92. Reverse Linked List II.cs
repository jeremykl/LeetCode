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
	public ListNode ReverseBetween(ListNode head, int left, int right)
	{
		ListNode prev = null;
		ListNode curr = head;
		int i = 1;
		while (i < left)
		{
			prev = curr;
			curr = curr.next;
			i++;
		}

		ListNode con = prev, tail = curr;

		while (i <= right)
		{
			ListNode temp = curr.next;
			curr.next = prev;
			prev = curr;
			curr = temp;
			i++;
		}

		if (con != null)
		{
			con.next = prev;
		}
		else
		{
			head = prev;
		}
		tail.next = curr;
		return head;
	}
}