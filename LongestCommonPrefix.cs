//Longest Common Prefix
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string ans = "";
        Array.Sort(strs);
        string a = strs[0];
        string b = strs[strs.Length - 1];
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == b[i])
            {
                ans += a[i];
            }
            else
                break;
        }
        return ans;
    }
}