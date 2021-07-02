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
	public int DeepestLeavesSum(TreeNode root)
	{
		// Perform DFS Where we keep track of the sum at each level

		// Create dictionary to hold sum at depth
		Dictionary<int, int> sumAtLevel = new Dictionary<int, int>();
		DFS(root, 0, sumAtLevel);

		// Get Max depth and get value
		int maxDepth = 0;
		foreach (var kvp in sumAtLevel)
		{
			if (kvp.Key > maxDepth)
			{
				maxDepth = kvp.Key;
			}
		}
		return sumAtLevel[maxDepth];
	}

	private void DFS(TreeNode node, int level, Dictionary<int, int> sumAtLevel)
	{
		if (node == null) return;
		level++;

		if (!sumAtLevel.ContainsKey(level))
		{
			sumAtLevel[level] = node.val;
		}
		else
		{
			sumAtLevel[level] += node.val;
		}

		DFS(node.left, level, sumAtLevel);
		DFS(node.right, level, sumAtLevel);

		level--;
	}
}