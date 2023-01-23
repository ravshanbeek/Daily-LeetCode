namespace Daily_LeetCode;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] arr =  new int[]{ 0, 1,2,3,4,5 };
        Console.WriteLine(string.Join(",",solution.Shuffle(arr, arr.Length / 2 )));
    }
}