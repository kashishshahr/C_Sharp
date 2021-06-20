using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutCSharp
{
    class ExceptionPractice
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hey");
            string fileText=File.ReadAllText("E:/InternShip/c#/SI/C_Sharp/C_sharp_concepts/MoreAboutCSharp/SampleFiles/Data.txt");
            Console.WriteLine(fileText);
            Console.Read();
        }
    }
}
