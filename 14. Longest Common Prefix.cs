public class Solution
{
	public string LongestCommonPrefix(string[] strs)
	{
		// check first element against the next one, if it isn't a prefix remove the last letter then repeat for each str in strs.
		if (strs.Length == 0) return "";
		string s = strs[0];
		for (int i = 1; i < strs.Length; i++)
		{
			while (strs[i].IndexOf(s) != 0)
			{
				s = s.Substring(0, s.Length - 1);
				if (s == "") return "";
			}
		}
		return s;
	}
}