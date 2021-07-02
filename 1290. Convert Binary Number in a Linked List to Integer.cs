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
	public int GetDecimalValue(ListNode head)
	{
		int val = head.val;
		head = head.next;
		while (head != null)
		{
			val = val * 2 + head.val;
			head = head.next;
		}
		return val;
	}
}