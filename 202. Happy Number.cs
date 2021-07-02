public class Solution
{
	public bool IsHappy(int n)
	{
		HashSet<int> visited = new HashSet<int>();
		while (!visited.Contains(n))
		{
			visited.Add(n);
			int sum = 0;
			while (n != 0)
			{
				int val = n % 10;
				sum += val * val;
				n /= 10;
			}
			n = sum;
			if (n == 1) return true;
		}
		return false;
	}
}