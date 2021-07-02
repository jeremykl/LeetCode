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
	public bool IsValidBST(TreeNode root)
	{
		TreeNode prev = null;
		return isValid(root, ref prev);
	}

	private bool isValid(TreeNode node, ref TreeNode prev)
	{
		if (node == null) return true;
		if (!isValid(node.left, ref prev)) return false;
		if (prev != null && prev.val >= node.val) return false;
		prev = node;
		return isValid(node.right, ref prev);
	}
}