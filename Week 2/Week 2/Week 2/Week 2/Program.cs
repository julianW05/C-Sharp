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
            // Exercise 3-21---------------------------------------------
            int[] array = { 5, 1, 3, 4, 2 };
            PrintArrayInStars(array);
            // ---------------------------------------------
        }

        static void RemoveLast(List<string> words)
        {
            if (words.Count > 0)
            {
                words.RemoveAt(words.Count - 1);
            }
        }

        public static void PrintArrayInStars(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                string stars = new string('*', array[i]);
                Console.WriteLine(stars);
            }
        }
    }
}