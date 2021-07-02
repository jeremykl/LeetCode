/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution
{
	private Dictionary<int, Node> dict = new Dictionary<int, Node>();
	public Node CloneGraph(Node node)
	{
		return clone(node);
	}

	private Node clone(Node node)
	{
		if (node == null) return null;

		if (dict.ContainsKey(node.val)) return dict[node.val];

		Node clonee = new Node(node.val);
		dict[node.val] = clonee;
		foreach (var neighbor in node.neighbors)
		{
			clonee.neighbors.Add(clone(neighbor));
		}
		return clonee;
	}
}