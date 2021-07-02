public class Solution
{
	public int SingleNumber(int[] nums)
	{
		HashSet<int> numbers = new HashSet<int>();
		int sum = 0;
		int uniqueSum = 0;

		foreach (int i in nums)
		{
			if (!numbers.Contains(i))
			{
				uniqueSum += i;
				numbers.Add(i);
			}
			sum += i;
		}
		return 2 * uniqueSum - sum;
	}
}