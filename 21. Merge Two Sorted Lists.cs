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
	public ListNode MergeTwoLists(ListNode l1, ListNode l2)
	{
		ListNode DummyNode = new ListNode(-1);
		ListNode iter = DummyNode;

		// while l1 and l2 have values, compare them and add to iter in order. 
		while (l1 != null && l2 != null)
		{
			if (l1.val > l2.val)
			{
				iter.next = l2;
				l2 = l2.next;
			}
			else
			{
				iter.next = l1;
				l1 = l1.next;
			}
			iter = iter.next;
		}
		// if there are remaining elements, add them to the end.
		if (l1 != null) iter.next = l1;
		if (l2 != null) iter.next = l2;
		return DummyNode.next;
	}
}