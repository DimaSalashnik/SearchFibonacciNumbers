using System;

namespace FibonacciNumberSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }

        static long firstNum = 1, secondNum = 1, sum = 0, number;
        static bool shutUp = false;
        static void Process()
        {
            Console.WriteLine("До какого числа считать ряд Фибоначчи?   To what number count Fibonacci series?");
            try { number = Convert.ToInt64(Console.ReadLine()); Search(); }
            catch { Console.Clear(); Process(); }
            Console.WriteLine();
            Repeat();
        }

        static void Search()
        {
            Console.Write($"{firstNum} {secondNum}");
            while (number >= sum)
            {
                sum = firstNum + secondNum;
                Console.Write($" {sum}");
                firstNum = secondNum;
                secondNum = sum;
            }
        }

        static void Repeat()
        {
            if (shutUp == false)
            {
                Console.WriteLine("Завершить работу? (да/нет)    To finish work? (yes/no)");
                string answer = Console.ReadLine().ToLower().ToString();
                if (answer == "да" || answer == "yes") { answer = ""; shutUp = true; return; }
                else if (answer == "нет" || answer == "no")
                {
                    firstNum = 1;
                    secondNum = 1;
                    sum = 0;
                    number = 0;
                    answer = "";
                    Console.Clear();
                    Process();
                }
                else { Console.WriteLine("Повторите попытку...    Try again..."); answer = ""; Console.Clear(); Repeat(); }
            }
            return;
        }
    }
}
