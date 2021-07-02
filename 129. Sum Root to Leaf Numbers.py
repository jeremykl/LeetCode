# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def sumNumbers(self, root: TreeNode) -> int:
        self.sum = 0

        def findNumbers(node, currentNumber):
            if node:
                currentNumber.append(str(node.val))
                # Left
                findNumbers(node.left, currentNumber)
                # Right
                findNumbers(node.right, currentNumber)
                if node.left == None and node.right == None:
                    self.sum += int("".join(currentNumber))
                currentNumber.pop()
        findNumbers(root, [])
        return self.sum
