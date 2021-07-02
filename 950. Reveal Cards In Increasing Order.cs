public class Solution
{
	public int[] DeckRevealedIncreasing(int[] deck)
	{
		Array.Sort(deck);
		int[] result = new int[deck.Length];
		Queue<int> q = new Queue<int>();
		for (int i = 0; i < deck.Length; i++)
		{
			q.Enqueue(i);
		}

		int card = 0;
		while (q.Count > 0)
		{
			int i = q.Dequeue();
			result[i] = deck[card];

			if (q.Count > 0) q.Enqueue(q.Dequeue());
			card++;
		}
		return result;
	}
}