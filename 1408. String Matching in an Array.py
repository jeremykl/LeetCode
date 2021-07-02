class Solution:
    def stringMatching(self, words: List[str]) -> List[str]:
        words.sort(key=lambda x: len(x))
        ret = []

        for i in range(len(words)):

            for j in words[i:]:
                if words[i] != j and words[i] in j:
                    ret.append(words[i])
                    break
        return ret
