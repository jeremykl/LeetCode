class Solution:
    def numJewelsInStones(self, J: 'str', S: 'str') -> 'int':
        ret = 0
        for char in S:
            if char in J:
                ret += 1
        return ret
