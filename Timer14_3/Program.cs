using System;

namespace Timer14_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter time as, D:HH:MM:SS");
                SetTimer timer = new SetTimer(Console.ReadLine());
                timer.TimerCount();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Incorrect format. Please use colon(:) between D:H:M:S");
            }
            
            Console.ReadLine();
        }
    }
}