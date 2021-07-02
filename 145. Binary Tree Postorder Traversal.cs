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
	public IList<int> PostorderTraversal(TreeNode root)
	{
		List<int> l = new List<int>();
		traverse(root, l);
		return l;
	}

	private void traverse(TreeNode node, List<int> l)
	{
		if (node == null) return;
		if (node.left != null) traverse(node.left, l);
		if (node.right != null) traverse(node.right, l);
		l.Add(node.val);
	}
}