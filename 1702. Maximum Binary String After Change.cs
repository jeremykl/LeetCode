public class Solution
{
	public string MaximumBinaryString(string binary)
	{
		int zeros = 0, ones = 0;
		foreach (char c in binary)
		{
			if (c == '0')
			{
				zeros++;
			}
			else if (zeros == 0)
			{
				ones++;
			}
		}
		StringBuilder sb = new StringBuilder(new String('1', binary.Length));
		if (ones < binary.Length) sb[ones + zeros - 1] = '0';
		return sb.ToString();
	}
}