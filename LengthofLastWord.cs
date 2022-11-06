//Length of Last Word
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int c = 0, flag = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ' && flag == 0)
            {
                continue;
            }
            if (s[i] != ' ')
            {
                c++;
                flag = 1;
            }
            else
                break;
        }
        return c;
    }

}