public class Solution
{
	public int UniqueMorseRepresentations(string[] words)
	{
		string[] morse = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
		HashSet<string> hs = new HashSet<string>();
		foreach (string word in words)
		{
			StringBuilder sb = new StringBuilder();
			foreach (char c in word)
			{
				sb.Append(morse[c - 'a']);
			}
			hs.Add(sb.ToString());
		}
		return hs.Count;
	}
}