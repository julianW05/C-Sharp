using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Opdracht
{
    public class StartMenus
    {
        public void StartMainMenu() { 
            Console.Clear();
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to the world of C#!");
            Console.ResetColor();
            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            var decorator = "✅ \u001b[32m";
            ConsoleKeyInfo key;
            bool isSelected = false;

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);

                Console.WriteLine($"{(option == 1 ? decorator : "   ")}Afspeellijsten\u001b[0m");
                Console.WriteLine($"{(option == 2 ? decorator : "   ")}Nummers\u001b[0m");
                Console.WriteLine($"{(option == 3 ? decorator : "   ")}Albums\u001b[0m");
                Console.WriteLine($"{(option == 4 ? decorator : "   ")}Vrienden\u001b[0m");

                key = Console.ReadKey(false);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        option = option == 1 ? 4 : option - 1;
                        break;

                    case ConsoleKey.DownArrow:
                        option = option == 4 ? 1 : option + 1;
                        break;

                    case ConsoleKey.Enter:
                        isSelected = true;
                        break;
                }
            }
            if (option == 1)
            {
                Console.WriteLine("Afspeellijsten");
            }
            else if (option == 2)
            {
                Console.WriteLine("Nummers");
            }
            else if (option == 3)
            {
                Console.WriteLine("Albums");
            }
            else if (option == 4)
            {
                StartFriendMenu();
            }
            else { Console.WriteLine("iets is mis gegaan."); }
        }
        static void StartFriendMenu() {
            Console.Clear();
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Vrienden");
            Console.ResetColor();
            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            var decorator = "✅ \u001b[32m";
            ConsoleKeyInfo key;
            bool isSelected = false;

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);

                Console.WriteLine($"{(option == 1 ? decorator : "   ")}Afspeellijsten van vrienden\u001b[0m");
                Console.WriteLine($"{(option == 2 ? decorator : "   ")}Nummers van vrienden\u001b[0m");

                key = Console.ReadKey(false);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        option = option == 1 ? 2 : option - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        option = option == 2 ? 1 : option + 1;
                        break;

                    case ConsoleKey.Enter:
                        isSelected = true;
                        break;
                    case ConsoleKey.Backspace:
                        StartMenus startMenus = new StartMenus();
                        startMenus.StartMainMenu();
                        break;
                }
            }
        }
    }
}
