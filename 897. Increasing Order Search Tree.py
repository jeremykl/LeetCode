# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def increasingBST(self, root: TreeNode) -> TreeNode:
        head = TreeNode(-1)
        self.current = head

        def DFS(node):
            if not node:
                return

            DFS(node.left)

            self.current.right = TreeNode(node.val)
            self.current = self.current.right

            DFS(node.right)

        DFS(root)
        return head.right
