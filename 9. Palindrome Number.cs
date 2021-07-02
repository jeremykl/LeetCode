public class Solution
{
	public bool IsPalindrome(int x)
	{
		if (x < 0)
		{
			return false;
		}
		List<int> numberInPieces = new List<int>();
		while (x > 0)
		{
			numberInPieces.Add(x % 10);
			x /= 10;
		}
		int length = numberInPieces.Count;

		for (int i = 0; i < length / 2; i++)
		{
			if (numberInPieces[i] != numberInPieces[length - i - 1])
			{
				return false;
			}
		}
		return true;
	}
}