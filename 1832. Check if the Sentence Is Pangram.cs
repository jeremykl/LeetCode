public class Solution
{
	public bool CheckIfPangram(string sentence)
	{
		HashSet<char> hs = new HashSet<char>();

		foreach (char c in sentence)
		{
			hs.Add(c);
			if (hs.Count == 26) return true;
		}
		return false;
	}
}