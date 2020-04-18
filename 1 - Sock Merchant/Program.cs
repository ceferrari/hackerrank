using System;
using System.Collections.Generic;
using System.IO;

namespace SockMerchant
{
    class Program
    {
        static int Solution(int n, int[] ar)
        {
            int count = 0;
            HashSet<int> hashSet = new HashSet<int>();

            foreach (int x in ar)
            {
                if (!hashSet.Add(x))
                {
                    count++;
                    hashSet.Remove(x);
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            string outputPath = Environment.GetEnvironmentVariable("OUTPUT_PATH");
            TextWriter textWriter = string.IsNullOrEmpty(outputPath)
                ? textWriter = new StreamWriter(Console.OpenStandardOutput())
                : textWriter = new StreamWriter(outputPath, true);

            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = Solution(n, ar);

            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }
    }
}
