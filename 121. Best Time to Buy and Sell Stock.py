class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        maxProfit = 0
        minPrice = prices[0]

        for i in range(1, len(prices)):
            if prices[i] - minPrice > maxProfit:
                maxProfit = prices[i] - minPrice
            if prices[i] < minPrice:
                minPrice = prices[i]
        return maxProfit
