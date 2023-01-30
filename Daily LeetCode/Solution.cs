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

    public int ArrangeCoins(int n)
    {
        int sum = 0;
        int count = 0;

        while(n > 0)
        {
            sum += count;
            n -= count;
            count++;
        }
        return count;
    }

    public int MinimumSum(int num)
    {
        var arr = new int[4];
        int i = 0;
        while(num>0)
        {
            arr[i++] = num % 10;
            num /= 10;
        }
        arr = arr.OrderBy(x => x).ToArray();
        return arr[0] * 10 + arr[3] + arr[1]*10 + arr[2];
    }
    
    public int[] PivotArray(int[] nums, int pivot)
    {
        int left = 0, right = nums.Length - 1;
        int temp;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < pivot)
            {
                temp = nums[i];
                nums[i] = nums[left];
                nums[left++] = temp;
                
            }
        }
        for (int i = nums.Length-1; i > 0; i--)
        {
            if (nums[i] > pivot)
            {
                temp = nums[i];
                nums[i] = nums[right];
                nums[right] = temp;
                --right;
            }
        }
        return nums;
    }

    public int[] Sort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        return arr;
    }
    
    
    public bool IsStrictlyPalindromic(int n)
    {
        return n==0||n==1;
    }

    public int Tribonacci(int n)
    {
        if (n == 0)
            return 0;
        if (n == 1 || n == 2)
            return 1;
        int[] list = new int[n + 1];

        list[0] = 0;
        list[1] = 1;
        list[2] = 1;

        for (int i = 3; i <= n; i++)
        {
            list[i] = (list[i - 3] + list[i - 1] + list[i - 2]);
        }
        return list[n];
    }

}