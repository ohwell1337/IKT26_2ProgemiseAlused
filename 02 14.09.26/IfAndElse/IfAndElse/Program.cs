namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda nimi");

            // siin on muutuja nimega,
            // mis on tuubiga string
            // loeb andmeid konsoolist ja salvestab 
            // need muutuja sisse
            string name = Console.ReadLine();

            // kui muutuja name on tühi, siis väljastab konsoolile
            if (name != "")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tere, " + name);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Tere, tundmatu! ERROR");
                Console.Beep();
                Thread.Sleep(1000);
            }
        }
    }
}
