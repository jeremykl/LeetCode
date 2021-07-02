public class Solution
{
	public bool CheckPerfectNumber(int num)
	{
		var perfectSum = 0;
		for (var i = 1; i <= num / 2; i++)
		{
			if (num % i == 0)
			{
				perfectSum += i;
			}
		}
		return perfectSum == num;
	}
}