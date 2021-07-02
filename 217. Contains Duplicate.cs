public class Solution
{
	public bool ContainsDuplicate(int[] nums)
	{
		HashSet<int> hs = new HashSet<int>();

		foreach (int num in nums)
		{
			if (hs.Contains(num))
			{
				return true;
			}
			else
			{
				hs.Add(num);
			}
		}
		return false;
	}
}