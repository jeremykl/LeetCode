class Solution:
    def findDuplicates(self, nums: List[int]) -> List[int]:
        ret = []
        remove = set(nums)
        for i in nums:
            if i in remove:
                remove.remove(i)
            else:
                ret.append(i)
        return ret
