public class Solution
{
	public string AddStrings(string num1, string num2)
	{
		int carry = 0;
		int n1 = num1.Length - 1;
		int n2 = num2.Length - 1;
		StringBuilder sb = new StringBuilder();
		while (n1 >= 0 || n2 >= 0 || carry > 0)
		{
			int current = (n1 >= 0 ? int.Parse(num1[n1].ToString()) : 0) + (n2 >= 0 ? int.Parse(num2[n2].ToString()) : 0);
			if ((current + carry) / 10 > 0)
			{
				sb.Append((current + carry) % 10);
			}
			else
			{
				sb.Append(current + carry);
			}
			carry = (current + carry) / 10;
			n1--;
			n2--;
		}
		return string.Join("", sb.ToString().Reverse().ToArray());
	}
}