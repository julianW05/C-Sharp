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
            // Exercise 4-21---------------------------------------------
            List<Book> books = new List<Book>();

            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                
                if (name == "")
                {
                    break;
                }

                Console.Write("Pages: ");
                int pages = int.Parse(Console.ReadLine());

                Console.Write("Publication year: ");
                int year = int.Parse(Console.ReadLine());

                books.Add(new Book(name, pages, year));
            }

            Console.Write("What information will be printed? ");
            string info = Console.ReadLine();

            if (info == "everything")
            {
                foreach (Book book in books)
                {
                    Console.WriteLine(book.GetDetails());
                }
            }
            else if (info == "title")
            {
                foreach (Book book in books)
                {
                    Console.WriteLine(book.GetTitle());
                }
            }
            // ---------------------------------------------
            // Exercise 4-22---------------------------------------------
            Opd4_22();
            // ---------------------------------------------
            // Exercise 4-23---------------------------------------------
            Opd4_23();
            // ---------------------------------------------
            // Exercise 4-24---------------------------------------------
            Opd4_24();
            // ---------------------------------------------
            // Exercise 4-26---------------------------------------------
            Opd4_26();
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

        public static void Opd3_31()
        {
            String name = "";
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
                        else if (age < maxAge)
                        {
                            maxAge = age;
                        }

                        if (isFirstInput)
                        {
                            name = parts[0];
                        }
                        else if (parts[0].Length > name.Length)
                        {
                            name = parts[0];
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter name and age separated by a comma.");
                    }
                }
            }

            maxAge = 2023 - maxAge;

            Console.WriteLine("Longest name: " + name);
            Console.WriteLine("Highest age: " + maxAge);
        }

        public static void Opd4_22()
        {
            int count = 0;
            Console.WriteLine("Input a string: ");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                if (string.IsNullOrWhiteSpace(input))
                {
                    
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public static void Opd4_23()
        {
            Console.WriteLine("Give a number");
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                if (int.TryParse(input, out int num))
                {
                    Console.WriteLine(num * num * num);
                }
            }
        }

        public static void Opd4_24()
        {
            string filePath = "C:\\Users\\julia\\OneDrive\\Bureaublad\\Documents\\school\\Leerjaar 2\\C#\\github repository\\C-Sharp\\Week 2\\Week 2\\Week 2\\Week 2\\Data.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine($"File {filePath} not found.");
            }
        }

        public static void Opd4_26()
        {
            System.Collections.Generic.IEnumerable<String> lines = File.ReadLines(@"C:\Users\julia\OneDrive\Bureaublad\Documents\school\Leerjaar 2\C#\github repository\C-Sharp\Week 2\Week 2\Week 2\Week 2\names.txt");
            System.Collections.Generic.IEnumerable<String> lines2 = File.ReadLines(@"C:\Users\julia\OneDrive\Bureaublad\Documents\school\Leerjaar 2\C#\github repository\C-Sharp\Week 2\Week 2\Week 2\Week 2\other-names.txt");
            string[] combined = lines.Concat(lines2).ToArray();

            Console.WriteLine("Enter names, an empty line quits.");

            while (true)
            {
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    break;
                }

                if (Array.Exists(combined, guest => guest.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("The name is on the list.");
                }
                else
                {
                    Console.WriteLine("The name is not on the list.");
                }
            }

            Console.WriteLine("\nThank you!");
        }
    }
}