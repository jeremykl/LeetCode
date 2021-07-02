public class Solution
{
	private string[] phone = new string[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
	public IList<string> LetterCombinations(string digits)
	{
		List<string> result = new List<string>();
		if (digits != "")
		{
			helper(result, "", 0, digits);
		}
		return result;
	}

	private void helper(IList<string> result, string current, int index, string digits)
	{
		if (index == digits.Length)
		{
			result.Add(current);
		}
		else
		{
			for (int i = 0; i < phone[int.Parse(digits[index].ToString())].Length; i++)
			{
				helper(result, current + phone[int.Parse(digits[index].ToString())][i], index + 1, digits);
			}
		}
	}
}