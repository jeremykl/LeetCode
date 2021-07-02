class Solution:
    def frequencySort(self, nums: List[int]) -> List[int]:
        d = {}

        for n in nums:
            if n in d:
                d[n] += 1
            else:
                d[n] = 1
        l = []
        for key in d:
            l.append([key] * d[key])

        l.sort(key=lambda x: (len(x), -x[0]))
        return [item for sublist in l for item in sublist]
