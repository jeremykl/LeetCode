class Solution:
    def isIsomorphic(self, s: str, t: str) -> bool:
        d = {}
        d2 = {}

        for i in range(len(s)):
            if s[i] in d:
                if d[s[i]] != t[i]:
                    return False
            else:
                d[s[i]] = t[i]
        for i in range(len(t)):
            if t[i] in d2:
                if d2[t[i]] != s[i]:
                    return False
            else:
                d2[t[i]] = s[i]
        return True
