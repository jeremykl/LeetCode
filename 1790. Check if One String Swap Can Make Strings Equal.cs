public class Solution
{
	public bool AreAlmostEqual(string s1, string s2)
	{
		int[] swap = new int[2];
		int index = 0;
		for (int i = 0; i < s1.Length; i++)
		{
			if (s1[i] != s2[i])
			{
				if (index >= 2) return false;
				swap[index++] = i;
			}
		}
		StringBuilder sb = new StringBuilder(s1);
		sb[swap[0]] = s1[swap[1]];
		sb[swap[1]] = s1[swap[0]];
		return sb.ToString() == s2;
	}
}