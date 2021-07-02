class Solution:
    def climbStairs(self, n: int) -> int:
        if n == 1:
            return 1
        track = [0]*(n+1)
        track[1] = 1
        track[2] = 2
        for i in range(3, n + 1):
            track[i] = track[i - 1] + track[i - 2]

        return track[n]
