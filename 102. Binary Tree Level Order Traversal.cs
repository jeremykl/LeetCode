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
	public IList<IList<int>> LevelOrder(TreeNode root)
	{
		List<IList<int>> results = new List<IList<int>>();
		if (root == null) return results;
		results.Add(new List<int>());
		Queue<TreeNode> q = new Queue<TreeNode>();
		q.Enqueue(root);
		q.Enqueue(null);
		while (q.Count > 0)
		{
			TreeNode t = q.Dequeue();
			if (t == null)
			{
				if (q.Count > 0)
				{
					results.Add(new List<int>());
					q.Enqueue(null);
				}
			}
			else
			{
				results[results.Count - 1].Add(t.val);
				if (t.left != null) q.Enqueue(t.left);
				if (t.right != null) q.Enqueue(t.right);
			}
		}
		return results;
	}
}