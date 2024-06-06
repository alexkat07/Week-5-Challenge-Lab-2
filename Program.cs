using System.Globalization;

namespace Week_5_Challenge_Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] nums = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };

            int n = nums.Length;

            int ans = ( n * (n + 1)) / 2;


            int missingValue = ans - nums.Sum();

            Console.WriteLine(missingValue);
        }
    }
}
