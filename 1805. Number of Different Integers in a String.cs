public class Solution
{
	public int NumDifferentIntegers(string word)
	{
		HashSet<string> hs = new HashSet<string>();
		string current = "";
		foreach (Char c in word)
		{
			if (Char.IsNumber(c))
			{
				current += c;
			}
			else if (current != "")
			{
				hs.Add(current.TrimStart('0'));
				current = "";
			}
		}
		if (current != "")
		{
			hs.Add(current.TrimStart('0'));
			current = "";
		}
		return hs.Count();
	}
}