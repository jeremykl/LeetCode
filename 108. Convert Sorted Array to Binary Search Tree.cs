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
	public TreeNode SortedArrayToBST(int[] nums)
	{
		return makeBST(0, nums.Length - 1, nums);
	}

	private TreeNode makeBST(int left, int right, int[] nums)
	{
		if (right < left) return null;
		int m = (right + left) / 2;
		TreeNode root = new TreeNode(nums[m]);
		root.left = makeBST(left, m - 1, nums);
		root.right = makeBST(m + 1, right, nums);
		return root;
	}
}