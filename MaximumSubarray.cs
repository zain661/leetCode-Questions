//Maximum Subarray
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int currentSum = nums[0], maxSum = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {

            if (nums[i] > nums[i] + currentSum)
            {
                currentSum = nums[i];
            }
            else
            {
                currentSum = nums[i] + currentSum;
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }
        return maxSum;
    }
}