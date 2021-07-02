public class Solution
{
	public string LongestPalindrome(string s)
	{
		if (s == null || s.Length < 1) return "";
		int start = 0, end = 0;
		for (int i = 0; i < s.Length; i++)
		{
			// odd length substrings
			int len1 = palindromeAbout(s, i, i);
			// even length substrings
			int len2 = palindromeAbout(s, i, i + 1);
			int len = Math.Max(len1, len2);
			if (len > end - start)
			{
				// Get start and end postions based on where we are and the length of this newest palindrome 
				start = i - (len - 1) / 2;
				end = i + len / 2;
			}
		}
		return s.Substring(start, end - start + 1);
	}

	private int palindromeAbout(string s, int L, int R)
	{
		while (L >= 0 && R < s.Length && s[L] == s[R])
		{
			L--;
			R++;
		}
		return R - L - 1;
	}
}