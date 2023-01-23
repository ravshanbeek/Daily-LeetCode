public class Solution
{
    public int[] BuildArray(int[] nums)
    {
        int[] arr = new int[nums.Length];

        for(int i = 0; i < nums.Length;i++)
        {
            arr[i] = nums[nums[i]];
        }

        return arr;
    }

    public int[] GetConcatenation(int[] nums)
    {
        int length = nums.Length;
        int[] arr = new int[2 * length];

        for(int i = 0; i < nums.Length;i++)
        {
            arr[i] = nums[i];
            arr[i + length] = nums[i];
        }
        return arr;
    }
    //  123456
    //  14

    public int[] Shuffle(int[] nums, int n)
    {
        int[] arr = new int[2*n];
        
        for(int i = 0; i < n;i++)
        {
            arr[2*i] = nums[i];
            arr[2*i+1] = nums[i+n];
        }

        return arr;
    }
}