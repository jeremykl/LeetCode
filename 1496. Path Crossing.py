class Solution:
    def isPathCrossing(self, path: str) -> bool:
        visited = set()
        position = (0, 0)
        visited.add(position)
        for i in path:
            if i == "N":
                position = (position[0], position[1] + 1)
            elif i == "S":
                position = (position[0], position[1] - 1)
            elif i == "E":
                position = (position[0] + 1, position[1])
            elif i == "W":
                position = (position[0] - 1, position[1])

            if position in visited:
                return True

            visited.add(position)
        return False
