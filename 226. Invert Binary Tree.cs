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
	public TreeNode InvertTree(TreeNode root)
	{
		Swap(root);
		return root;
	}

	private void Swap(TreeNode root)
	{
		if (root == null) return;
		TreeNode tempLeft = root.left;
		Swap(root.left);
		Swap(root.right);
		root.left = root.right;
		root.right = tempLeft;
	}
}