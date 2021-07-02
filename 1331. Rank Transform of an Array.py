class Solution:
    def arrayRankTransform(self, arr: List[int]) -> List[int]:
        l = list(set(arr))
        l.sort()
        valueIndex = {v: k for k, v in enumerate(l)}
        for i in range(len(arr)):
            arr[i] = valueIndex[arr[i]] + 1
        return arr
