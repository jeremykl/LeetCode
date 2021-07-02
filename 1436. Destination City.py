class Solution:
    def destCity(self, paths: List[List[str]]) -> str:
        to = [paths[i][1] for i in range(len(paths))]
        fromm = [paths[i][0] for i in range(len(paths))]

        for i in range(len(paths)):
            if (to[i] not in fromm):
                return to[i]
