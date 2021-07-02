class Solution:
    def maxLengthBetweenEqualCharacters(self, s: str) -> int:
        d = {}
        maxLength = -1
        for i, letter in enumerate(s):
            if letter in d:
                if i - d[letter] - 1 > maxLength:
                    maxLength = i - d[letter] - 1
            else:
                d[letter] = i
        return maxLength
