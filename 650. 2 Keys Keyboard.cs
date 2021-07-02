public class Solution
{
	public int MinSteps(int n)
	{
		return helper(n, "A", "");
	}

	private int helper(int n, string current, string paste)
	{
		if (current.Length > n) return 1000;
		if (current.Length == n) return 0;
		int pasta = paste != "" ? helper(n, current + paste, paste) : 1000;
		int copy = current == paste ? 1000 : helper(n, current, current);
		return Math.Min(copy, pasta) + 1;
	}
}