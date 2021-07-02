class Solution:
    def findTheDifference(self, s: str, t: str) -> str:
        dict_s = {}
        letters = set()
        for letter in s:
            if letter in dict_s:
                dict_s[letter] += 1
            else:
                dict_s[letter] = 1
                letters.add(letter)
        dict_t = {}
        for letter in t:
            if letter in dict_t:
                dict_t[letter] += 1
            else:
                dict_t[letter] = 1
                letters.add(letter)

        for letter in letters:
            if letter in dict_s and letter in dict_t:
                if dict_s[letter] != dict_t[letter]:
                    return letter
            else:
                return letter
