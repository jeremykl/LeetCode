public class Solution
{
	public IList<IList<string>> FindDuplicate(string[] paths)
	{
		Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
		foreach (var path in paths)
		{
			string[] s = path.Split(' ');
			for (int i = 1; i < s.Length; i++)
			{
				// Make full path
				s[i] = s[0] + "/" + s[i];
				// get Key
				string key = s[i].Substring(s[i].IndexOf('(')).Replace(")", "");
				if (dict.ContainsKey(key))
				{
					dict[key].Add(s[i].Substring(0, s[i].IndexOf('(')));
				}
				else
				{
					dict[key] = new List<string>();
					dict[key].Add(s[i].Substring(0, s[i].IndexOf('(')));
				}
			}
		}
		IList<IList<string>> l = new List<IList<string>>();
		foreach (var kvp in dict)
		{
			if (kvp.Value.Count > 1) l.Add(kvp.Value);
		}
		return l;
	}
}