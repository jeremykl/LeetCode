public class Solution
{
	public int[][] ReconstructQueue(int[][] people)
	{
		List<int> map = Enumerable.Range(0, people.Length).ToList();

		foreach (int[] person in people.OrderBy(x => x[0]).ThenByDescending(x => x[1]))
		{
			people[map[person[1]]] = new int[] { person[0], person[1] };
			map.RemoveAt(person[1]);
		}
		return people;
	}
}