/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
	public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
	{
		HashSet<ListNode> visited = new HashSet<ListNode>();

		while (headA != null || headB != null)
		{
			if (headA != null)
			{
				if (visited.Contains(headA)) return headA;
				visited.Add(headA);
				headA = headA.next;
			}
			if (headB != null)
			{
				if (visited.Contains(headB)) return headB;
				visited.Add(headB);
				headB = headB.next;
			}
		}
		return null;
	}
}