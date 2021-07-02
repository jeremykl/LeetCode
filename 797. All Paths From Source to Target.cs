public class Solution
{
	public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
	{
		List<IList<int>> paths = new List<IList<int>>();
		foreach (int i in graph[0])
		{
			List<int> currentPath = new List<int>();
			currentPath.Add(0);
			currentPath.Add(i);
			DFS(currentPath, paths, graph);
		}
		return paths;
	}

	private void DFS(List<int> currentPath, List<IList<int>> paths, int[][] graph)
	{
		if (currentPath[currentPath.Count - 1] == graph.Length - 1)
		{
			paths.Add(new List<int>(currentPath));
			return;
		}
		foreach (int i in graph[currentPath[currentPath.Count - 1]])
		{
			currentPath.Add(i);
			DFS(currentPath, paths, graph);
			currentPath.RemoveAt(currentPath.Count - 1);
		}
	}
}