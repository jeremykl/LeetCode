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
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
	public TreeNode SortedListToBST(ListNode head)
	{
		if (head == null) return null;
		return toBST(head, null);
	}

	private TreeNode toBST(ListNode head, ListNode tail)
	{
		if (head == tail) return null;
		ListNode slow = head;
		ListNode fast = head;
		while (fast != tail && fast.next != tail)
		{
			slow = slow.next;
			fast = fast.next.next;
		}
		TreeNode node = new TreeNode(slow.val);
		node.left = toBST(head, slow);
		node.right = toBST(slow.next, tail);
		return node;
	}
}