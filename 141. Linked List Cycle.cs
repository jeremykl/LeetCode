/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
	public bool HasCycle(ListNode head)
	{
		if (head?.next == null) return false;

		ListNode slow = head.next, fast = head.next.next;
		while (slow != fast && fast?.next != null)
		{
			slow = slow.next;
			fast = fast.next.next;
		}
		return slow == fast;
	}
}