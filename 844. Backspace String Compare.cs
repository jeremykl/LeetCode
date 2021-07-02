public class Solution
{
	public bool BackspaceCompare(string s, string t)
	{
		int s1 = s.Length - 1;
		int t1 = t.Length - 1;
		int skipS = 0;
		int skipT = 0;

		while (s1 >= 0 || t1 >= 0)
		{
			while (s1 >= 0)
			{
				if (s[s1] == '#')
				{
					skipS++;
					s1--;
				}
				else if (skipS > 0)
				{
					s1--;
					skipS--;
				}
				else
				{
					break;
				}
			}
			while (t1 >= 0)
			{
				if (t[t1] == '#')
				{
					skipT++;
					t1--;
				}
				else if (skipT > 0)
				{
					t1--;
					skipT--;
				}
				else
				{
					break;
				}
			}

			if (s1 >= 0 ^ t1 >= 0) return false;
			if ((s1 >= 0 && t1 >= 0) && (s[s1] != t[t1])) return false;
			s1--;
			t1--;
		}
		return true;
	}
}