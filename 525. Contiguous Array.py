class Solution:
    def findMaxLength(self, nums: List[int]) -> int:
        tracker = 0
        count = {}
        result = 0

        for index, value in enumerate(nums):
            if value == 0:
                tracker -= 1
            else:
                tracker += 1

            if tracker == 0:
                result = max(result, index + 1)

            if tracker not in count:
                count[tracker] = index
            else:
                result = max(result, index - count[tracker])
        return result
