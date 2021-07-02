public class Solution
{
	public int SecondHighest(string s)
	{
		bool[] digits = new bool[10];
		foreach (char c in s)
		{
			if (Char.IsNumber(c))
			{
				int digit = int.Parse(c.ToString());
				digits[digit] = true;
			}
		}
		bool ready = false;
		for (int i = digits.Length - 1; i >= 0; i--)
		{
			if (ready && digits[i]) return i;
			if (digits[i]) ready = digits[i];
		}
		return -1;
	}
}