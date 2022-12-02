using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BinaryClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;          
            Console.Title = "BinaryClock";
            DateTime currentDateTime = DateTime.Now;

            while (true)
            {
                currentDateTime = clock(currentDateTime);
                binaryClock(currentDateTime);
                Thread.Sleep(10);
            }
        }

        private static void binaryClock(DateTime currentDateTime)
        {
            Console.WriteLine("Binary clock: ");
            int hour = Binary(currentDateTime.Hour);
            int minute = Binary(currentDateTime.Minute);
            int second = Binary(currentDateTime.Second);
            Console.WriteLine("Hour:   {0:000000}", hour);
            Console.WriteLine("Minute: {0:000000}", minute);
            Console.WriteLine("Second: {0:000000}", second);
        }

        private static DateTime clock(DateTime currentDateTime)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Current time:");
            currentDateTime = DateTime.Now;
            Console.SetCursorPosition(0, 1);
            Console.WriteLine(String.Format("{0:00}:{1:00}:{2:00}", currentDateTime.Hour, currentDateTime.Minute, currentDateTime.Second));
            Console.WriteLine();
            return currentDateTime;
        }
        
        private static int Binary(int timeElement)
        {
            int x = 0;
            x = Convert.ToInt32(Convert.ToString(timeElement, 2));
            return x;
        }
    }
}