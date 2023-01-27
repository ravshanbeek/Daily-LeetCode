public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine (string.Join(",", solution.PivotArray(new int[] {9,12,5,10,13,0,3,10,15,16,17},10)));
    }
}