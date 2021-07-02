public class Solution
{
	public IList<IList<int>> Subsets(int[] nums)
	{
		List<IList<int>> l = new List<IList<int>>();
		l.Add(new List<int>());
		foreach (int num in nums)
		{
			List<IList<int>> newSubsets = new List<IList<int>>();
			// For each existing set, create a set with the new number included
			foreach (List<int> curr in l)
			{
				newSubsets.Add(new List<int>(curr));
				newSubsets[newSubsets.Count - 1].Add(num);
			}
			// Add these new sets to l
			foreach (List<int> curr in newSubsets)
			{
				l.Add(curr);
			}
		}
		return l;
	}
}