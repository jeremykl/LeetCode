public class Solution
{
	public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
	{
		if (image[sr][sc] != newColor) fill(image, sr, sc, newColor, image[sr][sc]);
		return image;
	}

	private void fill(int[][] image, int sr, int sc, int newColor, int oldColor)
	{
		if (image[sr][sc] != oldColor) return;
		image[sr][sc] = newColor;

		// up
		if (sr > 0)
		{
			fill(image, sr - 1, sc, newColor, oldColor);
		}
		// down
		if (sr < image.Length - 1)
		{
			fill(image, sr + 1, sc, newColor, oldColor);
		}
		// left
		if (sc > 0)
		{
			fill(image, sr, sc - 1, newColor, oldColor);
		}
		// right
		if (sc < image[sr].Length - 1)
		{
			fill(image, sr, sc + 1, newColor, oldColor);
		}
	}
}