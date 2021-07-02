public class Solution
{
	public int ArraySign(int[] nums)
	{
		int negativeCount = 0;
		foreach (var i in nums)
		{
			if (i == 0)
			{
				return 0;
			}
			if (i < 0)
			{
				negativeCount++;
			}
		}
		return (negativeCount % 2) == 0 ? 1 : -1;
	}
}