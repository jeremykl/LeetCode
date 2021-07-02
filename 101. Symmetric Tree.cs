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
	public bool IsSymmetric(TreeNode root)
	{
		Queue<TreeNode> q = new Queue<TreeNode>();
		q.Enqueue(root);
		q.Enqueue(root);
		while (q.Count > 0)
		{
			TreeNode t1 = q.Dequeue();
			TreeNode t2 = q.Dequeue();
			if (t1 == null && t2 == null) continue;
			if (t1 == null || t2 == null) return false;
			if (t1.val != t2.val) return false;
			q.Enqueue(t1.left);
			q.Enqueue(t2.right);
			q.Enqueue(t1.right);
			q.Enqueue(t2.left);
		}
		return true;
	}
}