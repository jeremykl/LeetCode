public class Solution
{
	public int CountConsistentStrings(string allowed, string[] words)
	{
		HashSet<char> allowedChars = new HashSet<char>(allowed);
		int count = 0;
		foreach (var word in words)
		{
			bool consistent = true;
			foreach (var c in word)
			{
				if (!allowedChars.Contains(c))
				{
					consistent = false;
					break;
				}
			}
			if (consistent)
			{
				count++;
			}
		}
		return count;
	}
}