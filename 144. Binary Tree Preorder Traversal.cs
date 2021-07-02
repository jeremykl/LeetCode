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
	public IList<int> PreorderTraversal(TreeNode root)
	{
		List<int> l = new List<int>();
		DFS(root, l);
		return l;
	}

	private void DFS(TreeNode root, IList<int> l)
	{
		if (root == null) return;
		l.Add(root.val);
		if (root.left != null) DFS(root.left, l);
		if (root.right != null) DFS(root.right, l);
	}
}