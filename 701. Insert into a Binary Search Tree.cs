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
	public TreeNode InsertIntoBST(TreeNode root, int val)
	{
		if (root == null) return new TreeNode(val);
		InsertIntoBST2(ref root, val);
		return root;
	}

	private void InsertIntoBST2(ref TreeNode node, int val)
	{
		if (node == null)
		{
			node = new TreeNode(val);
			return;
		}
		if (val < node.val)
		{
			InsertIntoBST2(ref node.left, val);
		}
		else
		{
			InsertIntoBST2(ref node.right, val);
		}
	}
}