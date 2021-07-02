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
	public IList<string> BinaryTreePaths(TreeNode root)
	{
		List<string> l = new List<string>();
		DFS(root, "", l);
		return l;
	}

	private void DFS(TreeNode node, string path, IList<string> l)
	{
		if (node.left == null && node.right == null) l.Add(path + node.val);
		if (node.left != null)
		{
			DFS(node.left, path + node.val + "->", l);
		}
		if (node.right != null)
		{
			DFS(node.right, path + node.val + "->", l);
		}
	}
}