using Microsoft.VisualBasic;

namespace Week_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 3-16---------------------------------------------
            List<string> words = new List<string>();

            words.Add("First");
            words.Add("Second");
            words.Add("Third");

            words.ForEach(Console.WriteLine);

            RemoveLast(words);
            RemoveLast(words);

            words.ForEach(Console.WriteLine);
            // ---------------------------------------------
        }

        static void RemoveLast(List<string> words)
        {
            if (words.Count > 0)
            {
                words.RemoveAt(words.Count - 1);
            }
        }
    }
}