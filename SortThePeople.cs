//Sort the People
public class Solution
{
    public string[] SortPeople(string[] names, int[] heights)
    {
        Dictionary<int, string> d = new Dictionary<int, string>();
        for (int i = 0; i < heights.Length; i++)
        {
            d.Add(heights[i], names[i]);
        }
        Array.Sort(heights);
        for (int i = 0; i < heights.Length; i++)
        {
            names[i] = d[heights[heights.Length - i - 1]];
        }
        return names;
    }
}