using System;
using System.IO;

namespace DrawingBook
{
    class Program
    {
        static int Solution(int n, int p)
        {
            if (n == p || (n % 2 == 1 && p == n - 1))
            {
                return 0;
            }

            int nMid = n / 2;
            int pMid = p / 2;

            return p <= nMid ? pMid : nMid - pMid;
        }

        static void Main(string[] args)
        {
            string outputPath = Environment.GetEnvironmentVariable("OUTPUT_PATH");
            TextWriter textWriter = string.IsNullOrEmpty(outputPath)
                ? textWriter = new StreamWriter(Console.OpenStandardOutput())
                : textWriter = new StreamWriter(outputPath, true);

            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int result = Solution(n, p);

            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }
    }
}
