public class Solution
{
    public int Divide(int dividend, int divisor)
    {
        bool isMinus = false;
        int result = 0;

        if (dividend * divisor < 0)
        {
            isMinus = true;
        }
        dividend = Math.Abs(dividend);
        divisor = Math.Abs(divisor);

        while (dividend >= divisor)
        {
            dividend -= divisor;
            result++;
        }

        if (isMinus)
            return -result;

        return result;
    }
    public int FindContentChildren(int[] g, int[] s)
    {
        int count = 0,j = 0, i = 0;

        Array.Sort(s);
        Array.Sort(g);

        while(i < g.Length && j < s.Length)
        {
            if (s[j] >= g[i])
            {
                j++;
                count++;
                i++;
            }
            else
            {
                j++;
            }
        }
        return count;
    }
    public int CountPrimes(int n)
    {
        if(n <= 2) return 0;

        List<int> list = new List<int>();

        list.Add(2);

        bool isPrime = false;
        for(int i = 3; i < n; i+=2)
        {
            isPrime = true;  
            foreach(int j in list)
            {
                if (j > Math.Sqrt(i))
                    break;
                if(i%j==0)
                {
                    isPrime = false;
                    break;
                }
            }
            if(isPrime) 
                list.Add(i);
        }
        return list.Count;
    }
    public int Fib(int n)
    {
        if (n == 0) return 0;
        if(n == 1) return 1;

        int[] fibNums = new int[n + 1];

        fibNums[0] = 0;
        fibNums[1] = 1;

        for(int i = 2; i <= n; i++)
           fibNums[i] = fibNums[i - 1] + fibNums[i - 2];

        return fibNums[n];
        
    }
    public int LengthOfLastWord(string s)
    {
        string str = s.Trim();
        return str.Length - str.LastIndexOf(' ') - 1;
    }
    public bool IsNumber(string s)
    {
        if (s == "Infinity" || s == "-Infinity" || s == "+Infinity")
            return false;
        if (int.TryParse(s, out int n) || double.TryParse(s, out double num))
            return true;
        return false;
    }
    public int FirstMissingPositive(int[] nums)
    {
        var list = nums.OrderBy(x => x).ToList();

        if (!list.Contains(1))
            return 1;

        var k = list.SkipWhile(x => x <= 0).ToList();

        for(int i = 0; i < k.Count - 1; i++)
        {
            if (k[i+1] - k[i] > 1)
                return k[i]+1;
        }

        return k[k.Count-1] + 1;
    }
    public int ThirdMax(int[] nums)
    {
        var list = nums.OrderByDescending(x => x).Distinct().ToList();
                
        if(list.Count < 3)
            return list[0];
        
        return list[2];
    }
    public char FindTheDifference(string s, string t)
    {
        var s1 = s.OrderBy(x => x).ToArray();
        var s2 = t.OrderBy(x => x).ToArray();

        for(int i = 0; i < s.Length; i ++)
        {
            if (s1[i] != s2[i])
            {
                Console.WriteLine(s2[i]);
                return s2[i];
            }
        }

        return s2[s2.Length-1];
    }
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var list = new List<int>();
        var set = new HashSet<int>();

        foreach(var i in nums1)
        {
            if(!set.Contains(i))
                set.Add(i);
        }
        nums2 = nums2.Distinct().ToArray();

        foreach(var i in nums2)
        {
            if(set.Contains(i))
                list.Add(i);
        }
        return list.ToArray();
    }
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var list = new List<int>();
        var dict = new Dictionary<int, int>();

        foreach(var i in nums1)
        {
            if(!dict.ContainsKey(i))
                dict.Add(i, 0);
            dict[i]++;
        }

        foreach(var i in nums2)
        {
            if(dict.ContainsKey(i))
            {
                if (dict[i] > 0)
                {
                    list.Add(i);
                    dict[i]--;
                }
            }
        }
        return list.ToArray();
    }
    public int MajorityElement(int[] nums)
    {
        var dict = new Dictionary<int, int>();

        int half = nums.Length / 2;

        foreach(var i in nums)
        {
            if(!dict.ContainsKey(i))
                dict.Add(i, 0);
            dict[i] ++;
        }

        int max = 0;
        int index = 0;

        foreach(var i in nums)
        {
            if (dict[i] > max)
            {
                max = dict[i];
                index = i;
            }
        }
        return index;
    }
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
    public bool IsLeapYear(int year)
    {
        return year % 400 == 0 || (year % 100 != 0 && year % 4 == 0);
    }
}