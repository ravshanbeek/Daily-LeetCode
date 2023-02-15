using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace WriteTextOnImageExample
{
    class Program
    {
        private static string TableBuilder(List<string> challengers)
        {
            var builder = new StringBuilder();
            builder.AppendLine(String.Format("|{0,29}", " ") + "REPORT OF TODAY");

            builder.AppendLine($"<pre>|{new string('-', 27)}|{new string('-', 8)}|{new string('-', 8)}|{new string('-', 13)}|");

            builder.AppendLine(String.Format("| {0, -25} | {1, -6} | {2, -6} | {3, -13}|",
                "UserName", "Heart", "Today", "TotalSolved"));

            builder.AppendLine($"|{new string('-', 27)}|{new string('-', 8)}|{new string('-', 8)}|{new string('-', 13)}|");

            foreach (var challanger in challengers)
            {
                builder.AppendLine(String.Format("| {0, -25} | {1, -6} | {2, -6} | {3, -13}|",
                    challanger, 3, 12, 214));
            }

            return builder.ToString() + "</pre>";
        }
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.IsIsomorphic("egsd","adfd"));
        }
    }
}