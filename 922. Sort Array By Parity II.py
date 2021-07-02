class Solution:
    def sortArrayByParityII(self, nums: List[int]) -> List[int]:
        ret = [0] * len(nums)
        oddI = 1
        evenI = 0

        for i in range(len(nums)):
            if nums[i] % 2 == 0:
                ret[evenI] = nums[i]
                evenI += 2
            else:
                ret[oddI] = nums[i]
                oddI += 2
        return ret
