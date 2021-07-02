class Solution:
    def islandPerimeter(self, grid: List[List[int]]) -> int:
        # First a easy solution then dfs
        edges = 0
        rows = len(grid)
        columns = len(grid[0])

        for i in range(0, rows):
            for j in range(0, columns):
                if grid[i][j] == 0:
                    continue
                # Check Left (if out of bounds or left is zero, add an edge)
                if j == 0 or grid[i][j - 1] == 0:
                    edges += 1
                # Check Right
                if j + 1 == columns or grid[i][j + 1] == 0:
                    edges += 1
                # Check Up
                if i == 0 or grid[i - 1][j] == 0:
                    edges += 1
                # Check Down
                if i + 1 == rows or grid[i + 1][j] == 0:
                    edges += 1
        return edges
