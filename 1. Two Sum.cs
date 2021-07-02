public class Solution
{
	public int[] TwoSum(int[] nums, int target)
	{
		Dictionary<int, int> remainderIndex = new Dictionary<int, int>();
		for (int i = 0; i < nums.Length; i++)
		{
			int current = nums[i];
			if (remainderIndex.ContainsKey(current)) return new int[] { remainderIndex[current], i };
			remainderIndex[target - current] = i;
		}
		return new int[] { };
	}
}