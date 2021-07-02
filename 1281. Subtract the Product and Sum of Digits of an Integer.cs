public class Solution
{
	public int SubtractProductAndSum(int n)
	{
		int product = 1;
		int sum = 0;
		while (n > 0)
		{
			int currentDigit = n % 10;
			n /= 10;
			product *= currentDigit;
			sum += currentDigit;
		}
		return product - sum;
	}
}