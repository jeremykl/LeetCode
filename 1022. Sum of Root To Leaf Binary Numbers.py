# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def sumRootToLeaf(self, root: TreeNode) -> int:
        # Use DFS to find all of the numbers in binary and convert to int
        # Sum
        self._sum = 0

        def DFS(node, num):
            if not node:
                return

            # Convert to int as we go
            num = num * 2 + node.val

            # If we're at the bootom, we have our number for this root to leaf path
            if not node.left and not node.right:
                self._sum += num
                return

            # Continue DFS
            DFS(node.left, num)
            DFS(node.right, num)

        DFS(root,  0)
        return self._sum
