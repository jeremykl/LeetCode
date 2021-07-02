class Solution:
    def suggestedProducts(self, products: List[str], searchWord: str) -> List[List[str]]:
        products.sort()
        currList = products.copy()
        res = []
        for i in range(len(searchWord)):
            currList = [j for j in currList if len(j) > i and j[i] == searchWord[i]]
            res.append(currList[0:3])
        return res
