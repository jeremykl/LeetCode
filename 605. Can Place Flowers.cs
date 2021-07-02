public class Solution
{
	public bool CanPlaceFlowers(int[] flowerbed, int n)
	{
		int tracker = 1;
		int count = 0;
		for (int i = 0; i < flowerbed.Length; i++)
		{
			if (flowerbed[i] == 0)
			{
				tracker++;
			}
			else
			{
				tracker = 0;
			}
			if (tracker == 3 || (tracker == 2 && i == flowerbed.Length - 1))
			{
				count++;
				tracker = 1;
			}
			if (count >= n) return true;
		}
		return count >= n;
	}
}