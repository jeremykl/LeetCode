# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def findSecondMinimumValue(self, root: TreeNode) -> int:
        # Tried logic-ing it out, just going to do a DFS

        def DFS(node):
            if not node:
                return

            if node.val < self.second and node.val > self.rootVal:
                self.second = node.val

            DFS(node.left)
            DFS(node.right)
        self.second = float('inf')
        # minimum of one node, so we're safe
        self.rootVal = root.val

        DFS(root)
        return self.second if self.second < float('inf') else -1
