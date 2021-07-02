public class Solution
{
	IList<IList<int>> results = new List<IList<int>>();
	public IList<IList<int>> CombinationSum(int[] candidates, int target)
	{
		Array.Sort(candidates);
		helper(target, new List<int>(), candidates, 0);
		return results;
	}

	private void helper(int remainder, List<int> combo, int[] candidates, int startIndex)
	{
		if (remainder == 0)
		{
			results.Add(new List<int>(combo));
			return;
		}
		else if (remainder < 0)
		{
			return;
		}
		for (int i = startIndex; i < candidates.Length; i++)
		{
			if (candidates[i] > remainder) break;
			combo.Add(candidates[i]);
			helper(remainder - candidates[i], combo, candidates, i);
			combo.RemoveAt(combo.Count - 1);
		}
	}
}