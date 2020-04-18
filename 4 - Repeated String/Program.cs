using System;
using System.IO;

namespace RepeatedString
{
    class Program
    {
        static long Solution(string s, long n)
        {
            long count = 0;
            long len = s.Length;
            long div = n / s.Length;
            long mod = n % s.Length;

            foreach (char c in s)
            {
                if (c == 'a')
                {
                    count++;
                }
            }

            count *= div;

            for (int i = 0; i < mod; i++)
            {
                if (s[i] == 'a')
                {
                    count++;
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

            string s = Console.ReadLine();
            long n = Convert.ToInt64(Console.ReadLine());
            long result = Solution(s, n);

            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }
    }
}
