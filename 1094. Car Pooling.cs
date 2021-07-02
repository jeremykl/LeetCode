public class Solution
{
	public bool CarPooling(int[][] trips, int capacity)
	{
		var sortedDict = new SortedDictionary<int, int>();
		foreach (var trip in trips)
		{
			if (!sortedDict.ContainsKey(trip[1])) sortedDict[trip[1]] = 0;
			if (!sortedDict.ContainsKey(trip[2])) sortedDict[trip[2]] = 0;
			sortedDict[trip[1]] += trip[0];
			sortedDict[trip[2]] -= trip[0];
		}
		int count = 0;
		foreach (var kvp in sortedDict)
		{
			count += kvp.Value;
			if (count > capacity) return false;
		}
		return true;
	}
}