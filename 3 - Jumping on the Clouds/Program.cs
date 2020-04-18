using System;
using System.IO;

namespace JumpingOnTheClouds
{
    class Program
    {
        static int Solution(int n, int[] ar)
        {
            int count = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (ar[i] == 0)
                {
                    int j = i + 2;
                    if (j < n && ar[j] == 0)
                    {
                        count++;
                        i++;
                    }
                    else if (ar[i + 1] == 0)
                    {
                        count++;
                    }
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
