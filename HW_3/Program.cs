using System;
using System.ComponentModel;

internal class Program
{
    static void Main(string[] args)
    {
        
         
        Console.WriteLine("Enter number of rows: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of columns: ");
        int B = Convert.ToInt32(Console.ReadLine());

        int k = A;

        if (A < B)
            while (A <= B)
            {
                for (int i = 0; i < A; i++) Console.Write($"{A} ");
                Console.WriteLine();
                A++;
            }
        else
        {
            Console.WriteLine("Wrong input!");
        }
    }
}

