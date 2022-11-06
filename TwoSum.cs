// Two Sum II - Input Array Is Sorted
public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int r = numbers.Length - 1;
        int l = 0;
        while (numbers[r] + numbers[l] != target)
        {
            if (numbers[r] + numbers[l] > target)
                r--;
            else
                l++;
        }
        return new int[] { l + 1, r + 1 };
    }
}