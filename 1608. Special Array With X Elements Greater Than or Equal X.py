class Solution:
    def specialArray(self, nums: List[int]) -> int:
        nums.sort()

        for i in range(len(nums)):
            if nums[i] >= len(nums) - i:
                if i > 0 and nums[i-1] >= len(nums) - i:
                    continue
                else:
                    return len(nums) - i
        return -1
