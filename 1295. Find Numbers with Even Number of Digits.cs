public class Solution
{
	public int FindNumbers(int[] nums)
	{
		int evenCount = 0;
		for (int i = 0; i < nums.Length; i++)
		{
			int numbers = 0;
			while (nums[i] > 0)
			{
				numbers++;
				nums[i] /= 10;
			}
			if (numbers % 2 == 0)
			{
				evenCount++;
			}
		}
		return evenCount;
	}
}