using System;
using System.IO;

namespace UtopianTree
{
    class Program
    {
        static int Solution(int n)
        {
            return (int)Math.Pow(2, (n + 1) / 2 + 1) - (n % 2 == 0 ? 1 : 2);
        }

        static void Main(string[] args)
        {
            string outputPath = Environment.GetEnvironmentVariable("OUTPUT_PATH");
            TextWriter textWriter = string.IsNullOrEmpty(outputPath)
                ? textWriter = new StreamWriter(Console.OpenStandardOutput())
                : textWriter = new StreamWriter(outputPath, true);

            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int result = Solution(n);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
