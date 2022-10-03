using System;

namespace HW_task_1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type any character/word: ");
        int ch = 0;
        ConsoleKey key;
        do
        {
            key = Console.ReadKey().Key;
           if (key != ConsoleKey.OemPeriod)
            {
                ch++;
            }
        }
        while (key != ConsoleKey.OemPeriod);
        Console.WriteLine();
        Console.WriteLine("Number of characters counted = {0}", ch);
    }
}

