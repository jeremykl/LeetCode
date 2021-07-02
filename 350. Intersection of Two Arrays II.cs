public class Solution
{
	public int[] Intersect(int[] nums1, int[] nums2)
	{
		int[] count1 = new int[1001];
		int[] count2 = new int[1001];
		int max = 0;
		foreach (int i in nums1)
		{
			count1[i]++;
			if (i > max) max = i;
		}
		foreach (int i in nums2)
		{
			count2[i]++;
			if (i > max) max = i;
		}
		List<int> l = new List<int>();
		for (int i = 0; i <= max; i++)
		{
			if (count1[i] > 0 && count2[i] > 0)
			{
				for (int j = 0; j < Math.Min(count1[i], count2[i]); j++)
				{
					l.Add(i);
				}
			}
		}
		return l.ToArray();
	}
}