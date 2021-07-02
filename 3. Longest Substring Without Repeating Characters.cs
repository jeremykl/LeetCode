public class Solution
{
	public int LengthOfLongestSubstring(string s)
	{
		Dictionary<char, int> charLastIndex = new Dictionary<char, int>();
		int max = 0;
		for (int i = 0, j = 0; i < s.Length; i++)
		{
			if (charLastIndex.ContainsKey(s[i]))
			{
				j = Math.Max(j, charLastIndex[s[i]] + 1);
			}
			charLastIndex[s[i]] = i;
			max = Math.Max(max, i - j + 1);
		}
		return max;
	}
}