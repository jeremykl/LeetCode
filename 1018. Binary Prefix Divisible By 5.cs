public class Solution
{
	public IList<bool> PrefixesDivBy5(int[] nums)
	{
		List<bool> l = new List<bool>(nums.Length);
		int current = 0;
		for (int i = 0; i < nums.Length; i++)
		{
			current = current << 1;
			current += nums[i];

			l.Add(current % 5 == 0);
			current = current % 5;
		}
		return l;
	}
}