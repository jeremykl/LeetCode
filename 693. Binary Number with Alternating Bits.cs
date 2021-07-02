public class Solution
{
	public bool HasAlternatingBits(int n)
	{
		string b = Convert.ToString(n, 2);
		for (int i = 0; i < b.Length - 1; i++)
		{
			if (b[i] == b[i + 1]) return false;
		}
		return true;
	}
}