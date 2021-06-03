using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

            //Final Event Driven Api 
namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);
            myTimer.Elapsed += My_Timer_Elapsed;
            myTimer.Elapsed += My_Timer_Elapsed1;
            myTimer.Start();
            Console.WriteLine("Press Enter to remove the red event");
            Console.ReadLine();
            myTimer.Elapsed -= My_Timer_Elapsed1;
            Console.ReadLine();
        }
        private static void My_Timer_Elapsed(object sender ,ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Elpased:{0:HH:mm:ss.fff}",e.SignalTime);
        }
        private static void My_Timer_Elapsed1(object sender ,ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elpased1:{0:HH:mm:ss.fff}",e.SignalTime);
        }
    }
}
