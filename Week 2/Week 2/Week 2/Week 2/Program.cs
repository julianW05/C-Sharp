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
            // Exercise 3-28---------------------------------------------
            Opd3_28();
            // ---------------------------------------------
            // Exercise 3-29---------------------------------------------
            Opd3_29();
            // ---------------------------------------------
            // Exercise 3-30---------------------------------------------
            Opd3_30();
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

        public static void Opd3_28()
        {
            Console.WriteLine("Type something");
            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    string[] parts = input.Split(' ');
                    if (parts.Length > 0)
                    {
                        Console.WriteLine(parts[parts.Length - 1]);
                    }
                }
            }
        }

        public static void Opd3_29()
        {
            int maxAge = 0;
            bool isFirstInput = true;

            while (true)
            {
                Console.Write("Enter name and age (or empty line to quit): ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    string[] parts = input.Split(',');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int age))
                    {
                        Console.WriteLine("Name: " + parts[0] + ", Age: " + age);
                        if (isFirstInput)
                        {
                            maxAge = age;
                            isFirstInput = false;
                        }
                        else if (age > maxAge)
                        {
                            maxAge = age;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter name and age separated by a comma.");
                    }
                }
            }

            Console.WriteLine("Age of the oldest: " + maxAge);
        }

        public static void Opd3_30()
        {
            string name = "";
            int maxAge = 0;
            bool isFirstInput = true;

            while (true)
            {
                Console.Write("Enter name and age (or empty line to quit): ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    string[] parts = input.Split(',');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int age))
                    {
                        Console.WriteLine("Name: " + parts[0] + ", Age: " + age);
                        if (isFirstInput)
                        {
                            name = parts[0];
                            maxAge = age;
                            isFirstInput = false;
                        }
                        else if (age > maxAge)
                        {
                            name = parts[0];
                            maxAge = age;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter name and age separated by a comma.");
                    }
                }
            }

            Console.WriteLine("name of the oldest: " + name);
        }
    }
}