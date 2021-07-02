/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution
{
	public IList<int> Preorder(Node root)
	{
		List<int> l = new List<int>();
		Helper(root, l);
		return l;
	}

	private void Helper(Node root, IList<int> l)
	{
		if (root == null) return;
		l.Add(root.val);
		foreach (var child in root.children)
		{
			Helper(child, l);
		}
	}
}