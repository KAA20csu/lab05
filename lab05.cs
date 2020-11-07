using System;
using System.Threading;

namespace lab_05_my_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для нахождения факториала: ");
            int numfac = int.Parse(Console.ReadLine());
            var factorial = 1;
            for(int i = 2; i<=numfac; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(".....................................");
            
            Console.WriteLine("Факториал равен:");
            Console.WriteLine("");
            int e = 0;
            do
            {


                Console.Clear();

                Thread.Sleep(1000);

                ramo4ka(Convert.ToString(factorial));

                Thread.Sleep(1000);
                Random random = new Random();
                Console.ForegroundColor = GetRandomConsoleColor(random);
                Thread.Sleep(1000);
                Console.BackgroundColor = GetRandomConsoleColor(random);
            }
            while (e < 1);
            
            
        }
        static void ramo4ka(string factorial)
        {
            var MaxLength = factorial.Length;
            
            for(int i = 0; i < 10; i++)
                Console.WriteLine("");

            Console.Write("                              ");
            Console.Write("╔═");
            ramo4ka2(Convert.ToString(factorial));
            Console.WriteLine("═╗");

            Console.Write("                              ");
            Console.WriteLine("║ " + factorial + " ║");

            Console.Write("                              ");
            Console.Write("╚═");
            ramo4ka2(Convert.ToString(factorial));
            Console.WriteLine("═╝");
        }
        static void ramo4ka2(string factroial)
        {
            
            for (int i = 0; i < factroial.Length; i++)
            {
                
                    Console.Write("═");
            }
            
        }
        private static ConsoleColor GetRandomConsoleColor(Random rnd)
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(rnd.Next(consoleColors.Length));
        }
    }
}
