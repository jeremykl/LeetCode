public class Solution
{
	public bool SquareIsWhite(string coordinates)
	{
		int a = (int)'a';
		// odd is white, even is black
		int num = int.Parse(coordinates[1].ToString());
		int letter = (int)coordinates[0] - a + 1;
		return ((num + letter) % 2) != 0;
	}
}