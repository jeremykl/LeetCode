/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution
{
	public Node CopyRandomList(Node head)
	{
		// Create dupes after each node;
		Node iter = head;
		while (iter != null)
		{
			Node dupe = new Node(iter.val);
			dupe.next = iter.next;
			iter.next = dupe;
			iter = iter.next.next;
		}

		// Point to random after initial node's random
		iter = head;
		while (iter != null)
		{
			if (iter.random != null)
			{
				iter.next.random = iter.random.next;
			}
			iter = iter.next.next;
		}

		// Split the two
		iter = head;
		Node dummyDupeHead = new Node(-1);
		Node dupeIter = dummyDupeHead;

		while (iter != null)
		{
			dupeIter.next = iter.next;
			iter.next = iter.next.next;
			iter = iter.next;
			dupeIter = dupeIter.next;
		}


		return dummyDupeHead.next;
	}
}