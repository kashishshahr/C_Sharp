using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void FMain(string[] args)
        {

            string zig = "You can " + "if you";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hello
//{ 
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            //OOps  Classes and Objects

//            player p1=new player();
            
//            Console.WriteLine(p1.name);
//            Console.WriteLine(p1.getHealth());
//            p1.setHealth(45);
//            Console.WriteLine(p1.getHealth());

//            Console.WriteLine("Hey {}");



//            //Console.WriteLine("Hello World!");
//            //Console.Write("Hello World!");
//            //Console.Write("Hello World!");


//            //string name = Console.ReadLine();
//            //string candies = Console.ReadLine();
//            //Console.WriteLine($"Your name is {name}. Candies: {candies}");
//            Console.Write("\n Press Enter To exit Program");

//            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
//            int[] numbers1 = new int[5] { 1, 2, 3, 4, 5 };
            

//            Console.ReadLine();

            
//        }
//    }
//}
