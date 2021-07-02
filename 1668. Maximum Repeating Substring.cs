public class Solution
{
	public int MaxRepeating(string sequence, string word)
	{
		int count = 0;
		string tester = word;
		while (true)
		{
			if (sequence.Contains(tester))
			{
				count++;
				tester += word;
			}
			else
			{
				break;
			}
		}
		return count;
	}
}