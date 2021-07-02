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
	public ListNode OddEvenList(ListNode head)
	{
		ListNode oddDummyHead = new ListNode(-1);
		ListNode oddDummyIter = oddDummyHead;
		ListNode evenDummyHead = new ListNode(-1);
		ListNode evenDummyIter = evenDummyHead;
		bool odd = true;
		while (head != null)
		{
			if (odd)
			{
				oddDummyIter.next = head;
				oddDummyIter = oddDummyIter.next;
			}
			else
			{
				evenDummyIter.next = head;
				evenDummyIter = oddDummyIter.next;
			}
			head = head.next;
			odd = !odd;
		}
		oddDummyIter.next = evenDummyHead.next;
		evenDummyIter.next = null;
		return oddDummyHead.next;
	}
}