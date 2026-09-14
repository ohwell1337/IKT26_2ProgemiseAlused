using System;
using System.Threading;

namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta enda vanus");

            // Loeb kasutaja inputi
            string input = Console.ReadLine() ?? "";

            // Kontrollib, kas kasutaja kirjutas numbri
            if (int.TryParse(input, out int age))
            {
                // Vanuse kontroll
                if (age >= 18)
                {
                    RainbowText("unc age");
                }
                else
                {
                    RainbowText("noor oled");
                    Console.Beep();
                }
            }
            else
            {
                Console.WriteLine("Palun kirjuta number!");
            }

            Console.ResetColor();
        }

        static void RainbowText(string text)
        {
            ConsoleColor[] colors =
            {
                ConsoleColor.Red,
                ConsoleColor.Yellow,
                ConsoleColor.Green,
                ConsoleColor.Cyan,
                ConsoleColor.Blue,
                ConsoleColor.Magenta
            };

            // Rainbow animatsioon
            for (int i = 0; i < 3342342340; i++)
            {
                Console.Clear();

                Console.ForegroundColor = colors[i % colors.Length];

                Console.WriteLine(text);

                Thread.Sleep(20);
            }
        }
    }
}
