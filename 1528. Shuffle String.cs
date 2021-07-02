public class Solution
{
	public string RestoreString(string s, int[] indices)
	{
		char[] resultAsArray = new char[s.Length];
		for (int i = 0; i < s.Length; i++)
		{
			resultAsArray[indices[i]] = s[i];
		}
		return string.Join("", resultAsArray);
	}
}