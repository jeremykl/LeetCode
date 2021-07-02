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
	public int MinDepth(TreeNode root)
	{
		if (root == null) return 0;
		Queue<TreeNode> q = new Queue<TreeNode>();
		q.Enqueue(root);
		q.Enqueue(null);
		int count = 0;
		while (q.Count > 0)
		{
			TreeNode t = q.Dequeue();
			if (t == null)
			{
				count++;
				if (q.Count > 0) q.Enqueue(null);
				continue;
			}

			if (t.left == null && t.right == null) return count + 1;
			if (t.left != null) q.Enqueue(t.left);
			if (t.right != null) q.Enqueue(t.right);
		}
		return count;
	}
}