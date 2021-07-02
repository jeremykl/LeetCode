public class Solution
{
	public IList<int> AddToArrayForm(int[] num, int k)
	{
		List<int> l = new List<int>(num.Length + 4);
		int i = num.Length - 1;
		while (i >= 0 || k > 0)
		{
			if (i >= 0) k += num[i];
			l.Add(k % 10);
			k /= 10;
			i--;
		}
		l.Reverse();
		return l.ToList();
	}
}