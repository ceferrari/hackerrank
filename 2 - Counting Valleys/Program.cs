using System;
using System.IO;

namespace CountingValleys
{
    class Program
    {
        static int Solution(int n, string s)
        {
            int currentLevel = 0;
            int numberOfValleys = 0;

            for (int i = 0; i < n; i++)
            {
                currentLevel += s[i] == 'U' ? 1 : -1;
                if (s[i] == 'U' && currentLevel == 0)
                {
                    numberOfValleys++;
                }
            }

            return currentLevel < 0 ? numberOfValleys++ : numberOfValleys;
        }

        static void Main(string[] args)
        {
            string outputPath = Environment.GetEnvironmentVariable("OUTPUT_PATH");
            TextWriter textWriter = string.IsNullOrEmpty(outputPath)
                ? textWriter = new StreamWriter(Console.OpenStandardOutput())
                : textWriter = new StreamWriter(outputPath, true);

            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int result = Solution(n, s);

            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }
    }
}
