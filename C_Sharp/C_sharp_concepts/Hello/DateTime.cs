using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hello
{
    class DateTimee
    {
        static void DateTimeeMain(string[]args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());//Defualt
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToLongTimeString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.TimeOfDay);
            Console.WriteLine(myValue.AddDays(5).ToLongDateString());
            
            Console.WriteLine(myValue.AddHours(2).ToLongTimeString());

            DateTime myBday = new DateTime(2000,1,20);
            Console.Write("Bdate:");
            Console.WriteLine(myBday.ToLongDateString());
            DateTime myBdayy = DateTime.Parse("20/01/2000");
            Console.Write("Bdate:");
            Console.WriteLine(myBdayy);

            TimeSpan myAge = DateTime.Now.Subtract(myBdayy);
            Console.Write("Age: ");
            Console.WriteLine(myAge.TotalDays);

            Console.Read();                
        }
    }
}
