public class MinStack
{
	private Stack<int> stack, minStack;
	/** initialize your data structure here. */
	public MinStack()
	{
		stack = new Stack<int>();
		minStack = new Stack<int>();
	}

	public void Push(int val)
	{
		stack.Push(val);
		if (minStack.Count == 0 || val < minStack.Peek())
		{
			minStack.Push(val);
		}
		else
		{
			minStack.Push(minStack.Peek());
		}
	}

	public void Pop()
	{
		minStack.Pop();
		stack.Pop();
	}

	public int Top()
	{
		return stack.Peek();
	}

	public int GetMin()
	{
		return minStack.Peek();
	}
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */