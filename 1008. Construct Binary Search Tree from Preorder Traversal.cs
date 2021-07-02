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
	public TreeNode BstFromPreorder(int[] preorder)
	{
		if (preorder == null || preorder.Length == 0) return null;
		return BuildBST(preorder, 0, preorder.Length);
	}

	private TreeNode BuildBST(int[] preorder, int rootIndex, int right)
	{
		if (rootIndex >= right) return null;

		int value = preorder[rootIndex];
		TreeNode root = new TreeNode(value);

		int i = rootIndex + 1;
		// left subtree of current node
		while (i <= preorder.Length - 1 && preorder[i] < value)
		{
			i++;
		}

		root.left = BuildBST(preorder, rootIndex + 1, i);
		root.right = BuildBST(preorder, i, right);

		return root;
	}
}