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
	public ListNode DeleteDuplicates(ListNode head)
	{
		ListNode dummy = new ListNode(-1, head);
		ListNode current = dummy;
		ListNode check = head;

		while (check != null)
		{
			int val = check.val;
			check = check.next;
			bool dupe = false;
			while (check != null && check.val == val)
			{
				dupe = true;
				check = check.next;
			}
			if (dupe)
			{
				current.next = check;
			}
			else
			{
				current = current.next;
			}
		}
		return dummy.next;
	}
}