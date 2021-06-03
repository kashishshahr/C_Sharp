using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\Kashish\Desktop\ReadText.txt");

                Console.WriteLine(content);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("File PROOBLEMMMMM!");
                Console.WriteLine(e.Message);
            }
            catch(DirectoryNotFoundException d)
            {
                Console.WriteLine("Directory PROOBLEMMMMM!");
                Console.WriteLine(d.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("An Exception Occur!");
            }
            finally
            {
                //COde to finalize
                //setting objects to null
                //Closing database connections
                Console.WriteLine("Closing Application now");
            Console.Read();
            }

        }
    }
}
