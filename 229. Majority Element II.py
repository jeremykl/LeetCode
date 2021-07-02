class Solution:
    def majorityElement(self, nums: List[int]) -> List[int]:
        occurrence = {}
        for num in nums:
            if num in occurrence:
                occurrence[num] += 1
            else:
                occurrence[num] = 1
        ret = []
        for key, val in occurrence.items():
            if val > len(nums) / 3:
                ret.append(key)
        return ret
