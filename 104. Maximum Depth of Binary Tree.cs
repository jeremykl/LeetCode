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
	public int MaxDepth(TreeNode root)
	{
		int depth = 0;
		int maxDepth = 0;
		DFS(root, ref depth, ref maxDepth);
		return maxDepth;
	}

	private void DFS(TreeNode node, ref int depth, ref int maxDepth)
	{
		if (node == null)
		{
			if (depth > maxDepth)
			{
				maxDepth = depth;
			}
			return;
		}
		depth++;
		DFS(node.left, ref depth, ref maxDepth);
		DFS(node.right, ref depth, ref maxDepth);
		depth--;
	}
}