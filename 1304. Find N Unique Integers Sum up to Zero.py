class Solution:
    def sumZero(self, n: int) -> List[int]:
        uniqueSum = []

        # If odd add 0
        if n % 2 != 0:
            uniqueSum.append(0)

        currentNum = 1
        plus = True
        while len(uniqueSum) != n:
            if plus:
                uniqueSum.append(currentNum)
            else:
                uniqueSum.append(-currentNum)
                currentNum += 1
            plus = not plus
        return uniqueSum
