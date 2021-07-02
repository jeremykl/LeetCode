public class Solution
{
	public int SumOfUnique(int[] nums)
	{
		bool?[] unique = new bool?[101];

		foreach (int num in nums)
		{
			if (unique[num] is bool b && b)
			{
				unique[num] = false;
			}
			else if (unique[num] == null)
			{
				unique[num] = true;
			}
		}
		int sum = 0;
		for (int i = 0; i < unique.Length; i++)
		{
			if (unique[i] is bool b && b) sum += i;
		}
		return sum;
	}
}