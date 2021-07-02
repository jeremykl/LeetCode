# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def isCompleteTree(self, root: TreeNode) -> bool:
        flatNodes = [(root, 1)]
        i = 0
        while i < len(flatNodes):
            currentNode, num = flatNodes[i]
            i += 1
            if currentNode:
                flatNodes.append((currentNode.left, num * 2))
                flatNodes.append((currentNode.right, num * 2 + 1))
        return flatNodes[-1][1] == len(flatNodes)
