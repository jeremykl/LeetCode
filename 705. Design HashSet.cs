public class MyHashSet
{
	List<int>[] data;
	int size = 3200;
	/** Initialize your data structure here. */
	public MyHashSet()
	{
		data = new List<int>[size];
	}

	public void Add(int key)
	{
		if (data[key % size] == null)
		{
			data[key % size] = new List<int>();
		}
		if (!this.Contains(key)) data[key % size].Add(key);
	}

	public void Remove(int key)
	{
		if (!this.Contains(key)) return;
		data[key % size].Remove(key);
	}

	/** Returns true if this set contains the specified element */
	public bool Contains(int key)
	{
		if (data[key % size] == null)
		{
			return false;
		}
		return data[key % size].Contains(key);
	}
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */