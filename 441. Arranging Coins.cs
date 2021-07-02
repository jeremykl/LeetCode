public class Solution
{
	public int ArrangeCoins(int n)
	{
		int count = 0;
		int height = 1;
		while (n > 0)
		{
			n -= height;
			count += n >= 0 ? 1 : 0;
			height++;
		}
		return count;
	}
}