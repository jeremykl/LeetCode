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
	public int MaxLevelSum(TreeNode root)
	{
		int maxLevel = 1;
		int maxLevelSum = int.MinValue;
		int currentSum = 0;
		int currentLevel = 1;
		Queue<TreeNode> q = new Queue<TreeNode>();
		q.Enqueue(root);
		q.Enqueue(null);

		while (q.Count > 0)
		{
			TreeNode n = q.Dequeue();
			if (n == null)
			{
				if (currentSum > maxLevelSum)
				{
					maxLevel = currentLevel;
					maxLevelSum = currentSum;
				}
				currentLevel++;
				currentSum = 0;
				if (q.Count > 0)
				{
					q.Enqueue(null);
				}
				continue;
			}
			currentSum += n.val;
			if (n.left != null)
			{
				q.Enqueue(n.left);
			}
			if (n.right != null)
			{
				q.Enqueue(n.right);
			}
		}
		return maxLevel;
	}
}