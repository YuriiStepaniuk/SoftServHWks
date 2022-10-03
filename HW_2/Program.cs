using System;
using System.Globalization;

namespace HW_task_1;

internal class Program
{
    static void Main(string[] args)
    {
        string sticket = Console.ReadLine();
        if (sticket.Length == 6)
        {

            int ticket = Convert.ToInt32(sticket);
            Console.WriteLine((Convert.ToInt32(Convert.ToString(sticket)[0].ToString()) +
                               Convert.ToInt32(Convert.ToString(sticket)[1].ToString()) +
                               Convert.ToInt32(Convert.ToString(sticket)[2].ToString())) ==
                              (Convert.ToInt32(Convert.ToString(sticket)[3].ToString()) +
                               Convert.ToInt32(Convert.ToString(sticket)[4].ToString()) +
                               Convert.ToInt32(Convert.ToString(sticket)[5].ToString()))
                ? "Ticket is lucky"
                : "Ticket is not lucky");
        }

        else
        {
            Console.WriteLine("End of programm");        
        }
        Console.ReadLine();
    }
}

