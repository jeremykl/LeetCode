public class Solution
{
	public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
	{
		int count = 0;
		foreach (var item in items)
		{
			switch (ruleKey)
			{
				case "type":
					count += item[0] == ruleValue ? 1 : 0;
					break;
				case "color":
					count += item[1] == ruleValue ? 1 : 0;
					break;
				case "name":
					count += item[2] == ruleValue ? 1 : 0;
					break;
				default:
					Console.WriteLine("Uhhhhhh");
					break;
			}
		}
		return count;
	}
}