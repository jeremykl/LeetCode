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
	public IList<double> AverageOfLevels(TreeNode root)
	{
		List<double> l = new List<double>();
		Queue<TreeNode> q = new Queue<TreeNode>();
		q.Enqueue(root);
		q.Enqueue(null);
		int count = 0;
		double sum = 0;
		while (q.Count > 0)
		{
			TreeNode n = q.Dequeue();
			if (n == null)
			{
				if (q.Count > 0) q.Enqueue(null);
				l.Add(sum / count);
				sum = 0;
				count = 0;
			}
			else
			{
				count++;
				sum += n.val;
				if (n.left != null) q.Enqueue(n.left);
				if (n.right != null) q.Enqueue(n.right);
			}
		}
		return l;
	}
}