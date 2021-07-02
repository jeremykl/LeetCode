"""
# Definition for a Node.
class Node:
    def __init__(self, val=None, children=None):
        self.val = val
        self.children = children
"""


class Solution:
    def maxDepth(self, root: 'Node') -> int:
        def DFS(node, depth, maxDepth):
            depth += 1
            if depth > maxDepth:
                maxDepth = depth
            for i in node.children:
                maxDepth = DFS(i, depth, maxDepth)
            depth -= 1
            return maxDepth

        if not root:
            return 0
        return DFS(root, 0, 0)
