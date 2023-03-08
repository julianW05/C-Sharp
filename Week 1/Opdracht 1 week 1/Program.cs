namespace Opdracht_1_week_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            opd1_10();
            opd1_15();
            opd1_23();
            opd1_33();
            opd1_40();

            opd2_4();
            opd2_8();
            opd2_11(6);
            int answer = opd2_17(2, 5, 7, 5);
            Console.WriteLine("Sum: " + answer);
            opd2_20(10);
            opd2_21(12);
        }

        static void opd1_10()
        {
            Console.WriteLine("I will tell a story, but I need some information.");

            Console.WriteLine("Give a name for main character:");
            string mainCharacter = Console.ReadLine();

            Console.WriteLine("Give the character a profession:");
            string profession = Console.ReadLine();

            Console.WriteLine("Here is the story:");
            Console.WriteLine("Once upon a time there was a " + profession + " called " + mainCharacter + "\n" +
                "On her way to work, " + mainCharacter + " often pondered what being " + profession + " meant to them.\n" +
                "When you work as a " + profession + " you meet interesting people.\n" +
                mainCharacter + " enjoys their work as " + profession + ", The end.\n" + "");
        }

        static void opd1_15()
        {
            //Opdracht 1-15
            Console.WriteLine("Give a string: ");
            string stringInput = Console.ReadLine();

            Console.WriteLine("Give an integer: ");
            string intInput = Console.ReadLine();
            int intValue = Convert.ToInt32(intInput);

            Console.WriteLine("Give an double: ");
            string doubleInput = Console.ReadLine();
            double doubleValue = Convert.ToDouble(doubleInput);

            Console.WriteLine("Give an boolean: ");
            string boolInput = Console.ReadLine();
            bool boolValue = Convert.ToBoolean(boolInput);

            Console.WriteLine("Your string: " + stringInput);
            Console.WriteLine("Your integer: " + intValue);
            Console.WriteLine("Your double: " + doubleValue);
            Console.WriteLine("Your boolean: " + boolValue);
        }

        static void opd1_23()
        {
            //Opdracht 1-23
            Console.WriteLine("Give the first number!: ");
            string doubleInput = Console.ReadLine();
            double doubleValue = Convert.ToDouble(doubleInput);

            Console.WriteLine("Give the second number!: ");
            string doubleInput2 = Console.ReadLine();
            double doubleValue2 = Convert.ToDouble(doubleInput2);

            Console.WriteLine(doubleValue + " + " + doubleValue2 + " = " + (doubleValue + doubleValue2));
            Console.WriteLine(doubleValue + " - " + doubleValue2 + " = " + (doubleValue - doubleValue2));
            Console.WriteLine(doubleValue + " * " + doubleValue2 + " = " + (doubleValue * doubleValue2));
            Console.WriteLine(doubleValue + " / " + doubleValue2 + " = " + (doubleValue / doubleValue2));
        }

        static void opd1_33()
        {
            //Opdracht 1-33
            Console.WriteLine("Give the first string!: ");
            string input1 = Console.ReadLine();

            Console.WriteLine("Give the second string!: ");
            string input2 = Console.ReadLine();

            if (input1 == input2)
            {
                Console.WriteLine("Echo!");
            }
            else
            {
                Console.WriteLine("Nope!");
            }
        }

        static void opd1_40()
        {
            //Opdracht 1-40
            int sum = 0;
            int amount = 0;

            while (true)
            {
                Console.WriteLine("Give a number: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 0)
                {
                    break;
                }
                else
                {
                    amount++;
                    sum = sum + input;
                    continue;
                }
            }

            Console.WriteLine("Total sum of numbers: " + sum);
            Console.WriteLine("Total amount of numbers: " + amount);
        }
        static void opd2_4()
        {
            Console.WriteLine("Give a number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give another number");
            int number2 = Convert.ToInt32(Console.ReadLine());


            if (number1 > number2)
            {
                Console.WriteLine(number1 + " is greater than " + number2);
            }
            else if (number1 < number2)
            {
                Console.WriteLine(number1 + " is less than " + number2);
            }
            else if (number2 == number1)
            {
                Console.WriteLine(number1 + " is equal to " + number2);
            }
        }

        static void opd2_8()
        {
            //Opdracht 2-8
            int sum = 0;
            int amount = 0;
            double avarage = 0;
            int even = 0;
            int odd = -1;

            Console.WriteLine("Give numbers: ");

            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }

                if (input == -1)
                {
                    break;
                }
                else
                {
                    amount++;
                    sum = sum + input;
                    avarage = (double)sum / (double)amount;
                    continue;
                }

            }

            Console.WriteLine("Thx! Bye!");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Numbers: " + amount);
            Console.WriteLine("Avarage: " + avarage);
            Console.WriteLine("Even: " + even);
            Console.WriteLine("Odd: " + odd);
        }

        public static void opd2_11(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i + 1);
            }
        }

        public static int opd2_17(int number1, int number2, int number3, int number4)
        {
            //Opdracht 2-17
            int sum = number1 + number2 + number3 + number4;
            return sum;
        }

        public static void opd2_20(int number)
        {
            for (int i = 0;i < number; i++)
            {
                Console.Write("*");
            }
        }

        //Opdracht 2-21 -----------------------------------------------
        public static void PrintSpaces(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(" ");
            }
        }

        public static void PrintTriangle(int size)
        {
            int o = size;
            int u = 1;

            PrintSpaces(o);
            opd2_20(1);
            Console.WriteLine("");

            for (int i = 0; i < size; i++)
            {
                o--;
                u = u + 2;

                PrintSpaces(o);
                opd2_20(u);
                Console.WriteLine("");
            }

            PrintSpaces(size - 1);
            opd2_20(3);
            Console.WriteLine("");

            PrintSpaces(size - 1);
            opd2_20(3);
            Console.WriteLine("");
        }

        public static void opd2_21(int size)
        {
            PrintTriangle(size);
        }
    }
}