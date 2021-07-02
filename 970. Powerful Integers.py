class Solution:
    def powerfulIntegers(self, x: int, y: int, bound: int) -> List[int]:
        powerful = set()
        for i in range(0, 20):
            for j in range(0, 20):
                numberToCheck = x**i + y**j
                if numberToCheck <= bound:
                    powerful.add(numberToCheck)
                else:
                    break
        return list(powerful)
