public class Solution
{
	public bool Find132pattern(int[] nums)
	{
		int s3 = int.MinValue;
		Stack<int> st = new Stack<int>();
		for (int i = nums.Length - 1; i >= 0; i--)
		{
			if (nums[i] < s3) return true;
			else while (st.Count > 0 && nums[i] > st.Peek())
				{
					s3 = st.Pop();
				}
			st.Push(nums[i]);
		}
		return false;
	}
}