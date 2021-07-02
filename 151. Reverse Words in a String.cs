public class Solution
{
	public string ReverseWords(string s)
	{
		if (string.IsNullOrWhiteSpace(s)) return "";
		// Remove leading and ending whitespace
		s = s.Trim();
		char[] str = s.ToCharArray();
		// Reverse the whole char array
		Reverse(str);
		int counter = 0;
		StringBuilder result = new StringBuilder();
		while (counter < str.Length)
		{
			if (str[counter] == ' ')
			{
				counter++;
				continue;
			}
			// Reverse section between start ane the next space
			int start = counter;
			while (counter < str.Length && str[counter] != ' ')
			{
				counter++;
			}

			for (int i = counter - 1; i >= start; i--)
			{
				result.Append(str[i]);
			}
			if (counter != str.Length) result.Append(' ');
		}

		return result.ToString();
	}


	private void Reverse(char[] str)
	{
		int lo = 0;
		int hi = str.Length - 1;
		while (lo < hi)
		{
			char tmp = str[hi];
			str[hi] = str[lo];
			str[lo] = tmp;
			lo++;
			hi--;
		}
	}
}